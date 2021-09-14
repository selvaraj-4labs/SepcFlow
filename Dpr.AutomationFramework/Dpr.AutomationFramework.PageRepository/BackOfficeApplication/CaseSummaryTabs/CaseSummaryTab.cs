using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSummaryTabs
{
    public class CaseSummaryTab : AppBasePage
    {
        public CaseSummaryTab()
        {
            pageLoadedElement = idBox;
            correspondingDataClass = new CaseSummaryTabData().GetType();
            textName = "Case Search Tab";
        }

        public Element idBox => new Element(FindElement("lblHeaderIDValue", Defs.boLocatorAutomationId));

        public Element caseStatusBox => new Element(FindElement("lblHeaderIDValue", Defs.boLocatorAutomationId));

        public Element appReceiptDateBox => new Element(FindElement("lblHeaderStartValue", Defs.boLocatorAutomationId));

        public Element offerBox => new Element(FindElement("lblHeaderOfferValue", Defs.boLocatorAutomationId));

        public Element applicantBox => new Element(FindElement("lblHeaderBorrowerValue", Defs.boLocatorAutomationId));

    }

    public class CaseSummaryTabData : PageData
    {

    }
}
