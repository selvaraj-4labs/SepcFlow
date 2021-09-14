using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard
{
    public class WithdrawalReversalP3 : AppBasePage
    {

        public WithdrawalReversalP3()
        {
            pageLoadedElement = result;
            correspondingDataClass = new WithdrawalReversalP3Data().GetType();
            textName = "Withdrawal Wizard Page 3";
        }

        public Element result => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtResult"),"/Edit"))
            .SetCompletePageFlag(false);

        public Element successResult => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "processingResultDetails"), "/Edit[@Name='Success']", "Pane"))
            .SetCompletePageFlag(false);

        public Element nextBtn => new Element(FindElement("=Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);

        //public WaitFor waitForWizardToEnd => new WaitFor(nextBtn)
        //    .AddWaitElement(By.XPath
        //        (
        // "//Pane[@AutomationId=\"panel\"]" +
        // "/Pane[@AutomationId=\"AccountManager\"]" +
        // "/Tab[@AutomationId=\"accountTabs\"]" +
        // "/Pane[@AutomationId=\"ultraTabPageCurrentActivity\"]" +
        // "/Pane[@AutomationId=\"TabCurrentActivity\"]" +
        // "/Pane[@AutomationId=\"rightPanel\"]" +
        // "/Pane[starts-with(@AutomationId,\"activityItemsPanel\")]" +
        // "/Group[@Name=\"Processes\"][@AutomationId=\"gbProcesses\"]"
        //        ));
    }


    public class WithdrawalReversalP3Data : PageData
    {
        public string causeOfReversal { set; get; } = "Payment Returned";
        public string reasonForReversal { set; get; } = "Test";
    }
}
