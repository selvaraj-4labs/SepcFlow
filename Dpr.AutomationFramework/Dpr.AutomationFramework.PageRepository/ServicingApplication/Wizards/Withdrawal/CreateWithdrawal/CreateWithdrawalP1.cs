using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CreateWithdrawal
{
    public class CreateWithdrawalP1 : AppBasePage
    {
        public CreateWithdrawalP1()
        {
            pageLoadedElement = currentBalanceBox;
            correspondingDataClass = new CreateWithdrawalP1Data().GetType();
            textName = "Create Withdrawal Page 1";
        }

        // AdHoc Withdrawal
        public Element currentBalanceBox => new Element(FindElement("neCurrrentBalance", attributeType: Defs.boLocatorAutomationId));
        public Element unclearedFundsBox => new Element(FindElement("neUnclearedFunds", attributeType: Defs.boLocatorAutomationId));
        public Element availableBalanceBox => new Element(FindElement("neAvailableBalance", attributeType: Defs.boLocatorAutomationId));
        public Element noticedPeriodBox => new Element(FindElement("txtNoticePeriod", attributeType: Defs.boLocatorAutomationId));
        public Element advisedDateBox => new Element(FindElement("dteAdvisedDate", attributeType: Defs.boLocatorAutomationId));

        public Element withdrawalRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Notice of Withdrawal", FindElement("rbWithdrawalNotice", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Recurring Withdrawal", FindElement("rbRecurringWithdrawal", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Immediate Withdrawal", FindElement("rbImmedateWithdrawal", attributeType: Defs.boLocatorAutomationId)));
        public Element withdrawalDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dteWithdrawalDate"),"/Edit"));
        public Element withdrawalAmountBox => new Element(FindElement("neWithdrawalAmount", attributeType: Defs.boLocatorAutomationId));
        public Element currencyLookup => new Element(FindElement("cboCurrencyCode", attributeType: Defs.boLocatorAutomationId));
        public Element withdrawalReferenceBox => new Element(FindElement("txtWithdrawalReference", attributeType: Defs.boLocatorAutomationId));

        public Section recurringWithdrawalSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "withdrawal", "Recurring Withdrawal"))));
        public Element recurringFrequencyLookup => new Element(FindElement("cboRecurringFrequency", attributeType: Defs.boLocatorAutomationId));
        public Element withdrawalFrequencyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Number of withdrawals", FindElement("rbNumberOfWithdrawals", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Final Withdrawals Date", FindElement("rbFinalWithdrawalDate", attributeType: Defs.boLocatorAutomationId)));
        public Element numberOfWithdrawalsBox => new Element(FindElement("neNumberOfWithdrawals", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "withdrawalFrequency", "Number of withdrawals")));
        public Element finalWithdrawalDateBox => new Element(FindElement("dteFinalWithdrawal", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "withdrawalFrequency", "Final Withdrawals Date")));
        public SectionEnd recurringWithdrawalSectionEnd => new SectionEnd();

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CreateWithdrawalP1Data : PageData
    {
        private string _withdrawalDate;

        public string withdrawalDate
        {
            get
            {
                return Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight +
                    Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace +
                    Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace +
                    _withdrawalDate;
            }
            set
            {
                _withdrawalDate = value;
            }
        }
        public string withdrawal { get; set; } = "Notice of Withdrawal";
        public string withdrawalAmount { get; set; } = "500";
        public string recurringFrequency { get; set; } = "Monthly";
        public string withdrawalFrequency { get; set; } = "Number of withdrawals";
        public string numberOfWithdrawals { get; set; } = "6";
        public string remarks { get; set; } = "TestRemarks";
    }
}
