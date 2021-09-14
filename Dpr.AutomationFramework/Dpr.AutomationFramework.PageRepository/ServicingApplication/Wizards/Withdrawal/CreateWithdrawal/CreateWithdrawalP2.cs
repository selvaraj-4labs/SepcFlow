using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal
{
    public class CreateWithdrawalP2 : AppBasePage
    {
        public CreateWithdrawalP2()
        {
            pageLoadedElement = overrideToProceed;
            correspondingDataClass = new CreateWithdrawalP2Data().GetType();
            textName = "Create Withdrawal Page 2";
        }

        public Element overrideToProceed => new Element(FindElement("cbProductOverride", attributeType: Defs.boLocatorAutomationId));

        public Element remarks => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CreateWithdrawalP2Data : PageData
    {
        public string overrideToProceed { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}
