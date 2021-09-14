using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu
{
    public class Workspace : AppBasePage
    {
        public Workspace()
        {
            pageLoadedElement = new Element(By.XPath("//*[]"));
            correspondingDataClass = new WorkspaceData().GetType();
            textName = "New Process";
        }


       public Element exitWorkspace => new Element(By.XPath("//Group[@Name='Workspace']/MenuItem[@Name='Exit Workspace']")).SetIsButtonFlag(true);



       
    }

    public class WorkspaceData : PageData
    {

    }
}
