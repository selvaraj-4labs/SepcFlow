using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerP2 : AppBasePage
    {
        public AddCustomerP2()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new AddCustomerP2Data().GetType();
            textName = "Add Customer Page 2";
        }

        #region 'Customer New' Section
        public Element titleLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTitle"),
            "/Edit"));
        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element middleNameBox => new Element(FindElement("txtMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        public Element salutationBox => new Element(FindElement("txtSalutation", attributeType: Defs.boLocatorAutomationId));
        public Element dateOfBirthBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtDOB"),
            "/Edit"));

        
        #endregion

        public Element alternativeNameForCorrespondenceChbox => new Element(FindElement("gbCorrespondenceName", attributeType: Defs.boLocatorAutomationId));

        
        #region 'Details' Section
        public Element genderLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboGender"),
            "/Edit"));
        public Element maritalStatusLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboMaritalStatus"),
            "/Edit"));
        public Element nationalityLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboPrimaryNationality"),
            "/Edit"));
        public Element countryOfResidenceLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboCountryResidence"),
            "/Edit"));

        public Element niNumberBox => new Element(FindElement("txtNINumber", attributeType: Defs.boLocatorAutomationId));
        public Element currentlyResidentUKRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbCurResUKYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbCurResUKNo", attributeType: Defs.boLocatorAutomationId)));
        public Element rightToResideUKRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbResideUKYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbResideUKNo", attributeType: Defs.boLocatorAutomationId)));
        public Element validWorkPermitRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbWorkPermitYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbWorkPermitNo", attributeType: Defs.boLocatorAutomationId)));
        public Element diplomaticImmunityRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbDiplomaticYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbDiplomaticNo", attributeType: Defs.boLocatorAutomationId)));
        public Element staffRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbStaffYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbStaffNo", attributeType: Defs.boLocatorAutomationId)));
        #endregion

        public Element nonResidentTaxForm => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbResideUKYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbResideUKNo", attributeType: Defs.boLocatorAutomationId)));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddCustomerP2Data : PageData
    {
        public string uniqueIdentifier { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }

        private string _dateOfBirth = "09/12/1999";

        public AddCustomerP2Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            firstName = "testFName-" + uniqueIdentifier;
            surname = "testLName-" + uniqueIdentifier;
        }

        #region 'Customer New' Section
        public string title { get; set; } = "Mr";
        public string middleName { get; set; } = "TestMName";
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

        #endregion

        public string alternativeNameForCorrespondence { get; set; } = null;

        #region 'Details' Section
        public string gender { get; set; } = "Male";
        public string maritalStatus { get; set; } = "Single";
        public string nationality { get; set; } = "British";
        public string countryOfResidence { get; set; } = "United Kingdom";
        public string niNumber { get; set; } = null;
        public string currentlyResidentUK { get; set; } = Defs.radioButtonYes;
        public string rightToResideUK { get; set; } = Defs.radioButtonYes;
        public string validWorkPermit { get; set; } = Defs.radioButtonYes;
        public string diplomaticImmunity { get; set; } = Defs.radioButtonNo;
        public string staff { get; set; } = Defs.radioButtonNo;
        public string nonResidentTax { get; set; } = Defs.radioButtonNo;
        #endregion

        public string remarks { get; set; } = "TestRemarks";
    }
}
