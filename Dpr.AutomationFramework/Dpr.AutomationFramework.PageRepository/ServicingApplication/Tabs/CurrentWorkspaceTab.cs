using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Tabs
{
    public class CurrentWorkspaceTab : AppBasePage
    {
        public CurrentWorkspaceTab()
        {
            pageLoadedElement = viewProcessesInitiatedChbox;
            correspondingDataClass = new CurrentWorkspaceTabData().GetType();
            textName = "Current Workspace tab";
        }

        public Element viewProcessesInitiatedChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkViewAllProcess")));



        //public Element processList => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0")));

        //public Element processList => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "processesGrid"),
        //    "/Custom[@AutomationId=\"ultraGrid\"]" +
        //    "/Custom[@AutomationId=\"Data Area\"]" +
        //    "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]" +
        //    "/DataItem[position()=2]" +
        //    "/Edit[@Name=\"Description\"]"));

        
        public Element processTable => new Element(By.XPath("//Pane[@AutomationId=\"processesGrid\"]" +
            "/Custom[@AutomationId=\"ultraGrid\"]" +
            "/Custom[@AutomationId=\"Data Area\"]" +
            "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]"));

        public Element listOfProcesses => new Element(By.XPath("//DataItem/Edit[@Name=\"Description\"]"));
    }

    public class CurrentWorkspaceTabData : PageData
    {

    }
}
