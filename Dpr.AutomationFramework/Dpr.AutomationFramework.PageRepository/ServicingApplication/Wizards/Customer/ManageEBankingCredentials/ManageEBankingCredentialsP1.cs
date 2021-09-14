using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ManageEBankingCredentials
{
    public class ManageEBankingCredentialsP1 : AppBasePage
    {
        public ManageEBankingCredentialsP1()
        {
            pageLoadedElement = forgottenPasswordRbtn;
            correspondingDataClass = new ManageEBankingCredentialsP1Data().GetType();
            textName = "Manage EBanking Credentials Page 1";
        }
        public Element forgottenPasswordRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Initiate password replacement process (Print Document)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Initiate password replacement process (Printed Document)"), tag: "RadioButton"))
            .AddRadioButtonElement("Initiate password replacement process (Email)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Initiate password replacement process (Email)"), tag: "RadioButton"))
            .AddRadioButtonElement("Initiate password replacement process (SMS)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Initiate password replacement process (SMS)"), tag: "RadioButton")));
        public Element forgottenUserIdRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Initiate password replacement process (Print Document)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Send Communication (Reminder Letter)"), tag: "RadioButton"))
            .AddRadioButtonElement("Initiate password replacement process (Email)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Send Communication (Email)"), tag: "RadioButton"))
            .AddRadioButtonElement("Initiate password replacement process (SMS)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Send Communication (SMS)"), tag: "RadioButton")));
        public Element eBankingAcocuntLockedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Initiate password replacement process (SMS)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Unlock Customer Account"), tag: "RadioButton")));
        public Element forgotMemorableWordRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Initiate password replacement process (SMS)", FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "Send &apos;Reset Memorable Word&apos; email to customer"), tag: "RadioButton")));
        public Element remarksBox => new Element(FindElement("remarksTextEditor", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class ManageEBankingCredentialsP1Data : PageData
    {
        public string forgottenPassword { get; set; } = "Initiate password replacement process (Email)";
        public string forgottenUserId { get; set; } = null;
        public string eBankingAcocuntLocked { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }
}
