using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP2 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP2()
        {
            pageLoadedElement = setCorrespondenceAddressRbtn;
            correspondingDataClass = new CustomerInLongTermCareNotificationP2Data().GetType();
            textName = "Customer In Long Term Care Notification Page 2";
        }
        public Element setCorrespondenceAddressRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbSetAsCorrespondance"),
                "/RadioButton[@Name=\"Yes\"][starts-with(@AutomationId,\"rbOption\")]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbSetAsCorrespondance"),
                "/RadioButton[@Name=\"No\"][starts-with(@AutomationId,\"rbOption\")]")));

        public Element setResidentialAddressRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbSetAsResidential"),
                "/RadioButton[@Name=\"Yes\"][starts-with(@AutomationId,\"rbOption\")]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbSetAsResidential"),
                "/RadioButton[@Name=\"No\"][starts-with(@AutomationId,\"rbOption\")]")));

        public Element addCareHomeBtn => new Element(FindElement("btnAddCareHome", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class CustomerInLongTermCareNotificationP2Data : PageData
    {
        public string setCorrespondenceAddress { get; set; } = Defs.radioButtonNo;
        public string setResidentialAddress { get; set; } = Defs.radioButtonNo;
        public string careHomeSelect { get; set; } = Defs.checkBoxSelected;
    }
}
