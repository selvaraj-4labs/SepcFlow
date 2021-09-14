using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard
{
    public class WithdrawalReversalP1 : AppBasePage
    {

        public WithdrawalReversalP1()
        {
            pageLoadedElement = entryDateColumnHeader;
            correspondingDataClass = new WithdrawalReversalP1Data().GetType();
            textName = "Withdrawal Wizard Page 1";
        }

        public Element entryDateColumnHeader => new Element(By.XPath(
            "//Pane[starts-with(@ClassName,\"WindowsForms10\")]" +
            "/Window[@Name=\"40032158 Retail Saving Account Fixed Term Saving New Account\"][@AutomationId=\"AccountManagerForm\"]" +
            "/Pane[@AutomationId=\"panel\"]" +
            "/Pane[@AutomationId=\"AccountManager\"]" +
            "/Tab[@AutomationId=\"accountTabs\"]" +
            "/Pane[@AutomationId=\"ultraTabPageCurrentActivity\"]" +
            "/Pane[@AutomationId=\"TabCurrentActivity\"]/Group[@Name=\" \"][@AutomationId=\"rightCollapsiblePanel\"]" +
            "/Pane[@Name=\"Withdrawal Reversal\"][@AutomationId=\"WizardPanelOne\"]" +
            "/Pane[@Name=\"Withdrawal Reversal\"][@AutomationId=\"WizardInAPanel\"]" +
            "/Pane[@AutomationId=\"wizardPanel\"]" +
            "/Pane[@AutomationId=\"DefaultWizardUserControl\"]" +
            "/Pane[@Name=\"Wizard Help\"][@AutomationId=\"panelMain\"]" +
            "/Tab[@Name=\"Wizard Help\"][starts-with(@AutomationId,\"tabControl\")]" +
            "/Pane[@AutomationId=\"WithdrawalReversalEntry\"]" +
            "/Pane[@AutomationId=\"DefaultWizardPage\"]" +
            "/Pane[starts-with(@ClassName,\"WindowsForms10\")][@Name=\"WithdrawalReversalEntry\"]" +
            "/Pane[@AutomationId=\"WithdrawalReversalEntry\"]" +
            "/Pane[@AutomationId=\"withdrawalEntry\"]" +
            "/Group[@Name=\"Withdrawals\"][@AutomationId=\"gbSearchDetail\"]" +
            "/MenuItem[@AutomationId=\"dgSearchDetail\"]" +
            "/Table[@AutomationId=\"ultraGrid\"]" +
            "/Group[@Name=\"Column Headers\"]" +
            "/Header[@Name=\"Entry Date\"]"));
        public Element selectWithdrawal1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "List`1 row 1"), "/DataItem"));
        public Element nextBtn => new Element(FindElement("=Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }


    public class WithdrawalReversalP1Data : PageData
    {
    }
}
