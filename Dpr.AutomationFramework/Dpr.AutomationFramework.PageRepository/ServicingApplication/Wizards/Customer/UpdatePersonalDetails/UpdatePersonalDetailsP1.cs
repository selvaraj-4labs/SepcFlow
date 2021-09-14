using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails
{
    public class UpdatePersonalDetailsP1 : AppBasePage
    {
        public UpdatePersonalDetailsP1()
        {
            pageLoadedElement = nameChangeEditChbox;
            correspondingDataClass = new UpdatePersonalDetailsP1Data().GetType();
            textName = "Update Personal Details Page 1";
        }
        public Element nameChangeEditChbox => new Element(FindElement("chkEdit", attributeType: Defs.boLocatorAutomationId));

        #region 'Name Change' Section
        public Section nameChangeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "nameChangeEdit", Defs.checkBoxSelected))));

        public Element effectiveFromDateBox => new Element(FindElement("dtEffectiveDate", attributeType: Defs.boLocatorAutomationId));
        public Element titleLookup => new Element(FindElement("cboTitle", attributeType: Defs.boLocatorAutomationId));
        public Element maritalStatusLookup => new Element(FindElement("cboMaritalStatus", attributeType: Defs.boLocatorAutomationId));
        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element middleNameBox => new Element(FindElement("txtMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        
        public SectionEnd nameChangeSectionEnd => new SectionEnd();
        #endregion

        public Element useAlternativeNameChbox => new Element(FindElement(new LocatorList()
           .Add(Defs.boLocatorAutomationId, "chkUseAlternativeName"),
            "/CheckBox[@Name=\"Use alternative name for correspondence?\"]"));
        public Element nameForLettersBox => new Element(FindElement("txtNameForLetters", attributeType: Defs.boLocatorAutomationId));
        public Element authorityToCreditSearchRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbAuthorityToCreditSearchEdit")
                .Add(Defs.boLocatorName, "Yes")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbAuthorityToCreditSearchEdit")
                .Add(Defs.boLocatorName, "Yes"))));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdatePersonalDetailsP1Data : PageData
    {
        private string _effectiveFromDate = null;

        public string nameChangeEdit { get; set; } = Defs.checkBoxNotSelected;
        public string effectiveFromDate
        {
            get
            {
                if (_effectiveFromDate == null)
                {
                    return null;
                }
                else
                {
                    return 
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _effectiveFromDate.Replace("/", "");
                }
            }
            set
            {
                _effectiveFromDate = value;
            }
        }
        public string title { get; set; } = null;
        public string maritalStatus { get; set; } = null;
        public string firstName { get; set; } = null;
        public string middleName { get; set; } = null;
        public string surname { get; set; } = null;
        public string useAlternativeName { get; set; } = null;
        public string nameForLetters { get; set; } = null;
        public string authorityToCreditSearch { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";

    }
}
