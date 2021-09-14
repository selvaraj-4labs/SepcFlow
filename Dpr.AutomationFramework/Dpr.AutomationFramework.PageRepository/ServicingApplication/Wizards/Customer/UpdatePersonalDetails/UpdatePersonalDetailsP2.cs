using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails
{
    public class UpdatePersonalDetailsP2 : AppBasePage
    {
        public UpdatePersonalDetailsP2()
        {
            pageLoadedElement = dateOfBirthBox;
            correspondingDataClass = new UpdatePersonalDetailsP2Data().GetType();
            textName = "Update Personal Details Page 2";
        }
        #region 'Personal Details' Section
        public Element dateOfBirthBox => new Element(FindElement("dtDateOfBirth", attributeType: Defs.boLocatorAutomationId));
        public Element genderLookup => new Element(FindElement("cboGender", attributeType: Defs.boLocatorAutomationId));
        public Element countryOfBirthLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboBirthCountry"),
            "/Edit"));
        public Element placeOfBirthBox => new Element(FindElement("txtBirthPlace", attributeType: Defs.boLocatorAutomationId));
        public Element staffRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbStaffYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbStaffNo", attributeType: Defs.boLocatorAutomationId)));
        public Element diplomaticImmunityRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbDiplomaticImmunityYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbDiplomaticImmunityNo", attributeType: Defs.boLocatorAutomationId)));
        #endregion

        #region 'Nationality' Section
        public Element nationalityLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ddlAdditionalNationality"),
            "/Edit"));
        public Element primaryAdditionalNationalityLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ddlAdditionalNationality"),
            "/Edit"));
        public Element secondaryAdditionalNationalityLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ddlAdditionalNationality"),
            "/Edit"));
        #endregion

        #region 'Residency Details' Section
        public Element rdCountryLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboMainResidenceCountry"),
            "/Edit"));
        public Element currentlyUKResidentRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbUKResidenceYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbUKResidenceNo", attributeType: Defs.boLocatorAutomationId)));
        public Element nationalInsuranceNumberBox => new Element(FindElement("txtTaxNINumber", attributeType: Defs.boLocatorAutomationId));
        public Element rightToResideUKRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbRightToResideYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbRightToResideNo", attributeType: Defs.boLocatorAutomationId)));
        public Element validWorkPermitRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rbValidWorkPermitYes", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rbValidWorkPermitNo", attributeType: Defs.boLocatorAutomationId)));
        #endregion

        #region 'Tax Residency' Section
        public Element trCountryLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTaxResidencyCountry"),
            "/Edit"));
        public Element taxIdNumberBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtTaxResidenceIDNumber"),
            "/Edit"));
        #endregion

        #region 'Identification Document' Section
        public Element documentTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboDocType"),
            "/Edit"));
        public Element documentNumberBox => new Element(FindElement("txtIdentityCardNo", attributeType: Defs.boLocatorAutomationId));
        public Element issuingCountryLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboIssuingCountry"),
            "/Edit"));
        public Element documentExpiryDateBox => new Element(FindElement("dtExpiryDate", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'ID Verification' Section
        public Element lastReviewDateBox => new Element(FindElement("dtDateOfLastReview", attributeType: Defs.boLocatorAutomationId));
        public Element reviewDueDateBox => new Element(FindElement("dtReviewDueDate", attributeType: Defs.boLocatorAutomationId));
        public Element idVerificationRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Check Not Required", FindElement("rbCheckNotRequired", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Manual Review Compeleted", FindElement("rbManualReviewCompleted", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Perform Automatic Review", FindElement("rbPerformAutomaticReview", attributeType: Defs.boLocatorAutomationId)));
        public Element reviewCompletedChbox => new Element(FindElement("chkReviewCompleted", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'External Reference' Section
        public Element externalReferenceBox => new Element(FindElement("txtExternalReference", attributeType: Defs.boLocatorAutomationId));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdatePersonalDetailsP2Data : PageData
    {

        #region Private Variable Defiintions
        private string _dateOfBirth = null;
        private string _documentExpiryDate = null;
        private string _lastReviewDate = null;
        private string _reviewDueDate = null;
        #endregion

        #region 'Personal Details' Section
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
        public string gender { get; set; } = null;
        public string countryOfBirth { get; set; } = "United Kingdom";
        public string placeOfBirth { get; set; } = null;
        public string staff { get; set; } = null;
        public string diplomaticImmunity { get; set; } = null;
        #endregion

        #region 'Nationality' Section
        public string nationality { get; set; } = null;
        public string primaryAdditionalNationality { get; set; } = null;
        public string secondaryAdditionalNationality { get; set; } = null;
        #endregion

        #region 'Residency Details' Section
        public string rdCountry { get; set; } = "United Kingdom";
        public string currentlyUKResident { get; set; } = null;
        public string nationalInsuranceNumber { get; set; } = null;
        public string validWorkPermit { get; set; } = null;
        #endregion

        #region 'Tax Residency' Section
        public string trCountry { get; set; } = null;
        public string taxIdNumber { get; set; } = null;
        #endregion

        #region 'Identification Document' Section
        public string documentType { get; set; } = null;
        public string documentNumber { get; set; } = null;
        public string issuingCountry { get; set; } = null;
        public string documentExpiryDate
        {
            get
            {
                if (_documentExpiryDate == null)
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
                        _documentExpiryDate.Replace("/", "");
                }
            }
            set
            {
                _documentExpiryDate = value;
            }
        }
        #endregion

        #region 'ID Verification' Section
        public string lastReviewDate
        {
            get
            {
                if (_lastReviewDate == null)
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
                        _lastReviewDate.Replace("/", "");
                }
            }
            set
            {
                _lastReviewDate = value;
            }
        }
        public string reviewDueDate
        {
            get
            {
                if (_reviewDueDate == null)
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
                        _reviewDueDate.Replace("/", "");
                }
            }
            set
            {
                _reviewDueDate = value;
            }
        }
        public string idVerification { get; set; } = null;
        #endregion

        #region 'External Reference' Section
        public string externalReference { get; set; } = null;
        #endregion

        public string remarks { get; set; } = "TestRemarks";
    }
}
