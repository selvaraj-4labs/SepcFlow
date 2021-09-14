using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CancelWithdrawal
{
    public class CancelWithdrawalP1 : AppBasePage
    {
        public CancelWithdrawalP1()
        {
            pageLoadedElement = cancelThisWithdrawal;
            correspondingDataClass = new CancelWithdrawalP1Data().GetType();
            textName = "Cancel Withdrawal P1";
        }

        public Element cancelThisWithdrawal => new Element(FindElement("ckbCancel", attributeType: Defs.boLocatorAutomationId, tag: "CheckBox"));

        public Element reason => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=ceReason"),
            "/Edit"));

        public Element remarks => new Element(FindElement("=txtRemarks", attributeType: Defs.boLocatorAutomationId, tag: "Edit"));

        public Element confirmBtn => new Element(FindElement("=Confirm", attributeType: Defs.boLocatorName, tag: "Button"))
            .SetIsButtonFlag(true);



    }

    public class CancelWithdrawalP1Data : PageData
    {
        public string cancelThisWithdrawal {set;get;} = Defs.checkBoxSelected;
        public string reason { set; get; } = "Customer Request";
        public string remarks { set; get; } = "Test Remarks";
    }
}
