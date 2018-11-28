using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USEPA_Simulation_PlugIns
{
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public partial class GreenScopeForm : Form
    {
        string excelFileName;
        string processReferenceTemperatureUnit = "Celsius";
        string referenceTemperatureUnit = "Celsius";
        string referencePressureUnit = "kPa";
        double processReferenceTemperature = 60;
        double referenceTemperature = 25;
        double referencePressure = 101.325;
        DataTable feedStreamsTable;
        int[] m_FeedRenewableStreamIds = new int[0];
        int[] m_ProductStreamIds = new int[0];
        int[] m_ProductStreamProductOrWastes = new int[0];
        int[] m_ProductStreamEcoProducts = new int[0];
        int[] m_ProductStreamRenewables = new int[0];
        DataTable productStreamsTable;
        int mainGlobalReaction = 0;
        int mainGlobalProduct = 0;
        int mainGlobalProductStream = 0;
        double[] stoichiometry = new double[0];
        bool updatingComponents = true;

        private System.Data.DataTable compounds;
        private System.Data.DataTable allStreams;
        private System.Data.DataTable inletStreams;
        private System.Data.DataTable outletStreams;
        private System.Data.DataTable unitOps;
        private USEPA_Simulation_PlugIns.ICapeFlowsheetMonitoring p_Monitoring;
        private System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification> p_Units;
        private System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification> p_Streams;
        private System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification> p_InletStreams;
        private System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification> p_OutletStreams;
        private double energy;
        //private System.Data.DataTable warData;

        public GreenScopeForm(ICapeFlowsheetMonitoring monitoring)
        {
            InitializeComponent();
            p_Monitoring = monitoring;
            p_Units = new System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification>();
            p_Streams = new System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification>();
            p_InletStreams = new System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification>();
            p_OutletStreams = new System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification>();
            energy = 0;
            // productStreams = new System.Collections.ArrayList();
            compounds = new System.Data.DataTable();
            this.dataGridView1.DataSource = compounds;
            allStreams = new System.Data.DataTable();
            this.dataGridView2.DataSource = allStreams;
            inletStreams = new System.Data.DataTable();
            this.dataGridView3.DataSource = inletStreams;
            outletStreams = new System.Data.DataTable();
            this.dataGridView4.DataSource = outletStreams;
            unitOps = new System.Data.DataTable();
            this.dataGridView5.DataSource = unitOps;
            compounds.Columns.Add("Compound Name", typeof(System.String));
            compounds.Columns.Add("Chemical Formula", typeof(System.String));
            compounds.Columns.Add("Molecular Weight", typeof(double));
            compounds.Columns.Add("CAS Number", typeof(System.String));
            compounds.Columns.Add("Boiling Point", typeof(double));
            compounds.Columns.Add("Freezing Point", typeof(double));
            compounds.Columns.Add("Heat capacity (Cp)", typeof(double));
            compounds.Columns.Add("Liquid Density", typeof(double));
            compounds.Columns.Add("Vapor Density", typeof(double));
            compounds.Columns.Add("Stand Heat of Formation", typeof(double));
            compounds.Columns.Add("Stand Entropy of Formation", typeof(double));
            compounds.Columns.Add("Vapor Pressure", typeof(double));
            allStreams.Columns.Add("Stream Name", typeof(System.String));
            allStreams.Columns.Add("Temperature", typeof(double));
            allStreams.Columns.Add("Pressure", typeof(double));
            allStreams.Columns.Add("MVF", typeof(double));
            allStreams.Columns.Add("Total Flow", typeof(double));
            allStreams.Columns.Add("Enthalpy", typeof(double));
            allStreams.Columns.Add("Entropy", typeof(double));
            inletStreams.Columns.Add("Stream Name", typeof(System.String));
            inletStreams.Columns.Add("Temperature", typeof(double));
            inletStreams.Columns.Add("Pressure", typeof(double));
            inletStreams.Columns.Add("MVF", typeof(double));
            inletStreams.Columns.Add("Total Flow", typeof(double));
            inletStreams.Columns.Add("Enthalpy", typeof(double));
            inletStreams.Columns.Add("Entropy", typeof(double));
            outletStreams.Columns.Add("Stream Name", typeof(System.String));
            outletStreams.Columns.Add("Temperature", typeof(double));
            outletStreams.Columns.Add("Pressure", typeof(double));
            outletStreams.Columns.Add("MVF", typeof(double));
            outletStreams.Columns.Add("Total Flow", typeof(double));
            outletStreams.Columns.Add("Enthalpy", typeof(double));
            outletStreams.Columns.Add("Entropy", typeof(double));
            unitOps.Columns.Add("Unit Name", typeof(System.String));
            this.ResetStreams();
            this.UpdateStreams();
            this.PutStreamsInDataTable(p_Streams, allStreams);
            this.PutStreamsInDataTable(p_InletStreams, inletStreams);
            this.PutStreamsInDataTable(p_OutletStreams, outletStreams);
            this.PutUnitOpsInDataTable(p_Units, unitOps);
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            //excelFileName = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            saveFileDialog1.FileName = excelFileName;
            saveFileDialog1.ShowDialog();
            excelFileName = String.Copy(saveFileDialog1.FileName);
            this.label2.Text = String.Concat("Excel File Name:  ", excelFileName);
        }

        private void Process()
        {
            DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheet;
            DocumentFormat.OpenXml.Packaging.SpreadsheetDocument greenScopeTemplate;
            if (System.IO.File.Exists(excelFileName))
            {
                string message = "Excel File Exists. Do you want to replace it?.";
                string caption = "Overwrite Excel File.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(message, caption, buttons);
                if (result != System.Windows.Forms.DialogResult.Yes)
                {
                    //this.Cursor = oldCursor;
                    return;
                }
                spreadsheet = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.Open(excelFileName, true);
            }
            else
            {
                spreadsheet = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.Create(excelFileName, DocumentFormat.OpenXml.SpreadsheetDocumentType.MacroEnabledWorkbook);
                greenScopeTemplate = DocumentFormat.OpenXml.Packaging.SpreadsheetDocument.Open(new System.IO.MemoryStream(Properties.Resources.GRNS_data_Template_08_2016), true);

                //Make sure it's clear
                spreadsheet.DeleteParts<DocumentFormat.OpenXml.Packaging.OpenXmlPart>(spreadsheet.GetPartsOfType<DocumentFormat.OpenXml.Packaging.OpenXmlPart>());

                //Copy all parts into the new book
                foreach (DocumentFormat.OpenXml.Packaging.OpenXmlPart part in greenScopeTemplate.GetPartsOfType<DocumentFormat.OpenXml.Packaging.OpenXmlPart>())
                {
                    DocumentFormat.OpenXml.Packaging.OpenXmlPart newPart = spreadsheet.AddPart<DocumentFormat.OpenXml.Packaging.OpenXmlPart>(part);
                }
                //Close template
                greenScopeTemplate.Close();
            }

            System.Windows.Forms.MessageBox.Show("Hello");
            this.AddInputStreamsToSpreadsheet(spreadsheet, p_InletStreams);


            //Perform 'save as'
            spreadsheet.WorkbookPart.Workbook.CalculationProperties.ForceFullCalculation = true;
            spreadsheet.WorkbookPart.Workbook.Save();
            spreadsheet.Close();
            //this.progressBar1.Value = 100;
            //this.Cursor = oldCursor;
            System.Windows.Forms.DialogResult msgBxResult = System.Windows.Forms.MessageBox.Show(this, "You can now browse the information or close the application." + Environment.NewLine + "Click 'Yes' to open the Excel File, 'No' to Exit the program," + Environment.NewLine + "or 'Cancel' to return to the program.", "Extraction Complete.", MessageBoxButtons.YesNoCancel);
            if (msgBxResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(excelFileName);
                this.Close();
            }
            if (msgBxResult == DialogResult.No) this.Close();

        }

        void PutUnitOpsInDataTable(List<USEPA_Simulation_PlugIns.ICapeIdentification> units, DataTable table)
        {
            table.Rows.Clear();
            foreach (USEPA_Simulation_PlugIns.ICapeIdentification p_Unit in units)
            {
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                row["Unit Name"] = p_Unit.ComponentName;
            }
        }

        void ClearUnitArrays()
        {
            try
            {
                p_Units.Clear();
            }
            catch (System.Exception p_Ex)
            {
                System.Windows.Forms.MessageBox.Show(p_Ex.Message);
            }
        }

        void PutStreamsInDataTable(List<USEPA_Simulation_PlugIns.ICapeIdentification> streams, DataTable table)
        {
            table.Rows.Clear();
            foreach (USEPA_Simulation_PlugIns.ICapeIdentification p_Stream in streams)
            {
                if (p_Stream is USEPA_Simulation_PlugIns.ICapeThermoMaterial)
                {
                    USEPA_Simulation_PlugIns.ICapeThermoMaterial p_TMO = (USEPA_Simulation_PlugIns.ICapeThermoMaterial)p_Stream;
                    System.Data.DataRow row = table.NewRow();
                    table.Rows.Add(row);
                    row["Stream Name"] = p_Stream.ComponentName;
                    object obj = null;
                    object obj1 = null;
                    p_TMO.GetPresentPhases(ref obj, ref obj1);
                    string[] phaseLabels = (string[])obj;
                    int[] phaseStatus = (int[])obj1;
                    bool VaporPresent = false;
                    foreach (string str in phaseLabels)
                    {
                        if (str.Equals("vapor", StringComparison.CurrentCultureIgnoreCase)) VaporPresent = true;
                    }
                    double[] fraction = { 0 };
                    if (VaporPresent)
                    {
                        p_TMO.GetSinglePhaseProp("phaseFraction", "vapor", "mole", ref fraction);
                        fraction = (double[])obj;
                    }
                    row["MVF"] = fraction[0];
                    p_TMO.GetOverallProp("totalFlow", "mass", ref obj);
                    double[] value = (double[])obj;
                    double totalFlow = value[0];
                    row["Total Flow"] = totalFlow * 3600;
                    double temp = 0;
                    double press = 0;
                    p_TMO.GetOverallTPFraction(ref temp, ref press, ref obj);
                    value = (double[])obj;
                    row["Temperature"] = temp;
                    row["Pressure"] = press;
                    for (int i = 0; i < value.Length; i++)
                    {
                        row[7 + i] = value[i];
                    }
                    USEPA_Simulation_PlugIns.ICapeThermoMaterial material = p_TMO.CreateMaterial();
                    material.CopyFromMaterial(p_TMO);
                    material.GetPresentPhases(ref obj, ref obj1);
                    string[] phases = (string[])obj;
                    USEPA_Simulation_PlugIns.eCapePhaseStatus[] statuses = (USEPA_Simulation_PlugIns.eCapePhaseStatus[])obj1;
                    string[] props = { "enthalpyF", "entropyF" };
                    double enthalpy = 0.0;
                    double entropy = 0.0;

                    for (int i = 0; i < phases.Length; i++)
                    {
                        if (statuses[i] == USEPA_Simulation_PlugIns.eCapePhaseStatus.CAPE_ATEQUILIBRIUM || statuses[i] == USEPA_Simulation_PlugIns.eCapePhaseStatus.CAPE_ESTIMATES)
                        {
                            ((USEPA_Simulation_PlugIns.ICapeThermoPropertyRoutine)(material)).CalcSinglePhaseProp(props, phases[i]);
                            material.GetSinglePhaseProp("enthalpyF", phases[i], "mass", ref obj);
                            value = (double[])obj;
                            enthalpy = enthalpy + value[0];
                            material.GetSinglePhaseProp("entropyF", phases[i], "mass", ref obj);
                            value = (double[])obj;
                            entropy = entropy + value[0];
                        }
                        else
                        {

                        }
                    }
                    row["Enthalpy"] = enthalpy * totalFlow * 3600 / 1000000;
                    row["Entropy"] = entropy * totalFlow * 3600 / 1000000;
                    if (System.Runtime.InteropServices.Marshal.IsComObject(p_TMO)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_TMO);

                }
                else if (p_Stream is USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)
                {
                    System.Windows.Forms.MessageBox.Show("Flowsheet Monitoring no longer supports Thermodynamics 1.0.", "Thermo 1.0 not supported", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //USEPA_Simulation_PlugIns.ICapeThermoMaterialObject p_TMO = (USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)p_Stream;
                    //System.Data.DataRow row = table.NewRow();
                    //table.Rows.Add(row);
                    //row["Stream Name"] = p_Stream.ComponentName;
                    //row["Type"] = "Inlet";
                    //String[] comps = (String[])p_TMO.ComponentIds;
                    //String[] phases = (String[])p_TMO.PhaseIds;
                    //bool VaporPresent = false;
                    //foreach (string str in (string[])phases)
                    //{
                    //    if (str.Equals("vapor", StringComparison.CurrentCultureIgnoreCase)) VaporPresent = true;
                    //}
                    //double[] fraction = { 0 };
                    //if (VaporPresent)
                    //{
                    //    fraction = (double[])p_TMO.GetProp("fraction", "vapor", null, null, "mole");
                    //}
                    //row["MVF"] = fraction[0];
                    //double[] flow = (double[])p_TMO.GetProp("totalFlow", "overall", null, null, "mass");
                    //row["Total Flow"] = flow[0] * 3600;
                    //fraction = (double[])p_TMO.GetProp("fraction", "overall", comps, null, "mole");
                    //for (int i = 0; i < comps.Length; i++)
                    //{
                    //    row[comps[i]] = fraction[i];
                    //}
                    //if (System.Runtime.InteropServices.Marshal.IsComObject(p_TMO)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_TMO);
                }
            }
        }

        void ClearStreamArrays()
        {
            try
            {
                p_Streams.Clear();
                p_InletStreams.Clear();
                p_OutletStreams.Clear();
            }
            catch (System.Exception p_Ex)
            {
                System.Windows.Forms.MessageBox.Show(p_Ex.Message);
            }
        }


        void UpdateStreams()
        {
            this.compounds.Rows.Clear();
            energy = 0;
            foreach (USEPA_Simulation_PlugIns.ICapeIdentification p_Stream in p_InletStreams)
            {
                if (p_Stream is USEPA_Simulation_PlugIns.ICapeThermoMaterial)
                {
                    USEPA_Simulation_PlugIns.ICapeThermoCompounds p_Compounds = (USEPA_Simulation_PlugIns.ICapeThermoCompounds)p_Stream;
                    object obj1 = null;
                    object obj2 = null;
                    object obj3 = null;
                    object obj4 = null;
                    object obj5 = null;
                    object obj6 = null;
                    p_Compounds.GetCompoundList(ref obj1, ref obj2, ref obj3, ref obj4, ref obj5, ref obj6);
                    String[] comps = (String[])obj1;
                    String[] chemForms = (String[])obj2;
                    String[] names = (String[])obj3;
                    double[] boilPoints = (double[])obj4;
                    double[] molWts = (double[])obj5;
                    String[] casNos = (String[])obj6;
                    dynamic constList = p_Compounds.GetConstPropList();
                    dynamic constants = p_Compounds.GetCompoundConstant((string[])constList, comps);
                    constList = p_Compounds.GetTDependentPropList();
                    p_Compounds.GetTDependentProperty((string[])constList, 298.15, comps, ref obj1);
                    for (int i = 0; i < comps.Length; i++)
                    {
                        bool needsAdded = true;
                        foreach (System.Data.DataRow row in compounds.Rows)
                        {
                            if (comps[i] == row["Compound Name"].ToString())
                            {
                                needsAdded = false;
                            }
                        }
                        if (needsAdded)
                        {
                            System.Data.DataRow newRow = compounds.NewRow();
                            compounds.Rows.Add(newRow);
                            newRow["Compound Name"] = comps[i];
                            newRow["Chemical Formula"] = chemForms[i].ToString();
                            newRow["Molecular Weight"] = Convert.ToDouble(molWts[i]);
                            newRow["CAS Number"] = casNos[i].ToString();
                            newRow["Boiling Point"] = boilPoints[i];
                            //newRow["Freezing Point"] = comps[i];
                            //newRow["Heat capacity (Cp)"] = comps[i];
                            //newRow["Liquid Density"] = comps[i];
                            //newRow["Vapor Density"] = comps[i];
                            //newRow["Stand Heat of Formation"] = comps[i];
                            //newRow["Stand Entropy of Formation"] = comps[i];
                            //newRow["Vapor Pressure"] = comps[i];
                            if (!allStreams.Columns.Contains(comps[i])) allStreams.Columns.Add(comps[i]);
                            if (!inletStreams.Columns.Contains(comps[i])) inletStreams.Columns.Add(comps[i]);
                            if (!outletStreams.Columns.Contains(comps[i])) outletStreams.Columns.Add(comps[i]);
                        }
                    }
                    if (System.Runtime.InteropServices.Marshal.IsComObject(p_Compounds)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_Compounds);
                }
                else if (p_Stream is USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)
                {
                    USEPA_Simulation_PlugIns.ICapeThermoMaterialObject p_TMO = (USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)p_Stream;
                    String[] comps = (String[])(p_TMO.ComponentIds);
                    String[] propNames = new String[1];
                    propNames[0] = "casRegistryNumber";
                    Object[] casNos = (Object[])p_TMO.GetComponentConstant(propNames, comps);
                    propNames[0] = "chemicalFormula";
                    Object[] chemForms = (Object[])p_TMO.GetComponentConstant(propNames, comps);
                    propNames[0] = "structureFormula";
                    Object[] structForms = (Object[])p_TMO.GetComponentConstant(propNames, comps);
                    propNames[0] = "molecularWeight";
                    Object[] molWts = (Object[])p_TMO.GetComponentConstant(propNames, comps);
                    double[] inletFlow = (double[])p_TMO.GetProp("flow", "overall", comps, null, "mass");
                    for (int i = 0; i < comps.Length; i++)
                    {
                        bool needsAdded = true;
                        foreach (System.Data.DataRow row in compounds.Rows)
                        {
                            if (comps[i] == row["Compound Name"].ToString())
                            {
                                needsAdded = false;
                            }
                        }
                        if (needsAdded)
                        {
                            System.Data.DataRow newRow = compounds.NewRow();
                            compounds.Rows.Add(newRow);
                            newRow["Compound Name"] = comps[i];
                            newRow["CAS Number"] = casNos[i].ToString();
                            newRow["Chemical Formula"] = chemForms[i].ToString();
                            newRow["Molecular Weight"] = Convert.ToDouble(molWts[i]);
                            if (!allStreams.Columns.Contains(comps[i])) allStreams.Columns.Add(comps[i]);
                            if (!inletStreams.Columns.Contains(comps[i])) inletStreams.Columns.Add(comps[i]);
                            if (!outletStreams.Columns.Contains(comps[i])) outletStreams.Columns.Add(comps[i]);
                        }
                    }
                    if (System.Runtime.InteropServices.Marshal.IsComObject(p_TMO)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_TMO);
                }
                else
                {
                    if (p_Stream is USEPA_Simulation_PlugIns.ICapeCollection)
                    {
                        USEPA_Simulation_PlugIns.ICapeCollection p_Coll = (USEPA_Simulation_PlugIns.ICapeCollection)p_Stream;
                        USEPA_Simulation_PlugIns.ICapeParameter p_Param = (USEPA_Simulation_PlugIns.ICapeParameter)p_Coll.Item("work");
                        double energyFlow = Convert.ToDouble(p_Param.value);
                        energy = energy - energyFlow * 3600 / 1000000;
                        if (System.Runtime.InteropServices.Marshal.IsComObject(p_Coll)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_Coll);
                        if (System.Runtime.InteropServices.Marshal.IsComObject(p_Param)) System.Runtime.InteropServices.Marshal.ReleaseComObject(p_Param);
                    }
                }
            }
        }

        void ResetStreams()
        {
            this.label5.Text = "";
            this.ClearStreamArrays();
            this.ClearUnitArrays();
            USEPA_Simulation_PlugIns.ICapeCollection p_UnitColl = (USEPA_Simulation_PlugIns.ICapeCollection)p_Monitoring.GetUnitOperationCollection();
            USEPA_Simulation_PlugIns.ICapeCollection p_StreamColl = (USEPA_Simulation_PlugIns.ICapeCollection)p_Monitoring.GetStreamCollection();
            //
            // Tab Page 2 - Unit Operations...
            //
            for (int i = 0; i < p_StreamColl.Count(); i++)
            {
                if (p_StreamColl.Item(i + 1) is USEPA_Simulation_PlugIns.ICapeIdentification)
                {
                    USEPA_Simulation_PlugIns.ICapeIdentification p_Stream = (USEPA_Simulation_PlugIns.ICapeIdentification)p_StreamColl.Item(i + 1);
                    p_Streams.Add(p_Stream);
                    p_InletStreams.Add(p_Stream);
                    p_OutletStreams.Add(p_Stream);
                }
            }
            for (int i = 0; i < p_UnitColl.Count(); i++)
            {
                USEPA_Simulation_PlugIns.ICapeUnit p_Unit = (USEPA_Simulation_PlugIns.ICapeUnit)p_UnitColl.Item(i + 1);
                String unitName = ((USEPA_Simulation_PlugIns.ICapeIdentification)p_Unit).ComponentName;
                USEPA_Simulation_PlugIns.ICapeCollection p_UnitPortColl = (USEPA_Simulation_PlugIns.ICapeCollection)p_Unit.ports;
                if (p_UnitPortColl.Count() > 1)
                {
                    p_Units.Add((USEPA_Simulation_PlugIns.ICapeIdentification)p_Unit);
                    for (int j = 0; j < p_UnitPortColl.Count(); j++)
                    {
                        USEPA_Simulation_PlugIns.ICapeUnitPort p_Port = (USEPA_Simulation_PlugIns.ICapeUnitPort)p_UnitPortColl.Item(j + 1);
                        if (p_Port.connectedObject != null)
                        {
                            USEPA_Simulation_PlugIns.ICapeIdentification p_Id = (USEPA_Simulation_PlugIns.ICapeIdentification)p_Port.connectedObject;
                            String streamName = p_Id.ComponentName;
                            if (p_Port.direction == USEPA_Simulation_PlugIns.CapePortDirection.CAPE_INLET)
                            {
                                int objectToRemove = 0;
                                for (int k = 0; k < p_OutletStreams.Count; k++)
                                {
                                    String currStream = p_OutletStreams[k].ComponentName;
                                    if (currStream == streamName)
                                    {
                                        objectToRemove = k;
                                    }
                                }
                                p_OutletStreams.RemoveAt(objectToRemove);
                            }
                            if (p_Port.direction == USEPA_Simulation_PlugIns.CapePortDirection.CAPE_OUTLET)
                            {
                                int objectToRemove = 0;
                                for (int k = 0; k < p_InletStreams.Count; k++)
                                {
                                    if (p_InletStreams[k].ComponentName == streamName)
                                    {
                                        objectToRemove = k;
                                    }
                                }
                                p_InletStreams.RemoveAt(objectToRemove);
                            }
                        }
                        else
                        {
                            if (p_Port.portType == USEPA_Simulation_PlugIns.CapePortType.CAPE_ENERGY)
                                this.label5.Text = "NOTE: Not all energy Ports are connected.";
                        }
                    }
                }
                //this.AvailableUnitOpsheckedListBox.Items.Add(((USEPA_Simulation_PlugIns.ICapeIdentification)(p_UnitColl.Item(i + 1))).ComponentName, true);
            }
            foreach (USEPA_Simulation_PlugIns.ICapeIdentification p_Id in p_InletStreams)
            {
                if (p_Id is USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)
                {
                    this.checkedListBox1.Items.Add(p_Id.ComponentName, false);
                }
            }
            foreach (USEPA_Simulation_PlugIns.ICapeIdentification p_Id1 in p_OutletStreams)
            {
                if (p_Id1 is USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)
                {
                    USEPA_Simulation_PlugIns.ICapeThermoMaterialObject p_MO = (USEPA_Simulation_PlugIns.ICapeThermoMaterialObject)p_Id1;
                    this.checkedListBox2.Items.Add(p_Id1.ComponentName, false);
                    this.checkedListBox5.Items.Add(p_Id1.ComponentName, false);
                }
            }
        }
        private void AddInputStreamsToSpreadsheet(DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheet, System.Collections.Generic.List<USEPA_Simulation_PlugIns.ICapeIdentification> streams)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Sheet> sheets = spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Where(s => s.Name == "I. Stream & Compound Data");
            if (sheets.Count() == 0)
            {
                // The specified worksheet does not exist.
                return;
            }
            string relationshipId = sheets.First().Id.Value;
            DocumentFormat.OpenXml.Packaging.WorksheetPart worksheetPart = (DocumentFormat.OpenXml.Packaging.WorksheetPart)spreadsheet.WorkbookPart.GetPartById(relationshipId);
            string[] componentColumns = { "H", "K", "N", "Q", "T", "W", "Z", "AC", "AF", "AI", "AL", "AO", "AR", "AU", "AX", "BA", "BD", "BG", "BJ", "BM", "BP", "BS", "BV", "BY", "CB", "CE", "CH", "CK", "CN", "CQ", "CT", "CW", "CZ", "DC", "DF", "DI", "DL", "DO", "DR", "DU" };
            string[] streamColumns = { "I", "L", "O", "R", "U", "X", "AA", "AD", "AG", "AJ", "AM", "AP", "AS", "AV", "AY", "BB", "BE", "BH", "BK", "BN", "BQ", "BT", "BW", "BZ", "CC", "CF", "CI", "CL", "CO", "CR", "CU", "CX", "DA", "DD", "DG", "DJ", "DM", "DP", "DS", "DV" };
            for (int i = 0; i < streams.Count; i++)
            {
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 28, streams[i].ComponentName);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 29, streams[i].ComponentName);
                ////SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 30, streams[i].Renewable ? "yes" : "no");
                //object temp = null;
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("totalFlow", "Mass", temp);
                //double[] massFlows = (double[])temp;
                //for (int j = 0; j < massFlows.Length; j++)
                //{
                //    SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], j + 32, massFlows[j]*3600);
                //}
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("temperature", "UNDEFINED", temp);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 83, ((double[])temp)[0]-273.15);
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("pressure", "UNDEFINED", temp);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 84, ((double[])temp)[0]);
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("fraction", "vapor", temp);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 85, ((double[])temp)[0]);
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("enthalpy", "UNDEFINED", temp);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 86, ((double[])temp)[0] * 3600);//streams[i].EnthalpyMJHR);
                //((USEPA_Simulation_PlugIns.ICapeThermoMaterial)streams[i]).GetOverallProp("entropy", "UNDEFINED", temp);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 87, ((double[])temp)[0] * 3600);//streams[i].EntropyMJKHR);
                //SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 91, streams[i].Cost);
            }
        }
        //private void AddReactionsToSpreadsheet(DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheet, List<UnitOperation> reactors, Stream stream)
        //{
        //    IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Sheet> sheets = spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Where(s => s.Name == "I. Stream & Compound Data");
        //    if (sheets.Count() == 0)
        //    {
        //        // The specified worksheet does not exist.
        //        return;
        //    }
        //    string relationshipId = sheets.First().Id.Value;
        //    DocumentFormat.OpenXml.Packaging.WorksheetPart worksheetPart = (DocumentFormat.OpenXml.Packaging.WorksheetPart)spreadsheet.WorkbookPart.GetPartById(relationshipId);
        //    string[] reactionColumns = { "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA" };
        //    for (int i = 0; i < reactors.Count; i++)
        //    {
        //        int startCell = 111;
        //        for (int j = 0; j < stream.NumberOfComponents; j++)
        //        {
        //            SetSpreadsheetCellValue(worksheetPart.Worksheet, reactionColumns[i], startCell + j, reactors[i].ReactionStoicCoeff(j));
        //        }
        //    }
        //}

        //private void AddOutputStreamsToSpreadsheet(DocumentFormat.OpenXml.Packaging.SpreadsheetDocument spreadsheet, Stream[] streams)
        //{
        //    IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Sheet> sheets = spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Where(s => s.Name == "I. Stream & Compound Data");
        //    if (sheets.Count() == 0)
        //    {
        //        // The specified worksheet does not exist.
        //        return;
        //    }
        //    string relationshipId = sheets.First().Id.Value;
        //    DocumentFormat.OpenXml.Packaging.WorksheetPart worksheetPart = (DocumentFormat.OpenXml.Packaging.WorksheetPart)spreadsheet.WorkbookPart.GetPartById(relationshipId);
        //    string[] componentColumns = { "H", "K", "N", "Q", "T", "W", "Z", "AC", "AF", "AI", "AL", "AO", "AR", "AU", "AX", "BA", "BD", "BG", "BJ", "BM", "BP", "BS", "BV", "BY", "CB", "CE", "CH", "CK", "CN", "CQ", "CT", "CW", "CZ", "DC", "DF", "DI", "DL", "DO", "DR", "DU" };
        //    string[] streamColumns = { "I", "L", "O", "R", "U", "X", "AA", "AD", "AG", "AJ", "AM", "AP", "AS", "AV", "AY", "BB", "BE", "BH", "BK", "BN", "BQ", "BT", "BW", "BZ", "CC", "CF", "CI", "CL", "CO", "CR", "CU", "CX", "DA", "DD", "DG", "DJ", "DM", "DP", "DS", "DV" };
        //    for (uint i = 0; i < streams.Length; i++)
        //    {
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 178, streams[i].StreamID);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 179, streams[i].Product ? 1 : 0);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 180, streams[i].StreamName);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 181, streams[i].EcoProduct ? 1 : 0);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 182, streams[i].Polluted ? 1 : 0);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, streamColumns[i], 183, streams[i].Renewable ? 1 : 0);
        //        for (int j = 0; j < streams[i].ComponentMassFlowRatesKGH.Length; j++)
        //        {
        //            SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], j + 186, streams[i].ComponentMassFlowRatesKGH[j]);
        //        }
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 237, streams[i].TemperatureC);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 238, streams[i].PressureKPa);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 239, streams[i].MoleVaporFraction);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 240, streams[i].EnthalpyMJHR);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 241, streams[i].EntropyMJKHR);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 243, streams[i].MoleVaporFraction < 0.1 ? streams[i].LiquidVolumetricFlowRateM3HR : streams[i].VaporVolumetricFlowRateM3Hr);
        //        SetSpreadsheetCellValue(worksheetPart.Worksheet, componentColumns[i], 246, streams[i].Cost);
        //    }
        //}

        // Given a worksheet, a column name, and a row index, gets the cell at the specified column and row.
        private DocumentFormat.OpenXml.Spreadsheet.Cell GetSpreadsheetCell(DocumentFormat.OpenXml.Spreadsheet.Worksheet worksheet, string columnName, uint rowIndex)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> rows = worksheet.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>().Elements<DocumentFormat.OpenXml.Spreadsheet.Row>().Where(r => r.RowIndex == rowIndex);
            if (rows.Count() == 0)
            {
                // A cell does not exist at the specified row.
                return null;
            }

            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> cells = rows.First().Elements<DocumentFormat.OpenXml.Spreadsheet.Cell>().Where(c => string.Compare(c.CellReference.Value, columnName + rowIndex, true) == 0);
            if (cells.Count() == 0)
            {
                // A cell does not exist at the specified column, in the specified row.
                return null;
            }

            return cells.First();
        }

        // Given a worksheet, a column name, and a row index, gets the cell at the specified column and row.
        private void SetSpreadsheetCellValue(DocumentFormat.OpenXml.Spreadsheet.Worksheet worksheet, string columnName, int rowIndex, string value)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> rows = worksheet.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>().Elements<DocumentFormat.OpenXml.Spreadsheet.Row>().Where(r => r.RowIndex == rowIndex);
            if (rows.Count() == 0)
            {
                // A cell does not exist at the specified row.
                return;
            }

            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> cells = rows.First().Elements<DocumentFormat.OpenXml.Spreadsheet.Cell>().Where(c => string.Compare(c.CellReference.Value, columnName + rowIndex, true) == 0);
            if (cells.Count() == 0)
            {
                // A cell does not exist at the specified column, in the specified row.
                return;
            }

            DocumentFormat.OpenXml.Spreadsheet.Cell cell = cells.First();
            if (cell != null)
            {
                // The specified cell does not exist.
                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(value);
                cell.DataType = new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>(DocumentFormat.OpenXml.Spreadsheet.CellValues.String);
            }
        }

        // Given a worksheet, a column name, and a row index, gets the cell at the specified column and row.
        private void SetSpreadsheetCellValueNumeric(DocumentFormat.OpenXml.Spreadsheet.Worksheet worksheet, string columnName, int rowIndex, string value)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> rows = worksheet.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>().Elements<DocumentFormat.OpenXml.Spreadsheet.Row>().Where(r => r.RowIndex == rowIndex);
            if (rows.Count() == 0)
            {
                // A cell does not exist at the specified row.
                return;
            }

            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> cells = rows.First().Elements<DocumentFormat.OpenXml.Spreadsheet.Cell>().Where(c => string.Compare(c.CellReference.Value, columnName + rowIndex, true) == 0);
            if (cells.Count() == 0)
            {
                // A cell does not exist at the specified column, in the specified row.
                return;
            }

            DocumentFormat.OpenXml.Spreadsheet.Cell cell = cells.First();
            if (cell != null)
            {
                // The specified cell does not exist.
                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(value);
                cell.DataType = new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>(DocumentFormat.OpenXml.Spreadsheet.CellValues.String);
            }
        }

        // Given a worksheet, a column name, and a row index, gets the cell at the specified column and row.
        private void SetSpreadsheetCellValue(DocumentFormat.OpenXml.Spreadsheet.Worksheet worksheet, string columnName, int rowIndex, int value)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> rows = worksheet.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>().Elements<DocumentFormat.OpenXml.Spreadsheet.Row>().Where(r => r.RowIndex == rowIndex);
            if (rows.Count() == 0)
            {
                // A cell does not exist at the specified row.
                return;
            }

            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> cells = rows.First().Elements<DocumentFormat.OpenXml.Spreadsheet.Cell>().Where(c => string.Compare(c.CellReference.Value, columnName + rowIndex, true) == 0);
            if (cells.Count() == 0)
            {
                // A cell does not exist at the specified column, in the specified row.
                return;
            }

            DocumentFormat.OpenXml.Spreadsheet.Cell cell = cells.First();
            if (cell != null)
            {
                // The specified cell does not exist.
                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(value.ToString());
                cell.DataType = new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>(DocumentFormat.OpenXml.Spreadsheet.CellValues.Number);
            }
        }

        // Given a worksheet, a column name, and a row index, gets the cell at the specified column and row.
        private void SetSpreadsheetCellValue(DocumentFormat.OpenXml.Spreadsheet.Worksheet worksheet, string columnName, int rowIndex, double value)
        {
            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Row> rows = worksheet.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>().Elements<DocumentFormat.OpenXml.Spreadsheet.Row>().Where(r => r.RowIndex == rowIndex);
            if (rows.Count() == 0)
            {
                // A cell does not exist at the specified row.
                return;
            }

            IEnumerable<DocumentFormat.OpenXml.Spreadsheet.Cell> cells = rows.First().Elements<DocumentFormat.OpenXml.Spreadsheet.Cell>().Where(c => string.Compare(c.CellReference.Value, columnName + rowIndex, true) == 0);
            if (cells.Count() == 0)
            {
                // A cell does not exist at the specified column, in the specified row.
                return;
            }

            DocumentFormat.OpenXml.Spreadsheet.Cell cell = cells.First();
            if (cell != null)
            {
                // The specified cell does not exist.
                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(value.ToString());
                cell.DataType = new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>(DocumentFormat.OpenXml.Spreadsheet.CellValues.Number);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int item = e.Index;
            bool itemChecked = checkedListBox2.GetItemChecked(item);
            string itemText = checkedListBox2.SelectedItem.ToString();
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
            {
                this.checkedListBox3.Items.Add(itemText);
                this.checkedListBox4.Items.Add(itemText);
                this.checkedListBox5.Items.Remove(itemText);
            }
            else
            {
                this.checkedListBox3.Items.Remove(itemText);
                this.checkedListBox4.Items.Remove(itemText);
                this.checkedListBox5.Items.Add(itemText);
            }
        }
    }
}
