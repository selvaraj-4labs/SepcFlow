using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard
{
    public class UpdateCustomerRegisteredCardP1 : AppBasePage
    {
        public UpdateCustomerRegisteredCardP1()
        {
            pageLoadedElement = newOrRegisteredCardRbtn;
            correspondingDataClass = new UpdateCustomerRegisteredCardP1Data().GetType();
            textName = "Update Customer Registered Card Page 1";
        }
        public Element newOrRegisteredCardRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Add new card to be active card", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osNewOrRegisteredCard"),
                    "/RadioButton[@Name=\"Add new card to be active card\"]"))
            .AddRadioButtonElement("Add new card to be active card", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osNewOrRegisteredCard"),
                    "/RadioButton[@Name=\"Select from current card list\"]"))
            .AddRadioButtonElement("Delete Card from list", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osNewOrRegisteredCard"),
                    "/RadioButton[@Name=\"Delete Card from list\"]")));
        public Element remarksBox => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateCustomerRegisteredCardP1Data : PageData
    {
        public string newOrRegisteredCard { get; set; } = "Add new card to be active card";
        public string remarks { get; set; } = null;
    }
}
