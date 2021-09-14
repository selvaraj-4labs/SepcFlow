using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP4 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP4()
        {
            pageLoadedElement = title;
            correspondingDataClass = new CustomerInLongTermCareNotificationP4Data().GetType();
            textName = "Customer In Long Term Care Notification Page 4";
        }
        #region 'Third Party New - Personal details - Care Home' Section
        public Element title => new Element(FindElement("cboTitle", attributeType: Defs.boLocatorAutomationId));
        public Element firstName => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element middleName=> new Element(FindElement("txtMiddleName", attributeType: Defs.boLocatorAutomationId));
        public Element surname=> new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        public Element salutation => new Element(FindElement("txtSalutation", attributeType: Defs.boLocatorAutomationId));
        public Element dateOfBrith=> new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtDOBThirdParty"),
            "/Edit"));
        public Element noDOB => new Element(FindElement("chkNoDOBWanted", attributeType: Defs.boLocatorAutomationId));
        public Element idCardNumber => new Element(FindElement("txtIDCardNo", attributeType: Defs.boLocatorAutomationId));
        public Element countryOfBirth=> new Element(FindElement("cboCountryOfBirth", attributeType: Defs.boLocatorAutomationId));
        public Element placeOfBirth=> new Element(FindElement("txtPlaceOfBirth", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'Correspondence Name' Section
        public Element alternativeCorrespondenceNameBox => new Element(FindElement("gbCorrespondenceName", attributeType: Defs.boLocatorAutomationId));
        #endregion

        #region 'Nationality' Section
        public Element nationality => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboPrimaryNationality"),
            "/Edit"));
        #endregion
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CustomerInLongTermCareNotificationP4Data : PageData
    {
        private string _dateOfBrith = "10/12/1999";
        public string firstName { get; set; }
        public string surname { get; set; }

        public CustomerInLongTermCareNotificationP4Data()
        {
            string uniqueString = UniqueStringGenerator();
            firstName = "TestFName-" + uniqueString;
            surname = "TestSName-" + uniqueString;
        }

        #region 'Third Party New - Personal details - Care Home' Data Section
        public string title { get; set; } = "Mr";
        public string middleName { get; set; } = "TestMName";
        public string salutation { get; set; } = null;
        public string dateOfBrith
        {
            get
            {
                if (_dateOfBrith == null)
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
                        _dateOfBrith.Replace("/", "");
                }
            }
            set
            {
                _dateOfBrith = value;
            }
        }
        public string noDOB { get; set; } = null;
        public string idCardNumber { get; set; } = null;
        public string countryOfBirth { get; set; } = null;
        public string placeOfBirth { get; set; } = null;
        #endregion

        #region 'Correspondence Name' Section
        public string alternativeCorrespondenceName { get; set; } = null;
        #endregion

        #region 'Nationality' Section
        public string nationality { get; set; } = "British";
        #endregion
        public string remarks { get; set; } = "TestRemarks";
    }
}
