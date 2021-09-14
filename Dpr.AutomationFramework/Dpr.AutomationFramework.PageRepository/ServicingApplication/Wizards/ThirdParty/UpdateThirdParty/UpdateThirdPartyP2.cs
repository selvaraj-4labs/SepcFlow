using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyP2 : AppBasePage
    {
        public UpdateThirdPartyP2()
        {
            pageLoadedElement = effectiveFromDateBox;
            correspondingDataClass = new UpdateThirdPartyP2Data().GetType();
            textName = "Update Third Party Page 2";
        }

        public Element nameChangeEditChbox => new Element(FindElement("chkEdit", attributeType: Defs.boLocatorAutomationId));

        #region 'Name Change' Section
        public Section nameChangeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "nameChangeEdit", Defs.checkBoxSelected))));

        public Element effectiveFromDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveDate"),
            "/Edit"));
        public Element titleLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTitle"),
            "/Edit"));
        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element middleNameBox => new Element(FindElement("txtMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd nameChangeSectionEnd => new SectionEnd();
        #endregion

        public Element useAlternativeNameChbox => new Element(FindElement(new LocatorList()
           .Add(Defs.boLocatorAutomationId, "chkUseAlternativeName"),
            "/CheckBox[@Name=\"Use alternative name for correspondence?\"]"));
        public Element nameForLettersBox => new Element(FindElement("txtNameForLetters", attributeType: Defs.boLocatorAutomationId));
        public Element isProspectiveChbox => new Element(FindElement("chkIsProspective", attributeType: Defs.boLocatorAutomationId));

        public Element idCardNumberBox => new Element(FindElement("txtIDCardNo", attributeType: Defs.boLocatorAutomationId));
        public Element placeofBirthBox => new Element(FindElement("txtPlaceOfBirth", attributeType: Defs.boLocatorAutomationId));
        public Element countryOfBirthLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboCountryOfBirth"),
            "/Edit"));
        public Element dateOfBirthBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtDOBThirdParty"),
            "/Edit"));
        public Element noDateOfBirthChbox => new Element(FindElement("chkNoDOBWanted", attributeType: Defs.boLocatorAutomationId));

        #region 'Nationalities' Section
        public Element nationality => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboPrimaryNationality"),
            "/Edit"));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateThirdPartyP2Data : PageData
    {
        private string _effectiveFromDate = null;
        private string _dateOfBirth = null;

        public string nameChangeEdit { get; set; } = Defs.checkBoxSelected;
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
        public string title { get; set; } = "Mr";
        public string maritalStatus { get; set; } = null;
        public string firstName { get; set; } = "TestFNameUpdate";
        public string middleName { get; set; } = null;
        public string surname { get; set; } = null;
        public string useAlternativeName { get; set; } = null;
        public string nameForLetters { get; set; } = null;
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
                        _dateOfBirth.Replace("/", "");
                }
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        public string noDateOfBirth { get; set; } = Defs.checkBoxSelected;
        public string idCardNumber { get; set; } = null;
        public string countryOfBirth { get; set; } = null;
        public string placeofBirth { get; set; } = null;
        public string nationality { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";

    }
}
