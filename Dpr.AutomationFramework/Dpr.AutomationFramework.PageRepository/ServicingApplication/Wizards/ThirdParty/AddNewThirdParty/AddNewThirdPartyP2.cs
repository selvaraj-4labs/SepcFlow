using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP2 : AppBasePage
    {
        public AddNewThirdPartyP2()
        {
            pageLoadedElement = thirdPartyType;
            correspondingDataClass = new AddNewThirdPartyP2Data().GetType();
            textName = "Add New Third Party Page 2";
        }

        public Element thirdPartyType=> new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboGroupName"),
            "/Edit"));

        public Element actingFor => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboActingForParty"), 
            "/Edit"));

        public Element isControllingAuthority=> new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsControllingAuthority"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsControllingAuthority"),
                "/RadioButton[@Name=\"No\"]")));

        public Element isProspective=> new Element(FindElement("chklblIsProspective", attributeType: Defs.boLocatorAutomationId));

        public Element effectiveDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveDate"),
            "/Edit"));

        public Element notificationDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtNotificationDate"),
            "/Edit"));

        public Element endDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEndDate"),
            "/Edit"));

        public Element registrationDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtRegistrationDate"),
            "/Edit"));

        public Element referenceNumberBox => new Element(FindElement("txtReferenceNumber", attributeType: Defs.boLocatorAutomationId));

        public Element specialInstructionsBox => new Element(FindElement("txtSpecialInstructions", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class AddNewThirdPartyP2Data : PageData
    {
        private string _effectiveDate = DateTime.Today.ToString("dd/MM/yyyy");
        private string _notificationDate = DateTime.Today.ToString("dd/MM/yyyy");
        private string _registrationDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
        private string _endDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");

        public string thirdPartyType { get; set; } = "Representative";
        public string actingFor { get; set; } = "Customer";
        public string isControllingAuthority { get; set; } = Defs.radioButtonNo;
        
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

        public string notificationDate
        {
            get
            {
                if (_notificationDate == null)
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
                        _notificationDate.Replace("/", "");
                }
            }
            set
            {
                _notificationDate = value;
            }
        }

        public string endDate
        {
            get
            {
                if (_endDate == null)
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
                        _endDate.Replace("/", "");
                }
            }
            set
            {
                _endDate = value;
            }
        }

        public string registrationDate
        {
            get
            {
                if (_registrationDate == null)
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
                        _registrationDate.Replace("/", "");
                }
            }
            set
            {
                _registrationDate = value;
            }
        }

        public string registrationNumber { get; set; } = "1147";
    }
}
