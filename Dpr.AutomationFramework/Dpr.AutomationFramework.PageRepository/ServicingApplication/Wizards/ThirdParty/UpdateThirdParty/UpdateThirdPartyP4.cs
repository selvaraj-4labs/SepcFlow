using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyP4 : AppBasePage
    {
        public UpdateThirdPartyP4()
        {
            correspondingDataClass = new UpdateThirdPartyP4Data().GetType();
            textName = "Update Third Party Page 4";
        }
        public Element effectiveDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveDate"),
            "/Edit"));
        public Element workPhoneBox => new Element(FindElement("txtPhoneWork", attributeType: Defs.boLocatorAutomationId));
        public Element homePhoneBox => new Element(FindElement("txtPhoneHome", attributeType: Defs.boLocatorAutomationId));
        public Element mobilePhoneBox => new Element(FindElement("txtMobile", attributeType: Defs.boLocatorAutomationId));
        public Element emailBox => new Element(FindElement("txtEmail", attributeType: Defs.boLocatorAutomationId));
        public Element contactPreferenceLookup => new Element(FindElement("cboContactPreference", attributeType: Defs.boLocatorAutomationId));
        public Element contactConstraintsBox => new Element(FindElement("txtContactConstraints", attributeType: Defs.boLocatorAutomationId));

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateThirdPartyP4Data : PageData
    {
        private string _effectiveDate = null;
        public string effectiveDate
        {
            get
            {
                if (_effectiveDate == null)
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
                        _effectiveDate.Replace("/", "");
                }
            }
            set
            {
                _effectiveDate = value;
            }
        }
        public string workPhone { get; set; } = null;
        public string homePhone { get; set; } = null;
        public string mobilePhone { get; set; } = null;
        public string contactPreference { get; set; } = null;
        public string contactConstraints { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }

}
