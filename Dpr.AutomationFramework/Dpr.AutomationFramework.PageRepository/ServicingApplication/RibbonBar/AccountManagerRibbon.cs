using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonBar
{
    public class AccountManagerRibbon : AppBasePage
    {
        public AccountManagerRibbon()
        {
            pageLoadedElement = summaryTabBtn;
            correspondingDataClass = new AccountManagerRibbonData().GetType();
            textName = "New Process";
        }

        public Element summaryTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Summary", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element processesTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Processes", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element customerExposureTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Customer Exposure", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element savingsAccountTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Savings Account", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element customerDetailsTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Customer Details", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element investmentPlanTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Investment Plan", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element withdrawlsTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Withdrawls", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element notesTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Notes", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element thirdPartiesTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Third Parties", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element feesTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Fees", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element savingsProductTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Savings Product", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element financialsTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Financials", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element documentsTabBtn => new Element(FindElement(new LocatorList()
            .Add("accountTabs", Defs.boLocatorAutomationId)
            .Add("Documents", Defs.boLocatorName)))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }

    public class AccountManagerRibbonData : PageData
    {

    }
}
