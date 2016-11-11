using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USEPA_Simulation_PlugIns
{
    /// <summary>
    /// Provides a text name for the registration of a CAPE-OPEN object.</summary>
    /// <remarks>
    /// <para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeName[Name] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeNameAttribute("MixerExamle")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeNameAttribute : System.Attribute
    {
        private String m_Name;
        /// <summary>Initializes a new instance of the CapeDescriptionAttribute class.</summary>
        /// <remarks>The value of the description is used by the registration function to set the value of the CapeDescription[Description] registration key.</remarks>
        /// <param name = "name">The CAPE-OPEN component description.</param>
        public CapeNameAttribute(String name)
        {
            m_Name = name;
        }

        /// <summary>Gets the name information.</summary>
        /// <remarks>The value of the name.</remarks>
        /// <value>The CAPE-OPEN component name.</value>
        public String Name
        {
            get
            {
                return m_Name;
            }
        }
    };
    /// <summary>Provides a text description for the registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeDescription[Description] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeDescriptionAttribute : System.Attribute
    {
        private String m_Description;

        /// <summary>Initializes a new instance of the CapeDescriptionAttribute class.</summary>
        /// <remarks>The value of the description is used by the registration function to set the value of the CapeDescription[Description] registration key.</remarks>
        /// <param name = "description">The CAPE-OPEN component description.</param>
        public CapeDescriptionAttribute(String description)
        {
            m_Description = description;
        }

        /// <summary>Gets the description information.</summary>
        /// <remarks>The value of the description.</remarks>
        /// <value>The CAPE-OPEN component description.</value>
        public String Description
        {
            get
            {
                return m_Description;
            }
        }
    };
    /// <summary>Provides the CAPE-OPEN version number for the registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeDescription[CapeVersion] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeVersionAttribute : System.Attribute
    {
        private String m_Version;
        /// <summary>Initializes a new instance of the CapeVersionAttribute class.</summary>
        /// <remarks>The value of the description is used by the registration function to set the value of the CapeDescription[CapeVersion] registration key.</remarks>
        /// <param name = "version">The version of the CAPE-OPEN interfaces that this object supports.</param>
        public CapeVersionAttribute(String version)
        {
            m_Version = version;
        }

        /// <summary>Gets the CAPE-OPEN version number.</summary>
        /// <remarks>The value of the CAPE-OPEN version number.</remarks>
        /// <value>The CAPE-OPEN component CAPE-OPEN version number.</value>
        public String Version
        {
            get
            {
                return m_Version;
            }
        }
    };
    /// <summary>Provides a vendor URL for the registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeDescription[VendorURL] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeVendorURLAttribute : System.Attribute
    {
        private String m_VendorURL;
        /// <summary>Initializes a new instance of the CapeVendorURLAttribute class.</summary>
        /// <remarks>The value of the description is used by the registration function to set the value of the CapeDescription[VendorURL] registration key.</remarks>
        /// <param name = "VendorURL">The CAPE-OPEN component Vendor URL.</param>
        public CapeVendorURLAttribute(String VendorURL)
        {
            m_VendorURL = VendorURL;
        }

        /// <summary>Gets the VendorURL information.</summary>
        /// <remarks>The value of the VendorURL.</remarks>
        /// <value>The CAPE-OPEN component VendorURL.</value>
        public String VendorURL
        {
            get
            {
                return m_VendorURL;
            }
        }
    };
    /// <summary>Provides a help URL for the registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeDescription[HelpURL] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeHelpURLAttribute : System.Attribute
    {
        private String m_HelpURL;

        /// <summary>Initializes a new instance of the CapeHelpURLAttribute class.</summary>
        /// <remarks>The value of the Help URL is used by the registration function to set the value of the CapeDescription[HelpURL] registration key.</remarks>
        /// <param name = "HelpURL">The CAPE-OPEN component Help URL.</param>
        public CapeHelpURLAttribute(String HelpURL)
        {
            m_HelpURL = HelpURL;
        }

        /// <summary>Gets the HelpURL information.</summary>
        /// <remarks>The value of the HelpURL.</remarks>
        /// <value>The CAPE-OPEN component HelpURL.</value>
        public String HelpURL
        {
            get
            {
                return m_HelpURL;
            }
        }
    };

    /// <summary>Provides text about information for the registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to set the value of the CapeDescription[About] registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeAboutAttribute : System.Attribute
    {
        private String m_About;
        /// <summary>Initializes a new instance of the CapeAboutAttribute class.</summary>
        /// <remarks>The value of the about text is used by the registration function to set the value of the CapeDescription[About] registration key.</remarks>
        /// <param name = "About">The CAPE-OPEN component about information.</param>
        public CapeAboutAttribute(String About)
        {
            m_About = About;
        }

        /// <summary>Gets the about information.</summary>
        /// <remarks>The value of the about information.</remarks>
        /// <value>The CAPE-OPEN component about information.</value>
        public String About
        {
            get
            {
                return m_About;
            }
        }
    };


    /// <summary>Provides information regarding whether the object supports Flowsheet monitoring used  
    /// during registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to add the CATID_MONITORING_OBJECT to the object's registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// [CapeOpen.CapeFlowsheetMonitoringAttribute(true)]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeFlowsheetMonitoringAttribute : System.Attribute
    {
        private bool m_Monitors;
        /// <summary>Initializes a new instance of the CapeFlowsheetMonitoringAttribute class.</summary>
        /// <remarks>This attribute is used to indicate whether the object uses the flowsheet monitoring capability of a PME.
        /// It is also used by the COM registration function to place the appropriate CATID value in the system registry
        /// for this object.</remarks>
        /// <param name = "monitors">The CAPE-OPEN component is a flowsheet monitoring object.</param>
        public CapeFlowsheetMonitoringAttribute(bool monitors)
        {
            m_Monitors = monitors;
        }

        /// <summary>Gets the about information.</summary>
        /// <remarks>This property indicates whether the object uses the flowsheet monitoring interfaces of the PME.</remarks>
        /// <value>A boolean value indicating whether the CAPE-OPEN component supports flowsheet monitoring.</value>
        public bool Monitors
        {
            get
            {
                return m_Monitors;
            }
        }
    };

    /// <summary>Provides information regarding whether the object consumes Thermodynamics 
    /// during registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to add the Consumes_Thermo_CATID to the object's registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// [CapeOpen.CapeConsumesThermoAttribute(true)]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeConsumesThermoAttribute : System.Attribute
    {
        private bool m_ConsumesThermo;

        /// <summary>Initializes a new instance of the CapeConsumesThermoAttribute class.</summary>
        /// <remarks>This attribute is used to indicate whether the object consumes thermodynamic
        /// models. It is also used by the COM registration function to place the appropriate CATID
        /// value in the system registry.</remarks>
        /// <param name = "consumes">A boolean value indicating whether the CAPE-OPEN component consumes thermodynamics.</param>
        public CapeConsumesThermoAttribute(bool consumes)
        {
            m_ConsumesThermo = consumes;
        }

        /// <summary>Gets information about whether the object consumes Thermodynamics models.</summary>
        /// <remarks>This property indicates whether the object consumes thermodynamics.</remarks>
        /// <value>The CAPE-OPEN component consumes thermodynamics.</value>
        public bool ConsumesThermo
        {
            get
            {
                return m_ConsumesThermo;
            }
        }
    };

    /// <summary>Provides information regarding whether the object supports Thermodynamics 
    /// version 1.0 during registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to add the SupportsThermodynamics10_CATID to the object's registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// [CapeOpen.CapeConsumesThermoAttribute(true)]
    /// [CapeOpen.CapeSupportsThermodynamics10Attribute(true)]
    /// public class CMixerExample : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeSupportsThermodynamics10Attribute : System.Attribute
    {
        private bool m_Supported;

        /// <summary>Initializes a new instance of the CapeSupportsThermodynamics10Attribute class.</summary>
        /// <remarks>This attribute is used to indicate whether the object supports thermodynamic
        /// version 1.0. It is also used by the COM registration function to place the appropriate CATID
        /// value in the system registry.</remarks>
        /// <param name = "supported">The CAPE-OPEN component consumes thermodynamics.</param>
        public CapeSupportsThermodynamics10Attribute(bool supported)
        {
            m_Supported = supported;
        }

        /// <summary>Gets the about information.</summary>
        /// <remarks>This property indicates whether the object consumes thermodynamics.</remarks>
        /// <value>The CAPE-OPEN component supports thermodynamics version 1.0.</value>
        public bool Supported
        {
            get
            {
                return m_Supported;
            }
        }
    };

    /// <summary>Provides information regarding whether the object supports Thermodynamics 
    /// version 1.0 during registration of a CAPE-OPEN object.</summary>
    /// <remarks><para>
    /// This attribute is used during the registration of a CAPE-OPEN object with the
    /// COM registry to add the SupportsThermodynamics10_CATID to the object's registration key. </para>
    /// </remarks>
    /// <c>
    /// [Serializable]
    /// [System.Runtime.InteropServices.ComVisible(true)]
    /// [System.Runtime.InteropServices.Guid("C79CAFD3-493B-46dc-8585-1118A0B5B4AB")]//ICapeThermoMaterialObject_IID)
    /// [System.ComponentModel.Description("")]
    /// [CapeOpen.CapeDescriptionAttribute("An example mixer unit operation.")]
    /// [CapeOpen.CapeVersionAttribute("1.0")]
    /// [CapeOpen.CapeVendorURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeHelpURLAttribute("http:\\www.epa.gov")]
    /// [CapeOpen.CapeAboutAttribute("US Environmental Protection Agency\nCincinnati, Ohio")]
    /// [CapeOpen.CapeConsumesThermoAttribute(true)]
    /// [CapeOpen.CapeSupportsThermodynamics11Attribute(true)]
    /// public class CMixerExample110 : public CUnitBase
    /// </c>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public class CapeSupportsThermodynamics11Attribute : System.Attribute
    {
        private bool m_Supported;
        /// <summary>Initializes a new instance of the CapeSupportsThermodynamics10Attribute class.</summary>
        /// <remarks>This attribute is used to indicate whether the object supports thermodynamic
        /// version 1.0. It is also used by the COM registration function to place the appropriate CATID
        /// value in the system registry.</remarks>
        /// <param name = "supported">The CAPE-OPEN component consumes thermodynamics.</param>
        public CapeSupportsThermodynamics11Attribute(bool supported)
        {
            m_Supported = supported;
        }

        /// <summary>Gets the about information.</summary>
        /// <remarks>This property indicates whether the object consumes thermodynamics.</remarks>
        /// <value>The CAPE-OPEN component supports thermodynamics version 1.0.</value>
        public bool Supported
        {
            get
            {
                return m_Supported;
            }
        }
    };

    /*	[
    odl,
    uuid(B777A1BD-0C88-11D3-822E-00C04F4F66C9),
    version(20.0),
    helpstring("IATCapeXRealParameterSpec Interface"),
    dual,
    oleautomation
    ]
    interface IATCapeXRealParameterSpec : IDispatch {
    [id(0x60040003), propget, helpstring(" Provide the Aspen Plus display units for this parameter.")]
    HRESULT DisplayUnits([out, retval] BSTR* bsUOM);
    };

    typedef [version(1.0)]
    enum {
    ErrorSeverityTerminal = 0,
    ErrorSeveritySevere = 1,
    ErrorSeverityError = 2,
    ErrorSeverityWarning = 3
    } __MIDL___MIDL_itf_AspenCapeX_0244_0001;

    [
    odl,
    uuid(B777A1B9-0C88-11D3-822E-00C04F4F66C9),
    version(1.0),
    hidden,
    dual,
    nonextensible,
    oleautomation
    ]
    interface IATCapeXDiagnostic : IDispatch {
    [id(0x60040000), helpstring("Print a message to the history device.")]
    HRESULT SendMsgToHistory([in] BSTR message);
    [id(0x60040001), helpstring("Print a message to the terminal device.")]
    HRESULT SendMsgToTerminal([in] BSTR message);
    [id(0x60040002), helpstring("Signal a simulation error.")]
    HRESULT RaiseError(
    [in] ErrorSeverity severity, 
    [in] BSTR context, 
    [in] BSTR message);
    };
    */

        /// <summary>
    /// Event thrown to indicate that the name of a component has changed.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("F79EA405-4002-4fb2-AED0-C1E48793637D")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIDispatch)]
    interface IComponentNameChangedEventArgs
    {
        /// <summary>
        /// The name of the PMC prior to the name change.</summary>
        /// <remarks>The former name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The name of the unit prior to the name change.</value>
        String OldName
        {
            get;
        }
        /// <summary>
        /// The name of the PMC after the name change.</summary>
        /// <remarks>The new name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The name of the unit after the name change.</value>
        String NewName
        {
            get;
        }
    };

    /// <summary>
    /// Event thrown to indicate that the description of a component has changed.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("34C43BD3-86B2-46d4-8639-E0FA5721EC5C")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIDispatch)]
    interface IComponentDescriptionChangedEventArgs
    {
        /// <summary>
        /// The description of the PMC prior to the name change.</summary>
        /// <remarks>The former description of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The description of the unit prior to the description change.</value>
        String OldDescription
        {
            get;
        }
        /// <summary>
        /// The name of the PMC after the name change.</summary>
        /// <remarks>The description name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The description of the unit after the description change.</value>
        String NewDescription
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the CapeIdentification.ComponentNameChanged event.
    /// </summary>
    /// <remarks>
    /// A CapeIdentification.NameChangedEventArgs event specifies the old and new name of the PMC.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("D78014E7-FB1D-43ab-B807-B219FAB97E8B")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ComponentNameChangedEventArgs : System.EventArgs//,
                                                                 //IComponentNameChangedEventArgs
    {
        private String m_oldName;
        private String m_newName;

        /// <summary>Creates an instance of the NameChangedEventArgs class with the old and new name.</summary>
        /// <remarks>You can use this constructor when raising the NameChangedEvent at run time to specify a 
        /// specific the name of the PMC having its name changed.
        /// </remarks>
        /// <param name = "oldName">The name of the PMC prior to the name change.</param>
        /// <param name = "newName">The name of the PMC after the name change.</param>
        public ComponentNameChangedEventArgs(String oldName, String newName)
            : base()
        {
            m_oldName = oldName;
            m_newName = newName;
        }

        /// <summary>
        /// The name of the PMC prior to the name change.</summary>
        /// <remarks>The former name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The name of the unit prior to the name change.</value>
        public String OldName
        {
            get
            {
                return m_oldName;
            }
        }
        /// <summary>
        /// The name of the PMC after the name change.</summary>
        /// <remarks>The new name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The name of the unit after the name change.</value>
        public String NewName
        {
            get
            {
                return m_newName;
            }
        }
    };

    /// <summary>
    /// Provides data for the CapeIdentification.ComponentDescriptionChanged event.
    /// </summary>
    /// <remarks>
    /// A CapeIdentification.DescriptionChangedEventArgs event specifies the old and new description of the PMC.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("0C51C4F1-20E8-413d-93E1-4704B888354A")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ComponentDescriptionChangedEventArgs : System.EventArgs,
        IComponentDescriptionChangedEventArgs
    {
        private String m_oldDescription;
        private String m_newDescription;

        /// <summary>Creates an instance of the DescriptionChangedEventArgs class with the old and new name.</summary>
        /// <remarks>You can use this constructor when raising the DescriptionChangedEvent at run time to specify a 
        /// specific the description of the PMC having its name changed.
        /// </remarks>
        /// <param name = "oldDescription">The description of the PMC prior to the description change.</param>
        /// <param name = "newDescription">The description of the PMC after the description change.</param>
        public ComponentDescriptionChangedEventArgs(String oldDescription, String newDescription)
            : base()
        {
            m_oldDescription = oldDescription;
            m_newDescription = newDescription;
        }

        /// <summary>
        /// The description of the PMC prior to the name change.</summary>
        /// <remarks>The former description of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The description of the unit prior to the description change.</value>
        public String OldDescription
        {
            get
            {
                return m_oldDescription;
            }
        }
        /// <summary>
        /// The name of the PMC after the name change.</summary>
        /// <remarks>The description name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The description of the unit after the description change.</value>
        public String NewDescription
        {
            get
            {
                return m_newDescription;
            }
        }
    };
    /// <summary>
    /// Provides methods to identify and describe a CAPE-OPEN component.
    /// </summary>
    /// <remarks>
    /// <para>As illustration, we remind requirements coming from the existing interface 
    /// specification and being connected with the Identification concept:</para>
    /// <para>The Unit Operations Interfaces have the following requirements:</para>
    /// <para>* If a flowsheet contains two instances of a Unit Operation of a particular 
    /// class, the COSE needs to provide the user a textual identifier to distinguish each 
    /// of the instances. For instance, when the COSE requires to report about an error 
    /// occurred in one of the Unit Operations.</para>
    /// <para>* When the COSE shows the user its GUI to connect the COSE’s streams to the 
    /// Unit Operation ports, the COSE needs to request the Unit for its list of available 
    /// ports. For the user to identify the ports, the user needs some distinctive textual 
    /// information for each of them.</para>
    /// <para>* When the COSE exposes to the user its interfaces to browse or set the 
    /// value of an internal parameter of a Unit Operation, the COSE needs to request the 
    /// Unit for its list of available parameters. No matter if this COSE’s interface is 
    /// a GUI or a programming interface, each parameter must be identified by a textual 
    /// string.</para>
    /// <para>The ICapeThermoMaterialObject (used by both Unit and Thermo interfaces):</para>
    /// <para>* If a Unit Operation has encountered an error accessing a stream 
    /// (<see cref ="ICapeThermoMaterialObject">ICapeThermoMaterialObject</see>), the 
    /// Unit might decide to report it to the user. It would be desirable the stream to 
    /// have a textual identifier for the user to be able to quickly know which stream 
    /// failed.</para>
    /// <para>thermodynamic Interfaces have the following requirements:</para>
    /// <para>* The <see cref ="ICapeThermoSystem">ICapeThermoSystem</see>
    /// and the <see cref ="ICapeThermoPropertyPackage">ICapeThermoPropertyPackage</see> 
    /// interfaces don’t require an identification interface, since both of them have been 
    /// designed as singletons (a single instance of each component class is required). 
    /// That means that there is no need to identify this instance: its class description 
    /// would be enough. However, the user might decide anyway to assign a name or a 
    /// description to the CAPE-OPEN property systems or property packages used in her/his 
    /// flowsheet. Furthermore, if these interfaces evolve, the singleton approach could 
    /// be removed. In this case, identifying each instance will be a must.</para>
    /// <para>The Solvers Interfaces have the following requirements:</para>
    /// <para>* Many objects should provide the functionality coming from the 
    /// Identification Common Interface.</para>
    /// <para>The SMST Interfaces have the following requirements:</para>
    /// <para>* The CO SMST component package depends on the Identification Interface 
    /// package. The interface ICapeSMSTFactory must provide the Identification 
    /// capabilities.</para>
    /// <para>reference document: Identification Common Interface</para>
    /// </remarks>
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIDispatch)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("5F5087A7-B27B-4b4f-902D-5F66E34A0CBE")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface ICapeIdentificationEvents
    {
        /// <summary>
        /// Gets and sets the name of the component.
        /// </summary>
        /// <remarks>
        /// <para>A particular Use Case in a system may contain several CAPE-OPEN components 
        /// of the same class. The user should be able to assign different names and 
        /// descriptions to each instance in order to refer to them unambiguously and in a 
        /// user-friendly way. Since not always the software components that are able to 
        /// set these identifications and the software components that require this information 
        /// have been developed by the same vendor, a CAPE-OPEN standard for setting and 
        /// getting this information is required.</para>
        /// <para>So, the component will not usually set its own name and description: the 
        /// user of the component will do it.</para>
        /// </remarks>
        /// <value>The unique name of the component.</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <param name = "sender">The PMC that raised the event.</param>
        /// <param name = "args">A <see cref = "ComponentNameChangedEventArgs ">ParameterDefaultValueChanged</see> that contains information about the event.</param>
        void ComponentNameChanged(
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]Object sender,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]Object args
            );

        /// <summary>
        /// Gets and sets the description of the component.
        /// </summary>
        /// <remarks>
        /// <para>A particular Use Case in a system may contain several CAPE-OPEN components 
        /// of the same class. The user should be able to assign different names and 
        /// descriptions to each instance in order to refer to them unambiguously and in a 
        /// user-friendly way. Since not always the software components that are able to 
        /// set these identifications and the software components that require this information 
        /// have been developed by the same vendor, a CAPE-OPEN standard for setting and 
        /// getting this information is required.</para>
        /// <para>So, the component will not usually set its own name and description: the 
        /// user of the component will do it.</para>
        /// </remarks>
        /// <value>The description of the component.</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <param name = "sender">The PMC that raised the event.</param>
        /// <param name = "args">A <see cref = "ComponentDescriptionChangedEventArgs ">ParameterDefaultValueChanged</see> that contains information about the event.</param>
        void ComponentDescriptionChanged(
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]Object sender,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]Object args
            );
    };

    /// <summary>
    /// Represents the method that will handle the changing the name of a component.
    /// </summary>
    /// <remarks>
    /// When you create a ComponentNameChangedHandler delegate, you identify the method that will handle the event. To associate the event with your event handler, add an 
    /// instance of the delegate to the event. The event handler is called whenever the event occurs, unless you remove the delegate. For more information about delegates, 
    /// see Events and Delegates.
    /// </remarks>
    /// <param name = "sender">The PMC that is the source .</param>
    /// <param name = "args">A <see cref = "ComponentNameChangedEventArgs">NameChangedEventArgs</see> that provides information about the name change.</param>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void ComponentNameChangedHandler(Object sender, ComponentNameChangedEventArgs args);

    /// <summary>
    /// Represents the method that will handle the changing of the description of a component.
    /// </summary>
    /// <remarks>
    /// When you create a ComponentNameChangedHandler delegate, you identify the method that will handle the event. To 
    /// associate the event with your event handler, add an instance of the delegate to the event. The event handler is 
    /// called whenever the event occurs, unless you remove the delegate. For more information about delegates, see Events 
    /// and Delegates.
    /// </remarks>
    /// <param name = "sender">The PMC that is the source of the event.</param>
    /// <param name = "args">A <see cref = "ComponentDescriptionChangedEventArgs">DescriptionChangedEventArgs</see> that 
    /// provides information about the description change.</param>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void ComponentDescriptionChangedHandler(Object sender, ComponentDescriptionChangedEventArgs args);

    /// <summary>
    /// Provides methods to identify and describe a CAPE-OPEN component.
    /// </summary>
    /// <remarks>
    /// <para>Allows the user to assign different names and descriptions to each 
    /// instance of a PMC in order to refer to them unambiguously and in a 
    /// user-friendly way. Since not always the software components that are able to 
    /// set these identifications and the software components that require this 
    /// information have been developed by the same vendor, a CAPE-OPEN standard for 
    /// setting and getting this information is required.</para>
    /// <para>reference document: Identification Common Interface</para>
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComSourceInterfaces(typeof(ICapeIdentificationEvents), typeof(System.ComponentModel.INotifyPropertyChanged))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("BF54DF05-924C-49a5-8EBB-733E37C38085")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentification Interface")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    abstract public class CapeIdentification : //System.ComponentModel.Component,
        CAPEOPEN.ICapeIdentification,
        IDisposable,
        ICloneable,
        System.ComponentModel.INotifyPropertyChanged

    {
        /// <summary>
        /// The name of the component.
        /// </summary>
        private String m_ComponentName;
        /// <summary>
        /// The description of the component.
        /// </summary>
        private String m_ComponentDescription;
        // Track whether Dispose has been called.
        private bool _disposed;

        /// <summary>
        /// Creates an instance of the CapeIdentification class with default values for the name and 
        /// description of the PMC.
        /// </summary>
        /// <remarks>
        /// This constructor uses the <see cref="System.Type"/> of the PMC object being constructed as default 
        /// values for the ComponentName and ComponentDescription properties. If the PMC object has a 
        /// <see cref="CapeNameAttribute"/>, then the <see cref="CapeNameAttribute.Name"/> property is used for the name.
        /// Likewise, if the object has a <see cref="CapeDescriptionAttribute"/>, then the 
        /// <see cref="CapeDescriptionAttribute.Description"/> property is used for the description.
        /// </remarks>
        public CapeIdentification()
        {
            _disposed = false;
            m_ComponentName = this.GetType().FullName;
            m_ComponentDescription = this.GetType().FullName;
            Object[] attributes = this.GetType().GetCustomAttributes(false);
            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i] is CapeNameAttribute) m_ComponentName = ((CapeNameAttribute)attributes[i]).Name;
                if (attributes[i] is CapeDescriptionAttribute) m_ComponentDescription = ((CapeDescriptionAttribute)attributes[i]).Description;
            }
        }

        /// <summary>
        /// Creates an instance of the CapeIdentification class with the name and a default description of the PMC.
        /// </summary>
        /// <remarks>
        /// This constructor uses the provided name for the ComponentName of the PMC object being constructed. A 
        /// default value for the ComponentDescription properties is then assigned. If the PMC object has a 
        /// <see cref="CapeDescriptionAttribute"/>, then the <see cref="CapeDescriptionAttribute.Description"/> 
        /// property is used for the description.
        /// </remarks>
        /// <param name = "name">The name of the PMC.</param>
        public CapeIdentification(String name)
        {
            _disposed = false;
            m_ComponentName = name;
            m_ComponentDescription = this.GetType().FullName;
            Object[] attributes = this.GetType().GetCustomAttributes(false);
            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i] is CapeDescriptionAttribute) m_ComponentDescription = ((CapeDescriptionAttribute)attributes[i]).Description;
            }
        }

        /// <summary
        /// >Creates an instance of the CapeIdentification class with the name and description of the PMC.
        /// </summary>
        /// <remarks>
        /// You can use this constructor to specify a specific name and description of the PMC.
        /// </remarks>
        /// <param name = "name">The name of the PMC.</param>
        /// <param name = "description">The description of the PMC.</param>
        public CapeIdentification(String name, String description)
        {
            _disposed = false;
            m_ComponentName = name;
            m_ComponentDescription = description;
        }


        /// <summary>
        /// Copy constructor of the CapeIdentification class.
        /// </summary>
        /// <remarks>
        /// Creates an instance of the CapeIdentification class with ComponentName equal to the original PMC's 
        /// ComponentName + (Copy). The copy has the same CapeDescription as the original.
        /// </remarks>
        /// <param name = "objectToBeCopied">The object being copied.</param>
        protected CapeIdentification(CapeIdentification objectToBeCopied)
        {
            _disposed = false;
            m_ComponentName = objectToBeCopied.ComponentName + "(Copy)";
            m_ComponentDescription = objectToBeCopied.ComponentDescription;
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
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
        public abstract object Clone();

        // Implement IDisposable.
        // Do not make this method virtual.
        // A derived class should not be able to override this method.
        /// <summary>
        /// Releases all resources used by the CapeIdentification object.
        /// </summary>
        /// <remarks>Call Dispose when you are finished using the CapeIdentification object. The Dispose method 
        /// leaves the CapeIdentification object in an unusable state. After calling Dispose, you must release 
        /// all references to the Component so the garbage collector can reclaim the memory that the CapeIdentification 
        /// object was occupying. For more information, see <see href="http://msdn.microsoft.com/en-us/library/498928w2.aspx">
        /// Cleaning Up Unmanaged Resources and Implementing a Dispose Method.</see></remarks> 
        public void Dispose()
        {
            this.Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

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
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!_disposed)
            {
                //If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    // Dispose managed resources.
                    //component.Dispose();
                }
                // Note disposing has been done.
                _disposed = true;
            }
        }

        /// <summary>
        /// Notifies the collection that the value of a property of the parameter has been changed.
        /// </summary>
        /// <remarks>The PropertyChanged event can indicate all properties on the object have changed by using either 
        /// null or String.Empty as the property name in the PropertyChangedEventArgs.
        /// </remarks>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        /// <summary>
        /// Notifies the collection that the value of a property of the parameter has been changed.
        /// </summary>
        /// <remarks>The PropertyChanged event can indicate all properties on the object have changed by using either 
        /// null or String.Empty as the property name in the PropertyChangedEventArgs.
        /// </remarks>
        /// <param name="propertyName">The name of the property that was changed.</param>
        protected void NotifyPropertyChanged(/* .Net 4.5 [System.Runtime.CompilerServices.CallerMemberName]*/ String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Occurs when the user changes of the name of a component.
        /// </summary>
        /// <remarks>The event to be handles when the name of the PMC is changed.</remarks> 
        public event ComponentNameChangedHandler ComponentNameChanged;

        /// <summary>
        /// Occurs when the user changes of the description of a component.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnComponentNameChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnComponentNameChanged</c> in a derived class, be sure to call the base class's <c>OnComponentNameChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "ComponentNameChangedEventArgs">NameChangedEventArgs</see> that contains information about the event.</param>
        protected void OnComponentNameChanged(ComponentNameChangedEventArgs args)
        {
            if (ComponentNameChanged != null)
            {
                ComponentNameChanged(this, args);
            }
        }

        /// <summary>
        /// Occurs when the user changes of the description of a component.
        /// </summary>
        /// <remarks>The event to be handles when the description of the PMC is changed.</remarks> 
        public event ComponentDescriptionChangedHandler ComponentDescriptionChanged;

        /// <summary>
        /// Occurs when the user changes of the description of a component.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnComponentDescriptionChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnComponentDescriptionChanged</c> in a derived class, be sure to call the base class's <c>OnComponentDescriptionChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "ComponentDescriptionChangedEventArgs">DescriptionChangedEventArgs</see> that contains information about the event.</param>
        protected void OnComponentDescriptionChanged(ComponentDescriptionChangedEventArgs args)
        {
            if (ComponentDescriptionChanged != null)
            {
                ComponentDescriptionChanged(this, args);
            }
        }

        /// <summary>
        /// Gets and sets the name of the component.
        /// </summary>
        /// <remarks>
        /// <para>A particular Use Case in a system may contain several CAPE-OPEN components 
        /// of the same class. The user should be able to assign different names and 
        /// descriptions to each instance in order to refer to them unambiguously and in a 
        /// user-friendly way. Since not always the software components that are able to 
        /// set these identifications and the software components that require this information 
        /// have been developed by the same vendor, a CAPE-OPEN standard for setting and 
        /// getting this information is required.</para>
        /// <para>So, the component will not usually set its own name and description: the 
        /// user of the component will do it.</para>
        /// </remarks>
        /// <value>The unique name of the component.</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        [System.ComponentModel.DescriptionAttribute("Unit Operation Parameter Collection. Click on the (...) button to edit collection.")]
        [System.ComponentModel.CategoryAttribute("Identification")]
        public virtual String ComponentName
        {
            get
            {
                return m_ComponentName;
            }

            set
            {
                ComponentNameChangedEventArgs args = new ComponentNameChangedEventArgs(m_ComponentName, value);
                m_ComponentName = value;
                NotifyPropertyChanged("ComponentName");
                OnComponentNameChanged(args);
            }
        }

        /// <summary>
        ///  Gets and sets the description of the component.
        /// </summary>
        /// <remarks>
        /// <para>A particular Use Case in a system may contain several CAPE-OPEN components 
        /// of the same class. The user should be able to assign different names and 
        /// descriptions to each instance in order to refer to them unambiguously and in a 
        /// user-friendly way. Since not always the software components that are able to 
        /// set these identifications and the software components that require this information 
        /// have been developed by the same vendor, a CAPE-OPEN standard for setting and 
        /// getting this information is required.</para>
        /// <para>So, the component will not usually set its own name and description: the 
        /// user of the component will do it.</para>
        /// </remarks>
        /// <value>The description of the component.</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        [System.ComponentModel.DescriptionAttribute("Unit Operation Parameter Collection. Click on the (...) button to edit collection.")]
        [System.ComponentModel.CategoryAttribute("Identification")]
        public virtual String ComponentDescription
        {
            get
            {
                return m_ComponentDescription;
            }
            set
            {
                ComponentDescriptionChangedEventArgs args = new ComponentDescriptionChangedEventArgs(m_ComponentDescription, value);
                m_ComponentDescription = value;
                NotifyPropertyChanged("ComponentDescription");
                OnComponentDescriptionChanged(args);
            }
        }
    };

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    [System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIDispatch)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("3C32AD8E-490D-4822-8A8E-073F5EDFF3F5")]
    [System.ComponentModel.DescriptionAttribute("CapeParameterEvents Interface")]
    interface IParameterEvents
    {
        /// <summary>
        /// Occurs when the user changes of the value of a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnComponentNameChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterValueChanged</c> in a derived class, be sure to call the base class's <c>OnParameterValueChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "sender">The <see cref = "RealParameter">RealParameter</see> that raised the event.</param>
        /// <param name = "args">A <see cref = "ParameterValueChanged">ParameterValueChanged</see> that contains information about the event.</param>
        void ParameterValueChanged(object sender, object args);

        /// <summary>
        /// Occurs when the user changes of the mode of a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterModeChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterModeChanged</c> in a derived class, be sure to call the base class's <c>OnParameterModeChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "sender">The <see cref = "RealParameter">RealParameter</see> that raised the event.</param>
        /// <param name = "args">A <see cref = "ParameterModeChangedEventArgs">ParameterModeChangedEventArgs</see> that contains information about the event.</param>
        void ParameterModeChanged(object sender, object args);

        /// <summary>
        /// Occurs when a parameter is validated.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterValidated</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterValidated</c> in a derived class, be sure to call the base class's <c>OnParameterValidated</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "sender">The <see cref = "RealParameter">RealParameter</see> that raised the event.</param>
        /// <param name = "args">A <see cref = "ParameterValidatedEventArgs">ParameterValidatedEventArgs</see> that contains information about the event.</param>
        void ParameterValidated(object sender, object args);

        /// <summary>
        /// Occurs when the user resets a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterReset</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterReset</c> in a derived class, be sure to call the base class's <c>OnParameterReset</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "sender">The <see cref = "RealParameter">RealParameter</see> that raised the event.</param>
        /// <param name = "args">A <see cref = "ParameterResetEventArgs">ParameterResetEventArgs</see> that contains information about the event.</param>
        void ParameterReset(object sender, object args);
    }


    class ParameterTypeConverter : System.ComponentModel.ExpandableObjectConverter
    {
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType)
        {
            if (typeof(CAPEOPEN.ICapeParameter).IsAssignableFrom(destinationType))
                return true;
            if (typeof(CAPEOPEN.ICapeIdentification).IsAssignableFrom(destinationType))
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override Object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object parameter, System.Type destinationType)
        {
            if (typeof(System.String).IsAssignableFrom(destinationType) && typeof(ArrayParameterWrapper).IsAssignableFrom(parameter.GetType()))
            {
                return "";//((CapeOpen.ArrayParameterWrapper)parameter).;
            }
            if (typeof(System.String).IsAssignableFrom(destinationType) && typeof(CAPEOPEN.ICapeParameter).IsAssignableFrom(parameter.GetType()))
            {
                return ((CAPEOPEN.ICapeParameter)parameter).value.ToString();
            }
            if (typeof(String).IsAssignableFrom(destinationType) && typeof(CAPEOPEN.ICapeIdentification).IsAssignableFrom(parameter.GetType()))
            {
                return ((CAPEOPEN.ICapeIdentification)parameter).ComponentName;
            }
            return base.ConvertTo(context, culture, parameter, destinationType);
        }
    };

    /// <summary>
    /// Aspen(TM) interface for providing dimension for a real-valued parameter.
    ///</summary>
    /// <remarks>
    /// <para>
    /// Aspen Plus(TM) does not use the <see cref = "CapeOpen.ICapeParameterSpec.Dimensionality">ICapeParameterSpec.Dimensionality</see> method. Instead a parameter
    /// can implement the IATCapeXRealParameterSpec interface which can be used to define the
    /// display unit for a parameter value. 
    /// </para>
    /// </remarks>
    [System.Runtime.InteropServices.ComImport()]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.Guid("B777A1BD-0C88-11D3-822E-00C04F4F66C9")]
    [System.ComponentModel.DescriptionAttribute("IATCapeXRealParameterSpec Interface")]
    interface IATCapeXRealParameterSpec
    {
        /// <summary>
        /// Gets the display unit for the parameter. Used by AspenPlus(TM).
        /// </summary>
        /// <remarks>
        /// <para>DisplayUnits defines the unit of measurement symbol for a parameter.</para>
        /// <para>Note: The symbol must be one of the uppercase strings recognized by Aspen
        /// Plus to ensure that it can perform unit of measurement conversions on the 
        /// parameter value. The system converts the parameter's value from SI units for
        /// display in the data browser and converts updated values back into SI.
        /// </para>
        /// </remarks>
        /// <value>
        /// Defines the display unit for the parameter.
        /// </value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        [System.Runtime.InteropServices.DispIdAttribute(0x60040003), System.ComponentModel.DescriptionAttribute(" Provide the Aspen Plus display units for this parameter.")]
        String DisplayUnits
        {
            get;
        }
    };


    /// <summary>
    /// Represents the method that will handle the changing of the value of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterValueChangedHandler(Object sender, ParameterValueChangedEventArgs args);

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The IParameterValueChangedEventArgs interface specifies the old and new value of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("41E1A3C4-F23C-4B39-BC54-39851A1D09C9")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface IParameterValueChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The value of the parameter prior to the change.</summary>
        /// <remarks>The former value of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The value of the parameter prior to the change.</value>
        Object OldValue
        {
            get;
        }
        /// <summary>
        /// The value of the parameter after the change.</summary>
        /// <remarks>The new value of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The value of the parameter after the change.</value>
        Object NewValue
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The ParameterValueChangedEventArgs event specifies the old and new value of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("C3592B59-92E8-4A24-A2EB-E23C38F88E7F")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterValueChangedEventArgs : System.EventArgs,
        IParameterValueChangedEventArgs
    {
        private String m_paramName;
        private Object m_oldValue;
        private Object m_newValue;

        /// <summary>Creates an instance of the ParameterValueChangedEventArgs class with the old and parameter value.</summary>
        /// <remarks>You can use this constructor when raising the ParameterValueChangedEvent at run time to specify a 
        /// specific the parameter having its value changed.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "oldValue">The name of the PMC prior to the name change.</param>
        /// <param name = "newValue">The name of the PMC after the name change.</param>
        public ParameterValueChangedEventArgs(String paramName, Object oldValue, Object newValue)
            : base()
        {
            m_paramName = paramName;
            m_oldValue = oldValue;
            m_newValue = newValue;
        }

        /// <summary>
        /// The name of the parameter being changed.</summary>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The value of the parameter prior to the name change.</summary>
        /// <remarks>The former value of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The value of the parameter prior to the change.</value>
        public Object OldValue
        {
            get
            {
                return m_oldValue;
            }
        }
        /// <summary>
        /// The value of the parameter after the change.</summary>
        /// <remarks>The new name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The value of the parameter after the change.</value>
        public Object NewValue
        {
            get
            {
                return m_newValue;
            }
        }
    };


    /// <summary>
    /// Represents the method that will handle the changing of the default value of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterDefaultValueChangedHandler(Object sender, ParameterDefaultValueChangedEventArgs args);

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The IParameterDefaultValueChangedEventArgs interface specifies the old and new default value of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("E5D9CE6A-9B10-4A81-9E06-1B6C6C5257F3")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface IParameterDefaultValueChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The default value of the parameter prior to the change.</summary>
        /// <remarks>The default value of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The default value of the parameter prior to the change.</value>
        Object OldDefaultValue
        {
            get;
        }
        /// <summary>
        /// The default value of the parameter  after the name change.</summary>
        /// <remarks>The new default value of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The default value of the parameter after the change.</value>
        Object NewDefaultValue
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The ParameterDefaultValueChangedEventArgs event specifies the old and new default value of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("355A5BDD-F6B5-4EEE-97C7-F1533DD28889")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterDefaultValueChangedEventArgs : System.EventArgs,
        IParameterDefaultValueChangedEventArgs
    {
        private String m_paramName;
        private Object m_oldDefaultValue;
        private Object m_newDefaultValue;

        /// <summary>Creates an instance of the ParameterDefaultValueChangedEventArgs class with the old and new default values.</summary>
        /// <remarks>You can use this constructor when raising the ParameterDefaultValueChangedEventArgs at run time to specify  
        /// that the default value of the parameter has changed.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "oldDefaultValue">The default value of the parameter prior to the change.</param>
        /// <param name = "newDefaultValue">The default value of the parameter after the change.</param>
        public ParameterDefaultValueChangedEventArgs(String paramName, Object oldDefaultValue, Object newDefaultValue)
            : base()
        {
            m_paramName = paramName;
            m_oldDefaultValue = oldDefaultValue;
            m_newDefaultValue = newDefaultValue;
        }

        /// <summary>
        /// The name of the parameter being changed.</summary>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The name of the PMC prior to the name change.</summary>
        /// <remarks>The former name of the unit can be used to update GUI information about the PMC.</remarks>
        /// <value>The default of the parameter prior to the change.</value>
        public Object OldDefaultValue
        {
            get
            {
                return m_oldDefaultValue;
            }
        }
        /// <summary>
        /// The default value of the parameter after the name change.</summary>
        /// <remarks>The new default value for the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The default value of the parameter after the change.</value>
        public Object NewDefaultValue
        {
            get
            {
                return m_newDefaultValue;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the changing of the lower bound of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterLowerBoundChangedHandler(Object sender, ParameterLowerBoundChangedEventArgs args);

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The IParameterLowerBoundChangedEventArgs interface specifies the old and new lower bound of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("FBCE7FC9-0F58-492B-88F9-8A23A23F93B1")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface IParameterLowerBoundChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The lower bound of the parameter prior to the change.</summary>
        /// <remarks>The former lower bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The lower bound of the parameter prior to the change.</value>
        Object OldLowerBound
        {
            get;
        }
        /// <summary>
        /// The lower bound of the parameter after to the change.</summary>
        /// <remarks>The former lower bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The lower bound of the parameter after to the change.</value>
        Object NewLowerBound
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the value changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The ParameterLowerBoundChangedEventArgs event specifies the old and new lower bound of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("A982AD29-10B5-4C86-AF74-3914DD902384")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterLowerBoundChangedEventArgs : System.EventArgs,
        IParameterLowerBoundChangedEventArgs
    {
        private String m_paramName;
        private Object m_oldLowerBound;
        private Object m_newLowerBound;

        /// <summary>Creates an instance of the ParameterLowerBoundChangedEventArgs class with the old and new lower bound for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterLowerBoundChangedEvent at run time to specify that 
        /// the lower bound of the parameter has changed.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "oldLowerBound">The name of the PMC prior to the name change.</param>
        /// <param name = "newLowerBound">The name of the PMC after the name change.</param>
        public ParameterLowerBoundChangedEventArgs(String paramName, Object oldLowerBound, Object newLowerBound)
            : base()
        {
            m_paramName = paramName;
            m_oldLowerBound = oldLowerBound;
            m_newLowerBound = newLowerBound;
        }

        /// <summary>
        /// The name of the parameter being changed.</summary>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The lower bound of the parameter prior to the change.</summary>
        /// <remarks>The former lower bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The lower bound of the parameter prior to the change.</value>
        public Object OldLowerBound
        {
            get
            {
                return m_oldLowerBound;
            }
        }
        /// <summary>
        /// The lower bound of the parameter after the change.</summary>
        /// <remarks>The new lower bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The lower bound of the parameter after the change.</value>
        public Object NewLowerBound
        {
            get
            {
                return m_newLowerBound;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the changing of the upper bound of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterUpperBoundChangedHandler(Object sender, ParameterUpperBoundChangedEventArgs args);

    /// <summary>
    /// Represents the method that will handle the changing of the upper bound of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    delegate void ParameterUpperBoundChangedHandlerCOM(Object sender, object args);

    /// <summary>
    /// Provides data for the upper bound changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The IParameterUpperBoundChangedEventArgs interface specifies the old and new lower bound of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("A2D0FAAB-F30E-48F5-82F1-4877F61950E9")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface IParameterUpperBoundChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The upper bound of the parameter prior to the change.</summary>
        /// <remarks>The former upper bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The upper bound of the parameter prior to the change.</value>
        Object OldUpperBound
        {
            get;
        }
        /// <summary>
        /// The upper bound of the parameter after to the change.</summary>
        /// <remarks>The former upper bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The upper bound of the parameter after to the change.</value>
        Object NewUpperBound
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the upper bound changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The ParameterUpperBoundChangedEventArgs event specifies the old and new lower bound of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("92BF83FE-0855-4382-A15E-744890B5BBF2")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterUpperBoundChangedEventArgs : System.EventArgs,
        IParameterUpperBoundChangedEventArgs
    {
        private String m_paramName;
        private Object m_oldUpperBound;
        private Object m_newUpperBound;

        /// <summary>Creates an instance of the ParameterUpperBoundChangedEventArgs class with the old and new upper bound for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterUpperBoundChangedEvent at run time to specify 
        /// that the upper bound of the parameter has changed.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "oldUpperBound">The upper bound of the parameter prior to the change.</param>
        /// <param name = "newUpperBound">The upper bound of the parameter after the change.</param>
        public ParameterUpperBoundChangedEventArgs(String paramName, Object oldUpperBound, Object newUpperBound)
            : base()
        {
            m_paramName = paramName;
            m_oldUpperBound = oldUpperBound;
            m_newUpperBound = newUpperBound;
        }

        /// <summary>
        /// The name of the parameter being changed.</summary>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The upper bound of the parameter prior to the change.</summary>
        /// <remarks>The former upper bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The upper bound of the parameter prior to the change.</value>
        public Object OldUpperBound
        {
            get
            {
                return m_oldUpperBound;
            }
        }
        /// <summary>
        /// The upper bound of the parameter after the change.</summary>
        /// <remarks>The new upper bound of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The upper bound of the parameter after the change.</value>
        public Object NewUpperBound
        {
            get
            {
                return m_newUpperBound;
            }
        }
    };


    /// <summary>
    /// Represents the method that will handle the changing of the mode of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterModeChangedHandler(Object sender, ParameterModeChangedEventArgs args);


    /// <summary>
    /// Provides data for the mode changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The IParameterModeChangedEventArgs interface specifies the old and new mode of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("5405E831-4B5F-4A57-A410-8E91BBF9FFD3")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentificationEvents Interface")]
    interface IParameterModeChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The mode of the parameter prior to the change.</summary>
        /// <remarks>The former mode of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The mode of the parameter prior to the change.</value>
        Object OldMode
        {
            get;
        }
        /// <summary>
        /// The mode of the parameter after to the change.</summary>
        /// <remarks>The former mode of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The mode of the parameter after to the change.</value>
        Object NewMode
        {
            get;
        }
    };

    /// <summary>
    /// Provides data for the mode changed event associated with the parameters.
    /// </summary>
    /// <remarks>
    /// The ParameterModeChangedEventArgs event specifies the old and new mode of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("3C953F15-A1F3-47A9-829A-9F7590CEB5E9")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterModeChangedEventArgs : System.EventArgs,
        IParameterModeChangedEventArgs
    {
        private String m_paramName;
        private Object m_oldMode;
        private Object m_newMode;

        /// <summary>Creates an instance of the ParameterModeChangedEventArgs class with the old and new upper bound for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterModeChangedEvent at run time to specify 
        /// that the mode of the parameter has changed.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "oldMode">The mode of the parameter prior to the change.</param>
        /// <param name = "newMode">The mode of the parameter after the change.</param>
        public ParameterModeChangedEventArgs(String paramName, Object oldMode, Object newMode)
            : base()
        {
            m_paramName = paramName;
            m_oldMode = oldMode;
            m_newMode = newMode;
        }

        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>The name of the parameter being updated can be used to update GUI information about the PMC.</remarks>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The mode of the parameter prior to the change.</summary>
        /// <remarks>The former mode of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The mode of the parameter prior to the change.</value>
        public Object OldMode
        {
            get
            {
                return m_oldMode;
            }
        }
        /// <summary>
        /// The mode of the parameter after the change.</summary>
        /// <remarks>The new mode of the parameter can be used to update GUI information about the PMC.</remarks>
        /// <value>The mode of the parameter after the change.</value>
        public Object NewMode
        {
            get
            {
                return m_newMode;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the validation of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterValidatedHandler(Object sender, ParameterValidatedEventArgs args);

    /// <summary>
    /// The parameter was validated.
    /// </summary>
    /// <remarks>
    /// Provides information about the validation of the parameter.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("EFD819A4-E4EC-462E-90E6-5D994CA44F8E")]
    [System.ComponentModel.DescriptionAttribute("ParameterValidatedEvent Interface")]
    interface IParameterValidatedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        String ParameterName
        {
            get;
        }
        /// <summary>
        /// The message resulting from the parameter validation.</summary>
        /// <remarks>The message provides information about the results of the validation process.</remarks>
        /// <value>information regrading the validation process.</value>
        String Message
        {
            get;
        }
        /// <summary>
        /// The validation status of the parameter prior to the validation.</summary>
        /// <remarks>Informs the user of the results of the validation process.</remarks>
        /// <value>The validation status of the parameter prior to the validation.</value>
        CAPEOPEN.CapeValidationStatus OldStatus
        {
            get;
        }
        /// <summary>
        /// The validation status of the parameter after the validation.</summary>
        /// <remarks>Informs the user of the results of the validation process.</remarks>
        /// <value>The validation status of the parameter after the validation.</value>
        CAPEOPEN.CapeValidationStatus NewStatus
        {
            get;
        }
    };

    /// <summary>
    /// The parameter was validated.
    /// </summary>
    /// <remarks>
    /// Provides information about the validation of the parameter.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("5727414A-838D-49F8-AFEF-1CC8C578D756")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterValidatedEventArgs : System.EventArgs,
        IParameterValidatedEventArgs
    {
        private String m_paramName;
        private String m_message;
        private CAPEOPEN.CapeValidationStatus m_oldStatus;
        private CAPEOPEN.CapeValidationStatus m_newStatus;

        /// <summary>Creates an instance of the ParameterValidatedEventArgs class for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterValidatedEventArgs at run time to  
        /// the message about the parameter validation.
        /// </remarks>
        /// <param name = "paramName">The name of the parameter being changed.</param>
        /// <param name = "message">The message indicating the results of the parameter validation.</param>
        /// <param name = "oldStatus">The status of the parameter prior to validation.</param>
        /// <param name = "newStatus">The status of the parameter after the validation.</param>
        public ParameterValidatedEventArgs(String paramName, String message, CAPEOPEN.CapeValidationStatus oldStatus, CAPEOPEN.CapeValidationStatus newStatus)
            : base()
        {
            m_paramName = paramName;
            m_message = message;
            m_oldStatus = oldStatus;
            m_newStatus = newStatus;
        }

        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
        /// <summary>
        /// The message resulting from the parameter validation.</summary>
        /// <remarks>The message provides information about the results of the validation process.</remarks>
        /// <value>information regrading the validation process.</value>
        public String Message
        {
            get
            {
                return m_message;
            }
        }
        /// <summary>
        /// The validation status of the parameter prior to the validation.</summary>
        /// <remarks>Informs the user of the results of the validation process.</remarks>
        /// <value>The validation status of the parameter prior to the validation.</value>
        public CAPEOPEN.CapeValidationStatus OldStatus
        {
            get
            {
                return m_oldStatus;
            }
        }
        /// <summary>
        /// The validation status of the parameter after the validation.</summary>
        /// <remarks>Informs the user of the results of the validation process.</remarks>
        /// <value>The validation status of the parameter after the validation.</value>
        public CAPEOPEN.CapeValidationStatus NewStatus
        {
            get
            {
                return m_newStatus;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the resetting of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterResetHandler(Object sender, ParameterResetEventArgs args);


    /// <summary>
    /// The parameter was reset.
    /// </summary>
    /// <remarks>
    /// The parameter was reset.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("12067518-B797-4895-9B26-EA71C60A8803")]
    [System.ComponentModel.DescriptionAttribute("ParameterResetEventArgs Interface")]
    interface IParameterResetEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.</summary>
        String ParameterName
        {
            get;
        }
    };

    /// <summary>
    /// The parameter was reset.
    /// </summary>
    /// <remarks>
    /// The parameter was reset.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("01BF391B-415E-4F5E-905D-395A707DC125")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterResetEventArgs : System.EventArgs,
        IParameterResetEventArgs
    {
        private String m_paramName;
        /// <summary>Creates an instance of the ParameterResetEventArgs class for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterResetEventArgs at run time to  
        /// inform the system that the parameter was reset.
        /// </remarks>
        public ParameterResetEventArgs(String paramName)
            : base()
        {
            m_paramName = paramName;
        }
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being reset.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the changing of the option list of a parameter.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterOptionListChangedHandler(Object sender, ParameterOptionListChangedEventArgs args);

    /// <summary>
    /// The parameter was reset.
    /// </summary>
    /// <remarks>
    /// The parameter was reset.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("78E06E7B-00AB-4295-9915-546DC1CD64A6")]
    [System.ComponentModel.DescriptionAttribute("ParameterOptionListChangedEventArgs Interface")]
    interface IParameterOptionListChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        String ParameterName
        {
            get;
        }
    };
    ///// <summary>
    ///// The parameter was reset.
    ///// </summary>
    ///// <remarks>
    ///// The parameter was reset.
    ///// </remarks>
    //[System.Runtime.InteropServices.ComVisibleAttribute(true)]
    //[System.Runtime.InteropServices.GuidAttribute("7B4DE7D2-1E39-4239-B8C5-4F876DDB15A4")]
    //[System.ComponentModel.DescriptionAttribute("ParameterOptionListChangedEventArgs Interface")]
    //public interface IParameterOptionsListChangedEventArgs
    //{
    //    /// <summary>
    //    /// The name of the parameter being changed.</summary>
    //    String ParameterName
    //    {
    //        get;
    //    }
    //};

    /// <summary>
    /// The parameter option list was changed.
    /// </summary>
    /// <remarks>
    /// The parameter option list was changed.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("2AEC279F-EBEC-4806-AA00-CC215432DB82")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterOptionListChangedEventArgs : System.EventArgs,
        IParameterOptionListChangedEventArgs
    {
        private String m_paramName;
        /// <summary>Creates an instance of the ParameterOptionListChangedEventArgs class for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterOptionListChangedEventArgs at run time to  
        /// inform the system that the parameter's option list was changed.
        /// </remarks>
        public ParameterOptionListChangedEventArgs(String paramName)
            : base()
        {
            m_paramName = paramName;
        }
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }
    };

    /// <summary>
    /// The restriction to the options list of a parameter was changed.
    /// </summary>
    /// <remarks>
    /// The restriction to the options list of a parameter was changed.
    /// </remarks>
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("7F357261-095A-4FD4-99C1-ACDAEDA36141")]
    [System.ComponentModel.DescriptionAttribute("ParameterOptionListChangedEventArgs Interface")]
    interface IParameterRestrictedToListChangedEventArgs
    {
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        String ParameterName
        {
            get;
        }
    };

    /// <summary>
    /// The parameter restriction to the option list was changed.
    /// </summary>
    /// <remarks>
    /// The parameter restriction to the option list was changed.
    /// </remarks>
    [Serializable]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("82E0E6C2-3103-4B5A-A5BC-EBAB971B069A")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class ParameterRestrictedToListChangedEventArgs : System.EventArgs,
        IParameterRestrictedToListChangedEventArgs
    {
        private String m_paramName;
        private bool m_wasRestricted;
        private bool m_isRestricted;
        /// <summary>Creates an instance of the ParameterRestrictedToListChangedEventArgs class for the parameter.</summary>
        /// <remarks>You can use this constructor when raising the ParameterRestrictedToListChangedEventArgs at run time to  
        /// inform the system that the parameter's option list was changed.
        /// </remarks>
        public ParameterRestrictedToListChangedEventArgs(String paramName, bool wasRestricted, bool isRestricted)
            : base()
        {
            m_paramName = paramName;
            m_isRestricted = isRestricted;
            m_wasRestricted = wasRestricted;
        }
        /// <summary>
        /// The name of the parameter being changed.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>The name of the parameter being changed.</value>
        public String ParameterName
        {
            get
            {
                return m_paramName;
            }
        }

        /// <summary>
        /// States whether the value of the parameter is restricted to the values in the options list.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>Is the parameter value restricted to the list?.</value>
        public bool IsRestricted
        {
            get
            {
                return m_isRestricted;
            }
        }
        /// <summary>
        /// States whether the value of the parameter was restricted to the values in the options list prior to the 
        /// change to the restricted to list property.
        /// </summary>
        /// <remarks>
        /// The name of the parameter being updated can be used to update GUI information about the PMC.
        /// </remarks>
        /// <value>Is the parameter value restricted to the list?.</value>
        public bool WasRestricted
        {
            get
            {
                return m_wasRestricted;
            }
        }
    };

    /// <summary>
    /// Represents the method that will handle the changing of whether a parameter's value is restricted to those in the option list.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterRestrictedToListChangedHandler(Object sender, ParameterRestrictedToListChangedEventArgs args);

    /// <summary>
    /// Represents the method that will handle the changing of the Kinetic Reaction Chemistry of a PMC.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void KineticReactionsChangedHandler(Object sender, System.EventArgs args);


    /// <summary>
    /// Represents the method that will handle the changing of the Equilibrium Reaction Chemistry of a PMC.
    /// </summary>
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void EquilibriumReactionsChangedHandler(Object sender, System.EventArgs args);

    /// <summary>
    /// Base Class defining the actual Parameter quantity.
    /// </summary>
    [Serializable]
    [System.Runtime.InteropServices.ComSourceInterfaces(typeof(IParameterEvents))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("F027B4D1-A215-4107-AA75-34E929DD00A5")]
    [System.ComponentModel.DescriptionAttribute("CapeIdentification Interface")]
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.ComponentModel.TypeConverter(typeof(ParameterTypeConverter))]
    abstract public class CapeParameter : CapeIdentification,
        CAPEOPEN.ICapeParameter,
        CAPEOPEN.ICapeParameterSpec
        //CAPEOPEN.ICapeParameterSpecCOM
    {

        CAPEOPEN.CapeParamMode m_mode = CAPEOPEN.CapeParamMode.CAPE_INPUT_OUTPUT;

        /// <summary>
        /// The flag to indicate parameter validation's status.
        /// </summary>
        /// <remarks>
        /// <para>The flag to indicate parameter validation status. It has three 
        /// possible values:</para>
        /// <para>   (i)   notValidated(CAPE_NOT_VALIDATED): The PMC's <c>Validate()</c>
        /// method has not been called after the last time that its value had been 
        /// changed.</para>
        /// <para>   (ii)  invalid(CAPE_INVALID): The last time that the PMC's 
        /// <c>Validate()</c> method was called it returned false.</para>
        /// <para>   (iii) valid(CAPE_VALID): the last time that the PMC's
        /// Validate() method was called it returned true.</para>
        /// </remarks>
        protected CAPEOPEN.CapeValidationStatus m_ValStatus = CAPEOPEN.CapeValidationStatus.CAPE_NOT_VALIDATED;

        /// <summary>
        /// Creates a new instance of the abstract parameter base class. 
        /// </summary>
        /// <remarks>
        /// The mode is set to CapeParamMode.CAPE_INPUT_OUTPUT. 
        /// </remarks>
        /// <param name = "name">Sets as the ComponentName of the parameter's ICapeIdentification interface.</param>
        /// <param name = "description">Sets as the ComponentDescription of the parameter's ICapeIdentification interface.</param>
        /// <param name = "mode">Sets the CapeParamMode mode of the parameter.</param>
        public CapeParameter(string name, string description, CAPEOPEN.CapeParamMode mode)
            : base(name, description)
        {
            this.m_mode = mode;
        }

        /// <summary>
        /// Occurs when the user validates the parameter.
        /// </summary>
        /// <remarks><para>Raises the ParameterValidated event through a delegate.</para>        
        /// </remarks>
        public event ParameterValidatedHandler ParameterValidated;
        /// <summary>
        /// Occurs when a parameter is validated.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterValidated</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterValidated</c> in a derived class, be sure to call the base class's <c>OnParameterValidated</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "ParameterValidatedEventArgs">ParameterValidatedEventArgs</see> that contains information about the event.</param>
        protected void OnParameterValidated(ParameterValidatedEventArgs args)
        {
            if (ParameterValidated != null)
            {
                ParameterValidated(this, args);
            }
        }

        /// <summary>
        /// Gets the Specification for this Parameter
        /// </summary>
        /// <remarks>
        /// Gets the specification of the parameter. The Get method returns the 
        /// specification as an interface to the correct specification type.
        /// </remarks>
        /// <value>
        /// An object implementing the <see cref = "ICapeParameterSpec"/>, as well as the
        /// appropriate specification for the parameter type, <see cref = "ICapeRealParameterSpec"/> ,
        /// <see cref = "ICapeIntegerParameterSpec"/> , <see cref = "ICapeBooleanParameterSpec"/> , 
        /// <see cref = "ICapeOptionParameterSpec"/> , or <see cref = "ICapeArrayParameterSpec"/> .
        /// </value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.BrowsableAttribute(false)]
        Object CAPEOPEN.ICapeParameter.Specification
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Occurs when the user changes of the value of the parameter.
        /// </summary>
        /// <remarks><para>Raises the ParameterValueChanged event through a delegate.</para>        
        /// </remarks>
        public event ParameterValueChangedHandler ParameterValueChanged;
        /// <summary>
        /// Occurs when the user changes of the value of a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnComponentNameChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterValueChanged</c> in a derived class, be sure to call the base class's <c>OnParameterValueChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "OnParameterValueChanged">OnParameterValueChanged</see> that contains information about the event.</param>
        protected void OnParameterValueChanged(ParameterValueChangedEventArgs args)
        {
            if (ParameterValueChanged != null)
            {
                ParameterValueChanged(this, args);
            }
        }

        /// <summary>
        /// Gets and sets the value for this Parameter.
        /// </summary>
        /// <remarks>
        /// This value uses the System.Object data type for compatibility with 
        /// COM-based CAPE-OPEN.
        /// </remarks>
        /// <value>System.Object</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.BrowsableAttribute(false)]
        virtual public Object value
        {
            get;
            set;
        }


        /// <summary>
        /// Gets the dimensionality of the parameter.
        /// </summary>
        /// <remarks>
        /// Physical dimensions are only applicable to real-valued parameters.
        /// </remarks>
        /// <value>
        /// Null pointer.
        /// </value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.BrowsableAttribute(false)]
        virtual public double[] Dimensionality
        {
            get
            {
                return (double[])null;
            }
        }

        /// <summary>
        /// Gets the dimensionality of the parameter.
        /// </summary>
        /// <remarks>
        /// Physical dimensions are only applicable to real-valued parameters.
        /// </remarks>
        /// <value>
        /// Null pointer.
        /// </value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.BrowsableAttribute(false)]
        Object CAPEOPEN.ICapeParameterSpec.Dimensionality
        {
            get
            {
                return null;
            }
        }


        /// <summary>
        /// Gets the flag to indicate parameter validation's status.
        /// </summary>
        /// <remarks>
        /// <para>Gets the flag to indicate parameter validation status. It has three 
        /// possible values:</para>
        /// <para>   (i)   notValidated(CAPE_NOT_VALIDATED): The PMC's <c>Validate()</c>
        /// method has not been called after the last time that its value had been 
        /// changed.</para>
        /// <para>   (ii)  invalid(CAPE_INVALID): The last time that the PMC's 
        /// <c>Validate()</c> method was called it returned false.</para>
        /// <para>   (iii) valid(CAPE_VALID): the last time that the PMC's
        /// Validate() method was called it returned true.</para>
        /// </remarks>
        /// <value>The validity status of the parameter, either valid, invalid, or "not validated".</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.Category("ICapeParameter")]
        public CAPEOPEN.CapeValidationStatus ValStatus
        {
            get
            {
                return m_ValStatus;
            }
        }

        /// <summary>
        /// Occurs when the user changes of the default value of the parameter changes.
        /// </summary>
        /// <remarks><para>Raises the ParameterDefaultValueChanged event through a delegate.</para>        
        /// </remarks>
        public event ParameterDefaultValueChangedHandler ParameterDefaultValueChanged;
        /// <summary>
        /// Occurs when the user changes of the default value of a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterDefaultValueChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterDefaultValueChanged</c> in a derived class, be sure to call the base class's <c>OnParameterDefaultValueChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "OnParameterDefaultValueChanged">OnParameterDefaultValueChanged</see> that contains information about the event.</param>
        protected void OnParameterDefaultValueChanged(ParameterDefaultValueChangedEventArgs args)
        {
            if (ParameterDefaultValueChanged != null)
            {
                ParameterDefaultValueChanged(this, args);
            }
            NotifyPropertyChanged("DefaultValue");
        }

        /// <summary>
        /// Occurs when the user changes of the mode of the parameter changes.
        /// </summary>
        /// <remarks><para>Raises the ParameterModeChanged event through a delegate.</para>        
        /// </remarks>
        public event ParameterModeChangedHandler ParameterModeChanged;
        /// <summary>
        /// Occurs when the user changes of the mode of a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterModeChanged</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterModeChanged</c> in a derived class, be sure to call the base class's <c>OnParameterModeChanged</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "ParameterModeChangedEventArgs">ParameterModeChangedEventArgs</see> that contains information about the event.</param>
        protected void OnParameterModeChanged(ParameterModeChangedEventArgs args)
        {
            if (ParameterModeChanged != null)
            {
                ParameterModeChanged(this, args);
            }
        }

        /// <summary>
        /// Gets and sets the mode of the parameter.
        /// </summary>
        /// <remarks>
        /// <para>Modes of parameters. It allows the following values:</para>
        /// <para>   (i)   Input (CAPE_INPUT): the Unit(or whichever owner component) will use 
        /// its value to calculate.</para>
        /// <para>   (ii)  Output (CAPE_OUTPUT): the Unit will place in the parameter a result 
        /// of its calculations.</para>
        /// <para>   (iii) Input-Output (CAPE_INPUT_OUTPUT): the user inputs an 
        /// initial estimation value and the user outputs a calculated value.</para>
        /// </remarks>
        /// <value>The mode of the parameter, input, output, or input/output.</value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        [System.ComponentModel.Category("ICapeParameter")]
        public CAPEOPEN.CapeParamMode Mode
        {
            get
            {
                return m_mode;
            }
            set
            {
                ParameterModeChangedEventArgs args = new ParameterModeChangedEventArgs(this.ComponentName, m_mode, value);
                OnParameterModeChanged(args);
                m_mode = value;
                this.NotifyPropertyChanged("Mode");
            }
        }

        /// <summary>
        /// Validates the current value of the parameter against the 
        /// specification of the parameter. 
        /// </summary>
        /// <remarks>
        /// The parameter is considered valid if the current value is 
        /// between the upper and lower bound. The message is used to 
        /// return the reason that the parameter is invalid. This function also
        /// sets the CapeValidationStatus of the parameter based upon the results
        /// of the validation.
        /// </remarks>
        /// <returns>
        /// True if the parameter is valid, false if not valid.
        /// </returns>
        /// <param name = "message">reference to a string that will contain a message regarding the validation of the parameter.</param>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed, for example, an unrecognized Compound identifier or UNDEFINED for the props argument.</exception>
        abstract public bool Validate(ref String message);



        /// <summary>
        /// Occurs when the user changes of the parameter value is reset to the default value.
        /// </summary>
        /// <remarks><para>Raises the ParameterReset event through a delegate.</para>        
        /// </remarks>
        public event ParameterResetHandler ParameterReset;
        /// <summary>
        /// Occurs when the user resets a parameter.
        /// </summary>
        /// <remarks><para>Raising an event invokes the event handler through a delegate.</para>
        /// <para>The <c>OnParameterReset</c> method also allows derived classes to handle the event without attaching a delegate. This is the preferred 
        /// technique for handling the event in a derived class.</para>
        /// <para>Notes to Inheritors: </para>
        /// <para>When overriding <c>OnParameterReset</c> in a derived class, be sure to call the base class's <c>OnParameterReset</c> method so that registered 
        /// delegates receive the event.</para>
        /// </remarks>
        /// <param name = "args">A <see cref = "ParameterResetEventArgs">ParameterResetEventArgs</see> that contains information about the event.</param>
        protected void OnParameterReset(ParameterResetEventArgs args)
        {
            if (ParameterReset != null)
            {
                ParameterReset(this, args);
            }
        }

        /// <summary>
        /// Sets the value of the parameter to its default value.
        /// </summary>
        /// <remarks>
        ///  This method sets the parameter's value to the default value.
        /// </remarks>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        abstract public void Reset();


        // ICapeParameterSpec
        // ICapeParameterSpec
        /// <summary>
        /// Gets the type of the parameter. 
        /// </summary>
        /// <remarks>
        /// Gets the <see cref = "CapeParamType"/> of the parameter for which this is a specification: real 
        /// (CAPE_REAL), integer(CAPE_INT), option(CAPE_OPTION), boolean(CAPE_BOOLEAN) 
        /// or array(CAPE_ARRAY).
        /// </remarks>
        /// <value>The parameter type. </value>
        /// <exception cref ="ECapeUnknown">The error to be raised when other error(s),  specified for this operation, are not suitable.</exception>
        /// <exception cref = "ECapeInvalidArgument">To be used when an invalid argument value is passed.</exception>
        [System.ComponentModel.Category("ICapeParameterSpec")]
        abstract public CAPEOPEN.CapeParamType Type
        {
            get;
        }
    }
}
