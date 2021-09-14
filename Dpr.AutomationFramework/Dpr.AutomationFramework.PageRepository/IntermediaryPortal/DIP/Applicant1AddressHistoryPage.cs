using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1AddressHistoryPage : WebBasePage
    {
        public Applicant1AddressHistoryPage()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new Applicant1AddressHistoryPageData().GetType();
            textName = "Applicant 1 Address Histroy Page";
        }
        public Element everHadAUKAddress => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HaveYouEverHadUKAddress_0", tag:"input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HaveYouEverHadUKAddress_1", tag: "input")));
        public Element isAddressAUKAddress => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radIsUKAddress_btn_rbl_0", "item0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radIsUKAddress_btn_rbl_1", "item0", tag: "input")));
        public Element nameOrNumber => new Element(FindElement("SearchAddressLine", "item0", tag: "input"));
        public Element postcode => new Element(FindElement("SearchPostCode", "item0", tag: "input"));
        
        public Element addressLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "item0")
            .Add(Defs.locatorId, "GetFullAddress")))
            .SetCompletePageFlag(false);

        public Element findAddress => new Element(FindElement("SearchButton", "item0", tag: "input")).SetIsButtonFlag(true);
        public WaitFor waitForSelectAddressOrAddressLbl => new WaitFor(findAddress)
             .AddWaitElement(addressLbl.locator);

        public Element residentialStatus => new Element(FindElement("ResidentialStatus", "item0", tag: "select"));
        public Element fromDate => new Element(FindElement("StartDateAtAddress", "item0", tag: "input"));
        public Element toDate => new Element(FindElement("EndDateAtAddress", "item0", tag: "input")).SetCompletePageFlag(false);
        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class Applicant1AddressHistoryPageData : PageData
    {
        public string everHadAUKAddress { get; set; } = Defs.radioButtonYes;
        public string isAddressAUKAddress { get; set; } = Defs.radioButtonYes;
        public string nameOrNumber { get; set; } = "27";
        public string postcode { get; set; } = "CM1 6JN";
        public string residentialStatus { get; set; } = "Owner Unencumbered";
        public string fromDate { get; set; } = "10/2010";
        public string toDate { get; set; } = string.Empty;
    }
}
