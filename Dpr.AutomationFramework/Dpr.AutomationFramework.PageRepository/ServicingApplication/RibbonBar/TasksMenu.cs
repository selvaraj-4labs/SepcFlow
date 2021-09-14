using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonBar
{
    public class TasksMenu : AppBasePage
    {
        public TasksMenu()
        {
            pageLoadedElement = new Element(By.XPath("//*[]"));
            correspondingDataClass = new TasksMenuData().GetType();
            textName = "Tasks";
        }
        public Element newTask => new Element(By.XPath("//Group[@Name='Tasks']/MenuItem[@Name='Add Task']")).SetIsButtonFlag(true);
        // /MenuItem[@Name='Tasks']
    }
    public class TasksMenuData : PageData
    {
    }
}
