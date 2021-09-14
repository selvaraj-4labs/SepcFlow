using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;
using System.Globalization;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.ConfirmCustomerDeceased
{
    public class ConfirmCustomerDeceasedP1 : AppBasePage
    {
        public ConfirmCustomerDeceasedP1()
        {
            pageLoadedElement = customerNumberBox;
            correspondingDataClass = new ConfirmCustomerDeceasedP1Data().GetType();
            textName = "Confirm Customer Deceased Page 1";
        }

        // Requires a context click on the process and selected 'Confirm Customer Deceased' before journey starts.
        public Element customerNumberBox => new Element(FindElement("txtCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element customerNameBox => new Element(FindElement("txtCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element inCareHomeChbox => new Element(FindElement("chkInCareHome", attributeType: Defs.boLocatorAutomationId));
        public Element inCareDateBox => new Element(FindElement("dtInCareHomeDate", attributeType: Defs.boLocatorAutomationId));
        public Element deceasedNotificationDateLookup => new Element(FindElement("dtDeceasedNotificationDate", attributeType: Defs.boLocatorAutomationId));

        // Ownership type section not applicable to Savings.

        public Element confirmCustomerDeceasedNotificationChbox => new Element(FindElement("chkConfirmCustomerDeceased", attributeType: Defs.boLocatorAutomationId));

        public Section confirmCustomerDeceasedNotificationSection => new Section(new Element(new ConditionList()
            .Add(new Condition(confirmCustomerDeceasedNotificationChbox.locator, Defs.checkBoxSelected))));

        public Element confirmationTypeLookup => new Element(FindElement("ceConfirmationType", attributeType: Defs.boLocatorAutomationId));
        public Element actualDateOfDeathLookup => new Element(FindElement("dtActualDateOfDeath", attributeType: Defs.boLocatorAutomationId));
        public Element probateGrantedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbProbateGranted"),
                "/RadioButton[@Name=\"Yes\"][starts-with(@AutomationId,\"rbOption\")]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbProbateGranted"),
                "/RadioButton[@Name=\"No\"][starts-with(@AutomationId,\"rbOption\")]")));
        public Element dateProbateGrantedBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=dtDateProbateGranted"), "/Edit"));

        public Element repaymentPlanLookup => new Element(FindElement("ceRepaymentPlan", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd confirmCustomerDeceasedNotificationSectionEnd => new SectionEnd();

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ConfirmCustomerDeceasedP1Data : PageData
    {
        private string _dateProbateGranted = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

        public string customerNumber { get; set; } = null;
        public string customerName { get; set; } = null;
        public string inCareHome { get; set; } = null;
        public string inCareDate { get; set; } = null;
        public string deceasedNotificationDate { get; set; } = null;
        public string confirmCustomerDeceasedNotification { get; set; } = Defs.checkBoxSelected;
        public string confirmationType { get; set; } = "Death Certificate";
        public string actualDateOfDeath { get; set; } = null;
        public string probateGranted { get; set; } = Defs.radioButtonYes;
        
        // Current Date.
        public string dateProbateGranted
        {
            get
            {
                if (_dateProbateGranted == null) return null;
                else
                {
                    return Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + _dateProbateGranted.Replace("/", "");
                }
            }
            set { _dateProbateGranted = value; }
        }

        public string repaymentPlan { get; set; } = null;
    }
}
