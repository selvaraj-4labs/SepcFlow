using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP1 : AppBasePage
    {
        public UpdateCustomerPreferencesP1()
        {
            pageLoadedElement = effectiveDateBox;
            correspondingDataClass = new UpdateCustomerPreferencesP1Data().GetType();
            textName = "Update Customer Prefernces Page 1";
        }

        #region 'Contact Details' Section
        public Element effectiveDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveDate"),
            "/ComboBox/Edit[@Name=\"Text area\"]"));
        public Element workPhoneBox => new Element(FindElement("txtPhoneWork", attributeType: Defs.boLocatorAutomationId));
        public Element homePhoneBox => new Element(FindElement("txtPhoneHome", attributeType: Defs.boLocatorAutomationId));
        public Element mobileBox => new Element(FindElement("txtMobile", attributeType: Defs.boLocatorAutomationId));
        public Element emailBox => new Element(FindElement("txtEmail", attributeType: Defs.boLocatorAutomationId));
        public Element contactPreferenceLookup => new Element(FindElement("cboContactPreference", attributeType: Defs.boLocatorAutomationId));
        public Element contactConstraintsBox => new Element(FindElement("txtContactConstraints", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'Customer Address' Section

        // Temp.
        public Element editButtonGroup => new Element(new ButtonGroup()
            .AddButtonElement("Edit", FindElement("btnEdit", attributeType: Defs.boLocatorAutomationId))
            .AddButtonElement("No Edit", FindElement("WizardTitle", attributeType: Defs.boLocatorAutomationId)));
        #endregion

        #region 'Security Information' Section
        public Element callOutPassword => new Element(FindElement("txtCallOutPassword", attributeType: Defs.boLocatorAutomationId));
        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateCustomerPreferencesP1Data : PageData
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
        public string mobile { get; set; } = null;
        public string email { get; set; } = null;
        public string contactPreference { get; set; } = null;
        public string contactConstraints { get; set; } = null;
        
        public string editButtonGroup { get; set; } = "No Edit";



        public string callOutPassword { get; set; } = null;
    }
}