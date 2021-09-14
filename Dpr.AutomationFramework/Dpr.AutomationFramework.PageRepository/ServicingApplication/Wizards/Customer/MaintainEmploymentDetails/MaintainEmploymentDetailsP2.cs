using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP2 : AppBasePage
    {
        public MaintainEmploymentDetailsP2()
        {
            pageLoadedElement = employmentTypeLookup;
            correspondingDataClass = new MaintainEmploymentDetailsP2Data().GetType();
            textName = "Maintain Employment Details Page 2";
        }
        public Element employmentTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboEmploymentType"),
            "/Edit"));
        public Element fromBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtFrom"),
            "/Edit"));
        public Element toBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtTo"), 
            "/Edit"));
        public Element isCurrentRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optIsCurrent"), "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optIsCurrent"), "/RadioButton[@Name='No']")));
        public Element isPrimaryJobRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optIsPrimaryJob"), "/RadioButton[@Name='Yes']"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optIsPrimaryJob"), "/RadioButton[@Name='No']")));
        public Element tempEndDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtTempEndDate"), "/Edit"));
        public Element yearsBox => new Element(FindElement("txtYears", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);
        public Element monthsBox => new Element(FindElement("txtMonths", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class MaintainEmploymentDetailsP2Data : PageData
    {

        private string _from = "01/01/2010";
        public string from
        {
            get
            {
                if (_from == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                      + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + _from.Replace("/", "");
            }
            set { _from = value; }
        }

        private string _to = null;
        public string to
        {
            get
            {
                if (_to == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                      + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + _to.Replace("/", "");
            }
            set { _to = value; }
        }

        public string employmentType { get; set; } = null;
        

        public string isCurrent { get; set; } = Defs.radioButtonYes;
        public string isPrimaryJob { get; set; } = Defs.radioButtonYes;
   

        private string _tempEndDate = null;
        public string tempEndDate
        {
            get
            {
                if (_tempEndDate == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                      + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + _tempEndDate.Replace("/", "");
            }
            set { _tempEndDate = value; }
        }

    }
}
