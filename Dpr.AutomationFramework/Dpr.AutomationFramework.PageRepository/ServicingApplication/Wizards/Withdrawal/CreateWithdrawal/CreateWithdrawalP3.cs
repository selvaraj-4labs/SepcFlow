using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal
{
    public class CreateWithdrawalP3 : AppBasePage
    {
        public CreateWithdrawalP3()
        {
            pageLoadedElement = withdrawalDateBox;
            correspondingDataClass = new CreateWithdrawalP3Data().GetType();
            textName = "Create Withdrawal Page 3";
        }

        public Element withdrawalDateBox => new Element(FindElement("dteWithdrawal", attributeType: Defs.boLocatorAutomationId));
        public Element finalDateBox => new Element(FindElement("dteFinalWithdrawal", attributeType: Defs.boLocatorAutomationId));
        public Element withdrawalAmountBox => new Element(FindElement("neWithdrawalAmount", attributeType: Defs.boLocatorAutomationId));
        public Element numberOfWithdrawalsBox => new Element(FindElement("neNumberOfWithdrawals", attributeType: Defs.boLocatorAutomationId));
        public Element recurringFrequencyLookup => new Element(FindElement("cboRecurringFrequency", attributeType: Defs.boLocatorAutomationId));

        // Other lookups not coded for.
        public Element paymentMethodLookup => new Element(FindElement("cePaymentMethod", attributeType: Defs.boLocatorAutomationId));
        public Element payeeBox => new Element(FindElement("txtPayee", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CreateWithdrawalP3Data : PageData
    {
        public string paymentMethod { get; set; } = "Cheque";
        public string payee { get; set; } = "TestPayee";
    }
}
