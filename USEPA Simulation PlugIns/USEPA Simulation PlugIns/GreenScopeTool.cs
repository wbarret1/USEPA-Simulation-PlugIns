using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USEPA_Simulation_PlugIns
{
    /// <summary>
    /// Summary for GreenScope Tool
    /// </summary>
    [Serializable()]
    [System.Runtime.InteropServices.ComVisible(false)]
    [System.Runtime.InteropServices.Guid("42E26E78-D3CC-4949-8793-A90B08816E29")]
    [USEPA_Simulation_PlugIns.CapeName("GREENSCOPE Add-In")]
    [USEPA_Simulation_PlugIns.CapeAbout("GREENSCOPE Flowsheet Data Extraction Tool Add-in")]
    [USEPA_Simulation_PlugIns.CapeDescription("GREENSCOPE Flowsheet Data Extraction Tool Add-in")]
    [USEPA_Simulation_PlugIns.CapeVersion("1.0")]
    [USEPA_Simulation_PlugIns.CapeVendorURL("http://www.epa.gov/nrmrl/std/sab/war/sim_war.htm")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [USEPA_Simulation_PlugIns.CapeFlowsheetMonitoringAttribute(true)]
    public class GreenScopeTool : CapeObjectBase
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
            return new GreenScopeTool();
        }


        /// <summary>
        ///	Displays the PMC graphic interface, if available.
        /// </summary>
        /// <remarks>
        /// The PMC displays its user interface and allows the Flowsheet User to 
        /// interact with it. If no user interface is available it returns an error.
        /// </remarks>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        public GreenScopeTool()
        {
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
                USEPA_Simulation_PlugIns.GreenScopeForm war = new GreenScopeForm(this.FlowsheetMonitoring);
                System.Windows.Forms.DialogResult result = war.ShowDialog();
                war.Dispose();
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
