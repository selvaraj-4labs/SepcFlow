using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard
{
    public class UpdateCustomerRegisteredCardP2 : AppBasePage
    {
        public UpdateCustomerRegisteredCardP2()
        {
            pageLoadedElement = callRecordingOffChbox;
            correspondingDataClass = new UpdateCustomerRegisteredCardP2Data().GetType();
            textName = "Update Customer Registered Card Page 2";
        }
        public Element callRecordingOffChbox => new Element(FindElement("cbCallRecOffMessage", attributeType: Defs.boLocatorAutomationId));

        #region 'Card Details' Section

        public Section cardDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(callRecordingOffChbox.locator, Defs.checkBoxSelected))));

        public Element paymentCardTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cardTypeList"),
            "/Edit"));
        public Element nameOnCardBox => new Element(FindElement("nameOnCard", attributeType: Defs.boLocatorAutomationId));
        public Element cardNumber1Box => new Element(FindElement("cardNumber1", attributeType: Defs.boLocatorAutomationId));
        public Element cardNumber2Box => new Element(FindElement("cardNumber2", attributeType: Defs.boLocatorAutomationId));
        public Element cardNumber3Box => new Element(FindElement("cardNumber3", attributeType: Defs.boLocatorAutomationId));
        public Element cardNumber4Box => new Element(FindElement("cardNumber4", attributeType: Defs.boLocatorAutomationId));
        public Element cardNumber5Box => new Element(FindElement("cardNumber5", attributeType: Defs.boLocatorAutomationId));
        public Element securityCodeBox => new Element(FindElement("securityCode", attributeType: Defs.boLocatorAutomationId));
        public Element startDateMonthBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "startMonthList"),
            "/Edit"));
        public Element startDateYearBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "startYearList"),
            "/Edit"));
        public Element endDateMonthBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "endMonthList"),
            "/Edit"));
        public Element endDateYearBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "endYearList"),
            "/Edit"));
        public Element customerDefaultCardChbox => new Element(FindElement("chkMakeDefaultCard", attributeType: Defs.boLocatorAutomationId));

        public SectionEnd cardDetailsSectionEnd => new SectionEnd();

        #endregion

        public Element callRecordingOnChbox => new Element(FindElement("cbCallRecOffMessage", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateCustomerRegisteredCardP2Data : PageData
    {
        public string callRecordingOff { get; set; } = Defs.checkBoxSelected;
        public string paymentCardType { get; set; } = "Mastercard";
        public string nameOnCard { get; set; } = "TestCard";
        public string cardNumber1 { get; set; } = "1111";
        public string cardNumber2 { get; set; } = "1111";
        public string cardNumber3 { get; set; } = "1111";
        public string cardNumber4 { get; set; } = "1111";
        public string cardNumber5 { get; set; } = "1111";
        public string securityCode { get; set; } = "156";
        public string startDateMonth { get; set; } = "05";
        public string startDateYear { get; set; } = "2020";
        public string endDateMonth{ get; set; } = "05";
        public string endDateYear { get; set; } = "2023";
        public string customerDefaultCard { get; set; } = Defs.checkBoxSelected;
        public string callRecordingOn { get; set; } = Defs.controlTypeCheckbox;
    }
}
