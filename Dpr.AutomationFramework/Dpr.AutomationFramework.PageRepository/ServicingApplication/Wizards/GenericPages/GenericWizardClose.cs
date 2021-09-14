using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages
{
    public class GenericWizardClose : AppBasePage
    {

        public Ribbon ribbon = new Ribbon();
        public Workspace workspace = new Workspace();
        public ProcessActions processActions = new ProcessActions();
        public NewProcess newProcess = new NewProcess();

        public GenericWizardClose()
        {
            //   pageLoadedElement = new Element(By.XPath
            //       (
            //"//Pane[@AutomationId=\"panel\"]" +
            //"/Pane[@AutomationId=\"AccountManager\"]" +
            //"/Tab[@AutomationId=\"accountTabs\"]" +
            //"/Pane[@AutomationId=\"ultraTabPageCurrentActivity\"]" +
            //"/Pane[@AutomationId=\"TabCurrentActivity\"]" +
            //"/Pane[@AutomationId=\"rightPanel\"]" +
            //"/Pane[starts-with(@AutomationId,\"activityItemsPanel\")]" +
            //"/Group[@Name=\"Processes\"][@AutomationId=\"gbProcesses\"]"

            //       ));


            //pageLoadedElement = new Element(By.XPath(
            //    "//Pane[@AutomationId=\"TabCurrentActivity\"]" +
            //    "/Pane[@AutomationId=\"rightPanel\"]/Pane[starts-with(@AutomationId,\"activityItemsPanel\")]" +
            //    "/Group[@Name=\"Processes\"][@AutomationId=\"gbProcesses\"]" +
            //    "/CheckBox[@Name=\"View all processes initiated in this workspace\"][@AutomationId=\"chkViewAllProcess\"]" +
            //    "/CheckBox[@Name=\"View all processes initiated in this workspace\"]"));
            pageLoadedElement = processesInitiatedChbox;
            correspondingDataClass = new GenericWizardCloseData().GetType();
            textName = "Generic Wizard Close";
        }
        public Element processesInitiatedChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkViewAllProcess")));
    }


    public class GenericWizardCloseData : PageData
    {
    }
}
