using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP5 : AppBasePage
    {
        public AddNewThirdPartyP5()
        {
            pageLoadedElement = workPhoneBox;
            correspondingDataClass = new AddNewThirdPartyP5Data().GetType();
            textName = "Add New Third Party Page 5";
        }

        public Element workPhoneBox => new Element(FindElement("txtPhoneWork", attributeType: Defs.boLocatorAutomationId));
        public Element homePhoneBox => new Element(FindElement("txtPhoneHome", attributeType: Defs.boLocatorAutomationId));
        public Element mobilePhoneBox => new Element(FindElement("txtMobile", attributeType: Defs.boLocatorAutomationId));
        public Element emailBox => new Element(FindElement("txtEmail", attributeType: Defs.boLocatorAutomationId));
        public Element contactPreferenceLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboContactPreference"),
            "/Edit"));
        public Element contactConstraintsBox => new Element(FindElement("txtContactConstraints", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewThirdPartyP5Data : PageData
    {
        public string mobilePhone { get; set; } = "0177000000";
        public string contactPreference { get; set; } = "Mobile Phone";
    }
}
