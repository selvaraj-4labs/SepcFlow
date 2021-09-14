using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonBar
{
    public class DocumentsMenu : AppBasePage
    {
        public DocumentsMenu()
        {
            pageLoadedElement = new Element(By.XPath("//*[]"));
            correspondingDataClass = new DocumentsMenuData().GetType();
            textName = "Documents";
        }
        public Element newDocument => new Element(By.XPath("//Group[@Name=\"Documents\"]/MenuItem[@Name=\"New\"]")).SetIsButtonFlag(true);

    }

    public class DocumentsMenuData : PageData
    {
    }
}
