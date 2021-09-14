using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyP3 : AppBasePage
    {
        public UpdateThirdPartyP3()
        {
            pageLoadedElement = houseFlatNumberBox;
            correspondingDataClass = new UpdateThirdPartyP3Data().GetType();
            textName = "Update Third Party Page 3";
        }

        public Element houseFlatNumberBox => new Element(FindElement("teAddressLine", attributeType: Defs.boLocatorAutomationId));
        public Element postcodeBox => new Element(FindElement("tePostCodeSrch", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnAddressSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element effectiveDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveDate"),
            "/ComboBox/Edit[@Name=\"Text area\"]"));
        public Element flatNoBox => new Element(FindElement("txtFlatNo", attributeType: Defs.boLocatorAutomationId));
        public Element buildingNoBox => new Element(FindElement("txtBuilding", attributeType: Defs.boLocatorAutomationId));
        public Element buildingNameBox => new Element(FindElement("txtBuildingName", attributeType: Defs.boLocatorAutomationId));
        // Further work req on the two below.
        //public Element addressLine1Box => new Element(FindElement("txtAddress", Defs.boLocatorAutomationId));
        //public Element addressLine2Box => new Element(FindElement("txtAddress", Defs.boLocatorAutomationId));
        public Element townCityBox => new Element(FindElement("txtTownCity", attributeType: Defs.boLocatorAutomationId));
        public Element countyBox => new Element(FindElement("txtCounty", attributeType: Defs.boLocatorAutomationId));
        public Element newPostcodeBox => new Element(FindElement("txtPostCode", attributeType: Defs.boLocatorAutomationId));
        public Element countryLookup => new Element(FindElement("cboCountry", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateThirdPartyP3Data : PageData
    {
        private string _effectiveDate = null;

        public string houseFlatNumber { get; set; } = "17";
        public string postcode { get; set; } = "SW8 3QJ";
        public string effectiveDate
        {
            get
            {
                if (_effectiveDate == null)
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
                        _effectiveDate.Replace("/", "");
                }
            }
            set
            {
                _effectiveDate = value;
            }
        }
        public string flatNo { get; set; } = null;
        public string buildingNo { get; set; } = null;
        public string buildingName { get; set; } = null;
        public string townCity { get; set; } = null;
        public string county { get; set; } = null;
        public string newPostcode { get; set; } = null;
        public string country { get; set; } = null;
    }
}
