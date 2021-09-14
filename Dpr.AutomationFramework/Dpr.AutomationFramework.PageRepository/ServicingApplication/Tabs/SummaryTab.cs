using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Tabs
{
    public class SummaryTab : AppBasePage
    {
        public SummaryTab()
        {
            pageLoadedElement = firstCustomerNo;
            correspondingDataClass = new SummaryTabData().GetType();
            textName = "Summary Tab";
        }
        public Element firstCustomerNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbCustomers"),
            "/Pane[starts-with(@AutomationId,\"contactSummaryGrid\")]/Table[@AutomationId=\"ultraGrid\"]/Custom[contains(@Name, 'ContactSummaryViewBinder')][1]/DataItem[@Name=\"No.\"]"));
        
        public Element secoundCustomerNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "contactSummaryGrid"),
            "/Table[@AutomationId=\"ultraGrid\"]/Custom[@Name=\"\"ContactSummaryViewBinder[\"][2]/DataItem[@Name=\"No.\"]"));

        public Element thirdCustomerNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "contactSummaryGrid"),
            "/Table[@AutomationId=\"ultraGrid\"]/Custom[@Name=\"\"ContactSummaryViewBinder[\"][3]/DataItem[@Name=\"No.\"]"));
        public Element fourthCustomerNo => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "contactSummaryGrid"),
            "/Table[@AutomationId=\"ultraGrid\"]/Custom[@Name=\"\"ContactSummaryViewBinder[\"][4]/DataItem[@Name=\"No.\"]"));
    }
    public class SummaryTabData : PageData
    {
    }
}
// //Group[@Name="Customers"][@AutomationId="gbCustomers"]/Pane[starts-with(@AutomationId,"contactSummaryGrid")]/Table[@AutomationId="ultraGrid"]/Custom[contains(@Name, 'ContactSummaryViewBinder')][1]/DataItem[@Name="No."]"