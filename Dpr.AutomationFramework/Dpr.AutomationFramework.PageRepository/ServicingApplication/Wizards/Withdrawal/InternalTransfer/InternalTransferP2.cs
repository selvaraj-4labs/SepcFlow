using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer
{
    public class InternalTransferP2 : AppBasePage
    {
        public InternalTransferP2()
        {
            pageLoadedElement = overrideToProceed;
            correspondingDataClass = new InternalTransferP2Data().GetType();
            textName = "Internal Transfer Page 2";
        }
        public Element overrideToProceed => new Element(FindElement("cbProductOverride", attributeType: Defs.boLocatorAutomationId));

        public Element remarks => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class InternalTransferP2Data : PageData
    {
        public string overrideToProceed { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}
