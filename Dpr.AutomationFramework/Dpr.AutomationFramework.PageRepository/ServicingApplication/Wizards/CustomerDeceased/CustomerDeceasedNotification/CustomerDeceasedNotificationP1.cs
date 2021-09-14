using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CustomerDeceasedNotification
{
    public class CustomerDeceasedNotificationP1 : AppBasePage
    {
        public CustomerDeceasedNotificationP1()
        {
            pageLoadedElement = customerNumberBox;
            correspondingDataClass = new CustomerDeceasedNotificationP1Data().GetType();
            textName = "Customer Deceased Notification Page 1";
        }

        public Element customerNumberBox => new Element(FindElement("txtCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element customerNameBox => new Element(FindElement("txtCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element inCareHomeChbox => new Element(FindElement("chkInCareHome", attributeType: Defs.boLocatorAutomationId));
        public Element inCareDateBox => new Element(FindElement("dtInCareHomeDate", attributeType: Defs.boLocatorAutomationId));
        public Element notificationDateBox => new Element(FindElement("dtNotificationDate", attributeType: Defs.boLocatorAutomationId));
        public Element probateGrantedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbProbateGranted")
                .Add(Defs.boLocatorName, "Yes")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbProbateGranted")
                .Add(Defs.boLocatorName, "No"))));
        public Element dateProbateGrantedBox => new Element(FindElement("dtDateProbateGranted", attributeType: Defs.boLocatorAutomationId));
        public Element repaymentPlanLookup => new Element(FindElement("ceRepaymentPlan", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CustomerDeceasedNotificationP1Data : PageData
    {
        private string _notificationDate = null;
        private string _dateProbateGranted = null;

        public string customerNumber { get; set; } = null;
        public string customerName { get; set; } = null;
        public string inCareHome { get; set; } = null;
        public string notificationDate
        {
            get
            {
                if (_notificationDate == null)
                {
                    return null;
                }
                else
                {
                    return 
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _notificationDate.Replace("/", "");
                }
            }
            set
            {
                _notificationDate = value;
            }
        }
        public string probateGranted = null;
        public string dateProbateGranted
        {
            get
            {
                if (_dateProbateGranted == null)
                {
                    return null;
                }
                else
                {
                    return
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _dateProbateGranted.Replace("/", "");
                }
            }
            set
            {
                _dateProbateGranted = value;
            }
        }
        public string repaymentPlan { get; set; } = "Savings";
        public string remarks { get; set; } = "TestRemarks";
    }
}
