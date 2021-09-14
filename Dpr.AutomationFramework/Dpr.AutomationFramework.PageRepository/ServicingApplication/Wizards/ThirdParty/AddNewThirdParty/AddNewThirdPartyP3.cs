using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP3 : AppBasePage
    {
        public AddNewThirdPartyP3()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new AddNewThirdPartyP3Data().GetType();
            textName = "Add New Third Party Page 3";
        }

        #region 'Third Party New - Personal Details' Section
        public Element titleLookup => new Element(FindElement("cboTitle", attributeType: Defs.boLocatorAutomationId));
        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element middleNameBox => new Element(FindElement("txtMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        public Element salutationBox => new Element(FindElement("txtSalutation", attributeType: Defs.boLocatorAutomationId));
        public Element dateOfBirthBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtDOBThirdParty"),
            "/Edit"));
        public Element dateOfBirthNoneChbox => new Element(FindElement("chkNoDOBWanted", attributeType: Defs.boLocatorAutomationId));
        public Element idCardNumberBox => new Element(FindElement("txtIDCardNo", attributeType: Defs.boLocatorAutomationId));
        public Element countryOfBirthLookup => new Element(FindElement("cboCountryOfBirth", attributeType: Defs.boLocatorAutomationId));
        public Element placeOfBirthBox => new Element(FindElement("txtPlaceOfBirth", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'Correspondence Name' Section
        public Element alternativeNameForCorrespondence => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkAlternativeCorrespondenceName")));
        #endregion

        #region 'Nationality' Section
        public Element nationality=> new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboPrimaryNationality"),
            "/Edit"));
        #endregion

        public Element remarks=> new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewThirdPartyP3Data : PageData
    {
        public AddNewThirdPartyP3Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            firstName = "testFName-" + uniqueIdentifier;
            surname = "testLName-" + uniqueIdentifier;
        }

        private string _dateOfBirth = "10/12/1999";

        public string uniqueIdentifier { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string surname { get; set; }

        public string title { get; set; } = "Mr";
        public string salutation { get; set; } = null;
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
        public string placeOfBirth { get; set; } = "United Kingdom";
        public string nationality { get; set; } = "British";
        public string remarks { get; set; } = "TestRemarks";
    }
}
