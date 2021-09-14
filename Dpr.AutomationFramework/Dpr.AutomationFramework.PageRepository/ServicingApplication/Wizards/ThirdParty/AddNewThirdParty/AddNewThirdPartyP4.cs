using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP4 : AppBasePage
    {
        public AddNewThirdPartyP4()
        {
            pageLoadedElement = houseFlatNumberBox;
            correspondingDataClass = new AddNewThirdPartyP4Data().GetType();
            textName = "Add New Third Party Page 4";
        }

        #region Search by Postcode
        public Element houseFlatNumberBox => new Element(FindElement("teAddressLine", attributeType: Defs.boLocatorAutomationId));
        public Element postcodeBox => new Element(FindElement("tePostCodeSrch", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnAddressSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        //public Element addressDetailPostcodeBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "txtPostcodeNew"),
        //    "!null"));
        //public WaitFor waitForAddressDetailPostcodeBox => new WaitFor(searchBtn)
        //    .AddWaitElement(addressDetailPostcodeBox.locator);
        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewThirdPartyP4Data : PageData
    {
        public string houseFlatNumber { get; set; } = "11";
        public string postcode { get; set; } = "DA1 1TX";

    }
}
