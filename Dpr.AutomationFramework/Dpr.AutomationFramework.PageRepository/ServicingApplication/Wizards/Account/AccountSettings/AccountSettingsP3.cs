using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AccountSettingsP3 : AppBasePage
    {
        public AccountSettingsP3()
        {
            pageLoadedElement = loanSegmentsSelectAll;
            correspondingDataClass = new AccountSettingsP3Data().GetType();
            textName = "Account Settings Page 3";
        }

        public Element loanSegmentsSelectAll => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=chkSelectAllLoanSegments")));

        public Element forecastMaturityDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=dtForecastMaturityDate"), "/Edit"));

        public Element update => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=btnUpdateForecastMaturityDate")), new ConditionList()
            .Add(new Condition(className, "forecastMaturityDate", null, Defs.conditionTypeNotEqual)))
            .SetIsButtonFlag(true);

        public Element loanAdvancesSelectAll => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=chkSelectAllAdvances")));

        public Element securitisationCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtSecuritisationCode"), "/Edit"));



        public Element updateSecuritisationCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=btnUpdateSecuritisationCode")), new ConditionList()
            .Add(new Condition(className, "securitisationCode", null, Defs.conditionTypeNotEqual)))
            .SetIsButtonFlag(true);

        public Element next => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Next"), tag: "Button"))
            .SetIsButtonFlag(true);



    }

    public class AccountSettingsP3Data : PageData
    {
        private string _forecastMaturityDate = null;
        public string forecastMaturityDate
        {
            get
            {
                if (_forecastMaturityDate == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                      + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + _forecastMaturityDate.Replace("/", "");
            }
            set { _forecastMaturityDate = value; } 
        }

        public string securitisationCode { set; get; } = null;

        public string loanSegmentsSelectAll { set; get; } = null;

        public string loanAdvancesSelectAll { set; get; } = null;


    }
}
