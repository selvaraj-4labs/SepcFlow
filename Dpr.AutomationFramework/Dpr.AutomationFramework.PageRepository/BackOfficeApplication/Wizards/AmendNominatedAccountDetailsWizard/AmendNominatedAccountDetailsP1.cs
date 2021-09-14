using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendNominatedAccountDetailsWizard
{
    public class AmendNominatedAccountDetailsP1 : BOWizardBasePage
    {

        public AmendNominatedAccountDetailsP1()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new AmendNominatedAccountDetailsP1Data().GetType();
            textName = "Amend Nominated Account Details Page 1";
        }


        public Element sortCodeBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbSortCodeRight"),
            "/Edit[position()=2]"
            ));


        public Element accountNumberBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbAccountNumberRight"),
            "/Edit"
            ));

        public Element searchBtn => new Element(FindElement("butSearch", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);


        public Element bankNameBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "tbBankNameRight"),
            "/Edit[starts-with(@ClassName,\"WindowsForms10\")]"
            ))
            .SetCompletePageFlag(false);


        public Element houseNameBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbHouseNameRight"),
            "/Edit"
            ))
            .SetCompletePageFlag(false);


        public Element addressBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbBankAddressRight"),
            "/Edit"
            ))
            .SetCompletePageFlag(false);

        public Element townBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbTownRight"),
            "/Edit"
            ))
            .SetCompletePageFlag(false);


        public Element countyBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbCountyRight"),
            "/Edit"
            ))
            .SetCompletePageFlag(false);


        public Element postcodeBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbPostcodeRight"),
            "/Edit"
            ))
            .SetCompletePageFlag(false);

        public Element accountNameBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbRightPanel")
            .Add(Defs.boLocatorAutomationId, "tbAccountNameRight"),
            "/Edit"
            ));


        public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class AmendNominatedAccountDetailsP1Data : PageData
    {


        public string sortcode { get; set; } = "938611";


        public string accountNumber { get; set; } = "02149187";


        public string accountName { get; set; } = "Replacement Test Account";


    }
}
    