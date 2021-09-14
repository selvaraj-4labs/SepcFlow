using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu
{
    public class NewProcess : AppBasePage
    {
        public NewProcess()
        {
            pageLoadedElement = new Element(By.XPath("//*"));
            correspondingDataClass = new RibbonData().GetType();
            textName = "New Process";
        }

        public Element accountActions => new Element(By.XPath("//MenuItem[@Name='Account Actions']")).SetIsButtonFlag(true);
        public Element accountAdmin => new Element(By.XPath("//MenuItem[@Name='Account Admin']")).SetIsButtonFlag(true);
        public Element customer => new Element(By.XPath("//MenuItem[@Name='Customer']")).SetIsButtonFlag(true);
        public Element repayments => new Element(By.XPath("//MenuItem[@Name='Repayments']")).SetIsButtonFlag(true);
        public Element customerUpdate => new Element(By.XPath("//MenuItem[@Name='Customer Update']")).SetIsButtonFlag(true);
    }

    // /MenuItem[@Name=\"New Process\"]
    public class NewProcessData : PageData
    {
    }
}
