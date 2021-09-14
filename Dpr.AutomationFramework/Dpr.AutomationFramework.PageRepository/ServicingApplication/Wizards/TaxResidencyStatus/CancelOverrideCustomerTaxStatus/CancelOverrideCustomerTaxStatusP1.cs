using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelOverrideCustomerTaxStatus
{
    public class CancelOverrideCustomerTaxStatusP1 : AppBasePage
    {
        public CancelOverrideCustomerTaxStatusP1()
        {
            pageLoadedElement = remarksBox;
            correspondingDataClass = new CancelOverrideCustomerTaxStatusP1Data().GetType();
            textName = "Cancel Override Customer Tax Status Page 1";
        }
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CancelOverrideCustomerTaxStatusP1Data : PageData
    {
        public string remarks { get; set; } = "TestRemarks";
    }
}
