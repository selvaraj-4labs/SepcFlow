using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelTaxResidencyStatus
{
    public class CancelTaxStatusUpdateRequestP1 : AppBasePage
    {
        public CancelTaxStatusUpdateRequestP1()
        {
            pageLoadedElement = remarksBox;
            correspondingDataClass = new CancelTaxResidencyStatusP1Data().GetType();
            textName = "Cancel Tax Residency Status Page 1";
        }
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CancelTaxResidencyStatusP1Data : PageData
    {
        public string remarks { get; set; } = "TestRemarks";
    }
}
