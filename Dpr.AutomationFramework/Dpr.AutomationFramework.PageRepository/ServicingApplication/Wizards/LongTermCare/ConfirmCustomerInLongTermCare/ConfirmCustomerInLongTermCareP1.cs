using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.ConfirmCustomerInLongTermCare
{
    public class ConfirmCustomerInLongTermCareP1 : AppBasePage
    {
        public ConfirmCustomerInLongTermCareP1()
        {
            pageLoadedElement = customerNumberBox;
            correspondingDataClass = new ConfirmCustomerInLongTermCareP1Data().GetType();
            textName = "Confirm Customer In Long Term Care Page 1";
        }
        #region 'Customer Details' Section
        public Element customerNumberBox => new Element(FindElement("txtCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element customerNameBox => new Element(FindElement("txtCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element longTermCareNotificationDateBox => new Element(FindElement("dtLongTermCareNotificationDate", attributeType: Defs.boLocatorAutomationId));
        public Element careHomeNameBox => new Element(FindElement("txtCareHomeName", attributeType: Defs.boLocatorAutomationId));
        public Element careHomeAddressBox => new Element(FindElement("txtCareHomeAddress", attributeType: Defs.boLocatorAutomationId));
        public Element correspondenceAddressChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkSetAsCorrespondenceAddress")));
        public Element reisdentialAddressChbox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkSetAsResidentialAddress")));
        #endregion

        #region 'Ownership Type' Section
        public Element ownershipTypeBox => new Element(FindElement("gbOwnershipType", attributeType: Defs.boLocatorAutomationId));
        #endregion

        public Element confirmChbox => new Element(FindElement("chkConfirmCustomerLongTermCareNotification", attributeType: Defs.boLocatorAutomationId));

        public Section confirmedSection => new Section(new Element(new ConditionList()
            .Add(new Condition(confirmChbox.locator, Defs.checkBoxSelected))));
        public Element confirmationTypeLookup => new Element(FindElement("ceConfirmationType", attributeType: Defs.boLocatorAutomationId));
        public Element inCareHomeDateBox => new Element(FindElement("dtInCareHomeDate", attributeType: Defs.boLocatorAutomationId));
        public SectionEnd confirmedSectionEnd => new SectionEnd();
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class ConfirmCustomerInLongTermCareP1Data : PageData
    {
        private string _inCareHomeDate = null;
        public string customerNumber { get; set; } = null;
        public string customerName { get; set; } = null;
        // Although a date box, it is one that will never recieve input.
        public string longTermCareNotificationDate { get; set; } = null;
        public string careHomeName { get; set; } = null;
        public string careHomeAddress { get; set; } = null;
        public string correspondenceAddress { get; set; } = Defs.checkBoxSelected;
        public string reisdentialAddress { get; set; } = Defs.checkBoxSelected;
        public string ownershipType { get; set; } = null;
        public string confirm { get; set; } = Defs.checkBoxSelected;
        public string confirmationType { get; set; } = "Doctors Letter";
        public string inCareHomeDate
        {
            get
            {
                if (_inCareHomeDate == null)
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
                        _inCareHomeDate.Replace("/", "");
                }
            }
            set
            {
                _inCareHomeDate = value;
            }
        }
    }
}
