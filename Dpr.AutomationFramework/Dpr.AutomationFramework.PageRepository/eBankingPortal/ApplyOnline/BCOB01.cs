using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class BCOB01 : WebBasePage
    {
        public BCOB01()
        {
            pageLoadedElement = acceptDeclaration;
            correspondingDataClass = new BCOB01Data().GetType();
            textName = "Key Product Summary Page";
        }

        public Element acceptDeclaration => new Element(FindElement("chkAcceptProductSummaryBox"));

        public Element next => new Element(FindElement("_Next")).SetIsButtonFlag(true);
    }

    public class BCOB01Data : PageData
    {
        public string acceptDeclaration { get; set; } = Defs.checkBoxSelected;
    }
}
