using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AddRegularDepositP1 : AppBasePage
    {
        public AddRegularDepositP1()
        {
            pageLoadedElement = amountBox;
            correspondingDataClass = new AddRegularDepositP1Data().GetType();
            textName = "Add Regular Deposit Page 1";
        }

        public Element amountBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "AddRegularDeposit"),
            "/Group[@Name=\"Details\"][@AutomationId=\"gbDetails\"]" +
            "/Edit[@AutomationId=\"neAmount\"]" +
            "/Edit"));

        public Element startDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dteStartDate"), "/Edit"));
       // public Element startDateBox => new Element(FindElement("dteStartDate", attributeType: Defs.boLocatorAutomationId));
        public Element recurringFrequencyLookup => new Element(FindElement("uceRecurringFrequency", attributeType: Defs.boLocatorAutomationId));

        public Element howManyDepositsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Number of Deposits", FindElement("rbNumDeposits", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Final Deposit Date", FindElement("rbFinalDepositDate", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("No End Date", FindElement("rbNoEndDate", attributeType: Defs.boLocatorAutomationId)));

        // Number of Deposits Rbtn condition.
        public Element numberOfDepositsBox => new Element(FindElement("neNumDeposits", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "howManyDeposits", "Number of Deposits")));

        public Element finalDepositDateLookup => new Element(FindElement("dteEndDate", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "howManyDeposits", "Final Deposit Date")));

        public Element searchParameterRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Account No", FindElement("rbLoanAccount", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Customers Account", FindElement("rbLinkedAccount", attributeType: Defs.boLocatorAutomationId)));

        public Element accountNoBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtLoanAccount"), "/Edit"),
            new ConditionList()
            .Add(new Condition(className, "searchParameter", "Account No")));

        
        public Element accountNumberSearchBtn => new Element(FindElement("gbAvailableSavingsAccount", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "searchParameter", "Account No")))
            .SetIsButtonFlag(true);

        public Element searchBtn => new Element(FindElement("btnCheck", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(className, "searchParameter", "Account No")))
            .SetIsButtonFlag(true);

        public Element productCodeBox => new Element(FindElement("utProductCode", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);
        public Element categoryBox => new Element(FindElement("utCategory", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element productTypeBox => new Element(FindElement("utProductType", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element maturityDateBox => new Element(FindElement("utMaturityDate", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element insterestCalcBox => new Element(FindElement("utInterestCalc", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element interestAppliedBox => new Element(FindElement("utInterestApplied", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element balanceBox => new Element(FindElement("utBalance", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);
        public Element balanceDateBox => new Element(FindElement("utBalanceDate", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element remarksBox => new Element(FindElement("uteRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName, tag: "Button"))
            .SetIsButtonFlag(true);

    }

    public class AddRegularDepositP1Data : PageData
    {

        public AddRegularDepositP1Data()
        {
            startDate = DateTime.Today.AddDays(7).ToString("dd/MM/yyyy");
            finalDepositDate = DateTime.Today.AddMonths(12).ToString("dd/MM/yyyy");
           
        }

        public string amount { get; set; } = "100";


        private string _startDate;
        public string startDate
        {
            get {
                if (_startDate == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                  + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace+ _startDate.Replace("/", ""); }
            set { _startDate = value; }
        }
            
        public string recurringFrequency { get; set; } = "Monthly";

        public string howManyDeposits { get; set; } = "No End Date";

        public string numberOfDeposits { get; set; } = "10";

        private string _finalDepositDate;
        public string finalDepositDate
        {       
            get {
                if (_finalDepositDate == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace 
                    + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace+ _finalDepositDate.Replace("/", ""); }
            set { _finalDepositDate = value; }
        }

        public string searchParameter { get; set; } = "Customers Account";

        public string accountNo { get; set; } = null;

        public string remarks { get; set; } = "test";

    }
}
