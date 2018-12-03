using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace USEPA_Simulation_PlugIns
{

    // Progid: USEPA_Simulation_PlugIns.WARPlugIn

    /// <summary>
    /// Summary for WAR
    /// </summary>
    [Serializable()]
    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.Guid("96AEF1DF-8F22-40CC-85D2-563A4E7064EC")]
    [USEPA_Simulation_PlugIns.CapeName("WAR Plug-In")]
    [USEPA_Simulation_PlugIns.CapeAbout("Waste Reduction Algorithm Plug-in")]
    [USEPA_Simulation_PlugIns.CapeDescription("The Waste Reduction Algorithm Plug-in uses the .NET PIA.")]
    [USEPA_Simulation_PlugIns.CapeVersion("1.0")]
    [USEPA_Simulation_PlugIns.CapeVendorURL("http://www.epa.gov/nrmrl/std/sab/war/sim_war.htm")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [USEPA_Simulation_PlugIns.CapeFlowsheetMonitoringAttribute(true)]
    public class WARPlugIn : CapeObjectBase
    {

        /// <summary>Creates a new object that is a copy of the current instance.</summary>
        /// <remarks>
        /// <para>
        /// Clone can be implemented either as a deep copy or a shallow copy. In a deep copy, all objects are duplicated; 
        /// in a shallow copy, only the top-level objects are duplicated and the lower levels contain references.
        /// </para>
        /// <para>
        /// The resulting clone must be of the same type as, or compatible with, the original instance.
        /// </para>
        /// <para>
        /// See <see cref="Object.MemberwiseClone"/> for more information on cloning, deep versus shallow copies, and examples.
        /// </para>
        /// </remarks>
        /// <returns>A new object that is a copy of this instance.</returns>
        override public object Clone()
        {
            return new WARPlugIn();
        }

        private System.Data.DataTable warDataTable = new System.Data.DataTable();
        private void AddData(String XmlData)
        {
            System.Xml.XmlDocument document = new System.Xml.XmlDocument();
            document.LoadXml(XmlData);
            System.Xml.XmlNodeList list = document.SelectNodes("dataroot/data");
            System.Collections.IEnumerator ienum = list.GetEnumerator();
            while (ienum.MoveNext())
            {
                System.Xml.XmlNode current = (System.Xml.XmlNode)ienum.Current;
                System.Data.DataRow dataRow = warDataTable.NewRow();
                warDataTable.Rows.Add(dataRow);
                System.Collections.IEnumerator childEnum = current.ChildNodes.GetEnumerator();
                while (childEnum.MoveNext())
                {
                    System.Xml.XmlNode currentChild = (System.Xml.XmlNode)childEnum.Current;
                    if (currentChild.Name == "Mol_ID")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Mol Id"] = value;
                    }
                    if (currentChild.Name == "DIPPR ID")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["DIPPR ID"] = value;
                    }
                    if (currentChild.Name == "ASPENID")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["ASPENID"] = value;
                    }
                    if (currentChild.Name == "ChemicalName")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["ChemicalName"] = value;
                    }
                    if (currentChild.Name == "CAS")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["CAS"] = value;
                    }
                    if (currentChild.Name == "Formula")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Formula"] = value;
                    }
                    if (currentChild.Name == "CLASS")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["class"] = value;
                    }
                    if (currentChild.Name == "MW")
                    {
                        dataRow["molecularWeight"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "Rat_LD50_Value")
                    {
                        dataRow["Rat LD50"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "Rat_LD50_Notes")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Rat LD50 Notes"] = value;
                    }
                    if (currentChild.Name == "Rat_LD50_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Rat LD50 Source"] = value;
                    }
                    if (currentChild.Name == "OSHA_TWA_Value")
                    {
                        dataRow["OSHA PEL"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "OSHA_TWA_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["OSHA Source"] = value;
                    }
                    if (currentChild.Name == "OSHA_TWA_Notes")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["OSHA Notes"] = value;
                    }
                    if (currentChild.Name == "FHM_LC50_Value")
                    {
                        dataRow["Fathead LC50"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "FHM_LC50_Notes")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Fathead LC50 Notes"] = value;
                    }
                    if (currentChild.Name == "FHM_LC50_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Fathead LC50 Source"] = value;
                    }
                    if (currentChild.Name == "PCO_Value")
                    {
                        dataRow["Photochemical Oxidation Potential"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "PCO_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Photochemical Oxidation Potential Source"] = value;
                    }
                    if (currentChild.Name == "GWP_Value")
                    {
                        dataRow["Global Warming Potential"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "GWP_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Global Warming Potential Source"] = value;
                    }
                    if (currentChild.Name == "OD_Value")
                    {
                        dataRow["Ozone Depletion Potential"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "OD_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Ozone Depletion Potential Source"] = value;
                    }
                    if (currentChild.Name == "AP_Value")
                    {
                        dataRow["Acidification Potential"] = Convert.ToDouble(currentChild.InnerText);
                    }
                    if (currentChild.Name == "AP_Source")
                    {
                        String value = currentChild.InnerText;
                        while (value.StartsWith(" ")) value = value.Substring(1);
                        while (value.EndsWith(" ")) value = value.Remove(value.Length - 1);
                        dataRow["Acidification Potential Source"] = value;
                    }
                }
            }
        }

        /// <summary>
        ///	Displays the PMC graphic interface, if available.
        /// </summary>
        /// <remarks>
        /// The PMC displays its user interface and allows the Flowsheet User to 
        /// interact with it. If no user interface is available it returns an error.
        /// </remarks>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        public WARPlugIn()
        {
            if (System.Environment.Is64BitProcess) System.Windows.Forms.MessageBox.Show("64-bit Process");
            warDataTable = new System.Data.DataTable();
            warDataTable.Columns.Add("Mol Id", typeof(System.String));
            warDataTable.Columns.Add("DIPPR ID", typeof(System.String));
            warDataTable.Columns.Add("ASPENID", typeof(System.String));
            warDataTable.Columns.Add("ChemicalName", typeof(System.String));
            warDataTable.Columns.Add("CAS", typeof(System.String));
            warDataTable.Columns.Add("Formula", typeof(System.String));
            warDataTable.Columns.Add("class", typeof(System.String));
            warDataTable.Columns.Add("molecularWeight", typeof(double));
            warDataTable.Columns.Add("Rat LD50", typeof(double));
            warDataTable.Columns.Add("Rat LD50 Notes", typeof(System.String));
            warDataTable.Columns.Add("Rat LD50 Source", typeof(System.String));
            warDataTable.Columns.Add("OSHA PEL", typeof(double));
            warDataTable.Columns.Add("OSHA Notes", typeof(System.String));
            warDataTable.Columns.Add("OSHA Source", typeof(System.String));
            warDataTable.Columns.Add("Fathead LC50", typeof(double));
            warDataTable.Columns.Add("Fathead LC50 Notes", typeof(System.String));
            warDataTable.Columns.Add("Fathead LC50 Source", typeof(System.String));
            warDataTable.Columns.Add("Global Warming Potential", typeof(double));
            warDataTable.Columns.Add("Global Warming Potential Source", typeof(System.String));
            warDataTable.Columns.Add("Ozone Depletion Potential", typeof(double));
            warDataTable.Columns.Add("Ozone Depletion Potential Source", typeof(System.String));
            warDataTable.Columns.Add("Photochemical Oxidation Potential", typeof(double));
            warDataTable.Columns.Add("Photochemical Oxidation Potential Source", typeof(System.String));
            warDataTable.Columns.Add("Acidification Potential", typeof(double));
            warDataTable.Columns.Add("Acidification Potential Source", typeof(System.String));
            this.AddData(Resource1.WARdata);
        }

        ~WARPlugIn()
        {
            Dispose();
        }

        bool _disposed = false;

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        /// <summary>
        /// Releases the unmanaged resources used by the CapeIdentification object and optionally releases 
        /// the managed resources.
        /// </summary>
        /// <remarks><para>This method is called by the public <see href="http://msdn.microsoft.com/en-us/library/system.componentmodel.component.dispose.aspx">Dispose</see>see> 
        /// method and the <see href="http://msdn.microsoft.com/en-us/library/system.object.finalize.aspx">Finalize</see> method. 
        /// <bold>Dispose()</bold> invokes the protected <bold>Dispose(Boolean)</bold> method with the disposing
        /// parameter set to <bold>true</bold>. <see href="http://msdn.microsoft.com/en-us/library/system.object.finalize.aspx">Finalize</see> 
        /// invokes <bold>Dispose</bold> with disposing set to <bold>false</bold>.</para>
        /// <para>When the <italic>disposing</italic> parameter is <bold>true</bold>, this method releases all 
        /// resources held by any managed objects that this Component references. This method invokes the 
        /// <bold>Dispose()</bold> method of each referenced object.</para>
        /// <para><bold>Notes to Inheritors</bold></para>
        /// <para><bold>Dispose</bold> can be called multiple times by other objects. When overriding 
        /// <bold>Dispose(Boolean)</bold>, be careful not to reference objects that have been previously 
        /// disposed of in an earlier call to <bold>Dispose</bold>. For more information about how to 
        /// implement <bold>Dispose(Boolean)</bold>, see <see href="http://msdn.microsoft.com/en-us/library/fs2xkftw.aspx">Implementing a Dispose Method</see>.</para>
        /// <para>For more information about <bold>Dispose</bold> and <see href="http://msdn.microsoft.com/en-us/library/system.object.finalize.aspx">Finalize</see>, 
        /// see <see href="http://msdn.microsoft.com/en-us/library/498928w2.aspx">Cleaning Up Unmanaged Resources</see> 
        /// and <see href="http://msdn.microsoft.com/en-us/library/ddae83kx.aspx">Overriding the Finalize Method</see>.</para>
        /// </remarks> 
        /// <param name = "disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!_disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    //if (m_SimulationContext != null)
                    //{
                    //    if (m_SimulationContext.GetType().IsCOMObject)
                    //        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(m_SimulationContext);
                    //}
                    //m_SimulationContext = null;
                    //m_Parameters.Clear();
                    _disposed = true;
                }
                base.Dispose(disposing);
            }
        }

        /// <summary>
        ///	Displays the PMC graphic interface, if available.
        /// </summary>
        /// <remarks>
        /// The PMC displays its user interface and allows the Flowsheet User to 
        /// interact with it. If no user interface is available it returns an error.
        /// </remarks>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        public override System.Windows.Forms.DialogResult Edit()
        {
            try
            {
                System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.Retry;
                using (USEPA_Simulation_PlugIns.WARalgorithm war = new WARalgorithm(this.warDataTable, this.FlowsheetMonitoring))
                {
                    result = war.ShowDialog();
                }
                return result;
            }
            catch (System.Exception p_Ex)
            {
                this.throwException(new USEPA_Simulation_PlugIns.CapeUnknownException(p_Ex.Message, p_Ex));
                return System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
