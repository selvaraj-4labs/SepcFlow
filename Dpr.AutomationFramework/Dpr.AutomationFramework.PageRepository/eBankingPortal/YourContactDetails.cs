using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class YourContactDetails : WebBasePage
    {
        public YourContactDetails()
        {
            pageLoadedElement = homePhone;
            correspondingDataClass = new YourContactDetailsData().GetType();
            textName = "EBanking Your Contact Details";
        }
        public Element homePhone => new Element(FindElement("OptionalHomeTelephoneNo"));
        public Element workPhone => new Element(FindElement("WorkTelephoneNo"));
        public Element email => new Element(FindElement("EmailAddress", "!Confirm"));
        //public Element confirmEmail => new Element(FindElement("ConfirmEmailAddress"));
        public Element preferredContactMethod => new Element(new RadioButton()
            .AddRadioButtonElement("Home phone", FindElement("PreferredContactMethod_HomePhone"))
            .AddRadioButtonElement("Mobile phone", FindElement("PreferredContactMethod_MobilePhone"))
            .AddRadioButtonElement("Work phone", FindElement("PreferredContactMethod_WorkPhone")));
        public Element contactConstraints => new Element(FindElement("ContactConstraints"));
        public Element contactMeByPhone => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement("CanContactByPhone_Yes"))
            .AddRadioButtonElement("No", FindElement("CanContactByPhone_No")));
        public Element contactMeByPost => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement("CanContactByPost_Yes"))
            .AddRadioButtonElement("No", FindElement("CanContactByPost_No")));
        public Element contactMeByEmail => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement("CanContactByEmail_Yes"))
            .AddRadioButtonElement("No", FindElement("CanContactByEmail_No")));
        public Element contactMeBySms => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement("CanContactBySMS_Yes"))
            .AddRadioButtonElement("No", FindElement("CanContactBySMS_No")));
        public Element submit => new Element(FindElement("Submit", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true);
    }

    public class YourContactDetailsData : PageData
    {
        public string homePhone { set; get; } = null;
        public string workPhone { set; get; } = null;
        public string email { set; get; } = null;
        //public string confirmEmail { set; get; } = null;
        public string preferredContactMethod { set; get; } = null;
        public string contactConstraints { set; get; } = null;
        public string contactMeByPhone { set; get; } = null;
        public string contactMeByPost { set; get; } = null;
        public string  contactMeByEmail { set; get; } = null;
        public string contactMeBySms { set; get; } = null;
    }
}
