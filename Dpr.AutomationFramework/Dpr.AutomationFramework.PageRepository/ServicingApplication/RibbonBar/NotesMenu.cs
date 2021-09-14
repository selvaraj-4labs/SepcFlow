using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonBar
{
    public class NotesMenu : AppBasePage
    {
        public NotesMenu()
        {
            pageLoadedElement = new Element(By.XPath("//*[]"));
            correspondingDataClass = new NotesMenuData().GetType();
            textName = "Notes";
        }

      

        public Element newNote => new Element(By.XPath("//Group[@Name='Notes']/MenuItem[@Name='New Note']")).SetIsButtonFlag(true);
        
    }

    public class NotesMenuData : PageData
    {
    }
}
