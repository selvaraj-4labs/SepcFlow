using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendApplicantsWizard
{
    public class AmendApplicantsP1 : BOWizardBasePage
    {
        public AmendApplicantsP1()
        {
            pageLoadedElement = title;
            correspondingDataClass = new AmendApplicantsP1Data().GetType();
            textName = "Amend Applicants Page 1";
            windowTitle = "Amend Applicants";  
        }

        #region 'New Applicant Details' Section
        public Element title => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Title"), "/Pane[@AutomationId=\"rightPanel\"]/ComboBox"));
        public Element firstName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "FirstName"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));
        public Element middleName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "MiddleName"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));
        public Element surname => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Surname"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));
        public Element dateOfBirth => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraDateTimeEditor"),
            "/Edit"));

        ///Edit[@AutomationId=\""[Editor\"]"
        public Element retirementAge => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "RetirementAge"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));
        public Element nationality => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Nationality"), "/Pane[@AutomationId=\"rightPanel\"]/ComboBox"));
        public Element taxCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "TaxCode"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));
        public Element niNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "NiNumber"), "/Pane[@AutomationId=\"rightPanel\"]/Edit"));

        public Element firstTimeBuyer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]/List[@AutomationId =\"ultraOptionSet\"]/Group/RadioButton[@Name =\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]/List[@AutomationId =\"ultraOptionSet\"]/Group/RadioButton[@Name =\"No\"]")));

        public Element basicRateTaxPayer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]/List[@AutomationId =\"ultraOptionSet\"]/Group/RadioButton[@Name =\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]/List[@AutomationId =\"ultraOptionSet\"]/Group/RadioButton[@Name =\"No\"]")));
        #endregion

        #region 'Alias Details' Section 
        public Element aliasTitle => new Element(FindElement("teTitle", attributeType: Defs.boLocatorAutomationId));
        public Element aliasFirstName => new Element(FindElement("teFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element aliasMiddleName => new Element(FindElement("teMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element aliasSurname => new Element(FindElement("teSurname", attributeType: Defs.boLocatorAutomationId));
        public Element aliasDateOfChange => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbAliasDetails"),
            "/ComboBox/ComboBox/Edit[@Name= \"Text area\"]"));
        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendApplicantsP1Data : PageData
    {
        private string _dateOfBirth = "01/01/1970";
        private string _aliasDateOfChange = null;

        #region 'New Applicant Details' Section
        public string title { get; set; } = "Mr";
        public string firstName { get; set; } = "NewFirstName";
        public string middleName { get; set; } = "NewMiddleName";
        public string surname { get; set; } = "NewSurname";
        public string dateOfBirth
        {
            get
            {
                if (_dateOfBirth == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + _dateOfBirth.Replace("/", "");
                }
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        public string retirementAge { get; set; } = "75";
        public string nationality { get; set; } = null;
        public string taxCode { get; set; } = null;
        public string niNumber { get; set; } = null;
        public string firstTimeBuyer { get; set; } = null;
        public string basicRateTaxPayer { get; set; } = null;
        #endregion

        #region 'Alias Details' Section 
        public string aliasTitle { get; set; } = null;
        public string aliasFirstName { get; set; } = null;
        public string aliasMiddleName { get; set; } = null;
        public string aliasSurname { get; set; } = null;
        public string aliasDateOfChange
        {
            get
            {
                if (_aliasDateOfChange == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + _aliasDateOfChange.Replace("/", "");
                }
            }
            set
            {
                _aliasDateOfChange = value;
            }
        }
        #endregion
    }
}
