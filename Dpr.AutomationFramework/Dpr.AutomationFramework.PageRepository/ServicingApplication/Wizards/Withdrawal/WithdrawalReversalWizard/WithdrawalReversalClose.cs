using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard
{
    public class WithdrawalReversalClose : AppBasePage
    {

        Ribbon ribbon = new Ribbon();
        Workspace workspace = new Workspace();
        ProcessActions processActions = new ProcessActions();
        NewProcess newProcess = new NewProcess();

        public WithdrawalReversalClose()
        {
            pageLoadedElement = new Element(By.XPath
                (
         "//Pane[@AutomationId=\"panel\"]" +
         "/Pane[@AutomationId=\"AccountManager\"]" +
         "/Tab[@AutomationId=\"accountTabs\"]" +
         "/Pane[@AutomationId=\"ultraTabPageCurrentActivity\"]" +
         "/Pane[@AutomationId=\"TabCurrentActivity\"]" +
         "/Pane[@AutomationId=\"rightPanel\"]" +
         "/Pane[starts-with(@AutomationId,\"activityItemsPanel\")]" +
         "/Group[@Name=\"Processes\"][@AutomationId=\"gbProcesses\"]"

                ));
            correspondingDataClass = new WithdrawalReversalCloseData().GetType();
            textName = "Withdrawal Wizard Close";
        }
    }


    public class WithdrawalReversalCloseData : PageData
    {
    }
}
