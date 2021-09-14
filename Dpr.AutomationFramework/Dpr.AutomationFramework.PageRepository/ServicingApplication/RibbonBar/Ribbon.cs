using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.RibbonMenu
{
    public class Ribbon : AppBasePage
    {
        public Ribbon()
        {
            //pageLoadedElement = new Element(By.XPath("//*"));
            pageLoadedElement = taskViewerBtn;
            correspondingDataClass = new RibbonData().GetType();
            textName = "Ribbon";
        }
        public Element taskViewerBtn => new Element(FindElement("Task Viewer", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

        public Element customerLocateBtn => new Element(FindElement("Customer Locate", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

        public Element paymentSearchBtn => new Element(FindElement("Payment Search", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

        public Element systemAccountBtn => new Element(FindElement("System Account", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

        public Element accountOperationsBtn => new Element(FindElement("Account Operations", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

        //public Element exitAccountBtn => new Element(FindElement("Exit Account", attributeType: Defs.boLocatorName))
        //    .SetIsButtonFlag(true);
        public Element exitAccountBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "TabCloseButton")));

        //public Element workspaceMenu => new Element(By.XPath("//MenuItem[@name='Workspace']"))
        //    .SetIsButtonFlag(true);

        public Element workspaceMenu => new Element(By.XPath(
            "//Pane[@Name=\"Lower Ribbon\"][@AutomationId=\"Lower Ribbon\"]" +
            "/Group[@Name=\"Workspace\"][@AutomationId=\"Group : ribHomeCaseCurrentActivity_Activity\"]" +
            "/MenuItem[@Name=\"Workspace\"]")).SetIsButtonFlag(true);

        //public Element newProcessMenu => new Element(By.XPath("//MenuItem[@name='New Process']"))
        //    .SetIsButtonFlag(true);

        //public Element newProcessMenu => new Element(By.XPath
        //    (
        //    "//Group[@Name=\"DockTop\"][@AutomationId=\"_MdiHost_Toolbars_Dock_Area_Top\"]" +
        //    "/Custom[@Name=\"Ribbon\"]/Custom[@Name=\"Home\"]/ToolBar[@Name=\"Account\"]" +
        //    "/MenuItem[@Name=\"New Process\"]"
        //    )).SetIsButtonFlag(true);

        public Element newProcessMenu => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Lower Ribbon"),
            "/Group[@Name=\"Account\"][@AutomationId=\"Group : ribHomeFormAccount\"]" +
            "/MenuItem[@Name=\"New Process\"]"))
            .SetIsButtonFlag(true);

        //public Element processActionsMenu => new Element(By.XPath("//MenuItem[@Name='Process Actions']"))
        //    .SetIsButtonFlag(true);

        public Element processActionsMenu => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Lower Ribbon"),
            "/Group[@Name=\"Workspace\"][@AutomationId=\"Group : ribHomeCaseCurrentActivity_Activity\"]" +
            "/MenuItem[@Name=\"Process Actions\"]"))
            .SetIsButtonFlag(true);

        public Element documentsMenu => new Element(By.XPath("//MenuItem[@Name='Documents']")).SetIsButtonFlag(true);

        public Element notes => new Element(By.XPath("//MenuItem[@name='Notes']"))
            .SetIsButtonFlag(true);

        public Element tasks => new Element(By.XPath("//MenuItem[@Name=\"Tasks\"]"))
            .SetIsButtonFlag(true);
    }

    public class RibbonData : PageData
    {

    }
}
