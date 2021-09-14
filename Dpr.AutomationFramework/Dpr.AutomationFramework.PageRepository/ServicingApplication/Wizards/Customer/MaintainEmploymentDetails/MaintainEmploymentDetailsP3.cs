using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP3 : AppBasePage
    {
        public MaintainEmploymentDetailsP3()
        {
            pageLoadedElement = jobTitleBox;
            correspondingDataClass = new MaintainEmploymentDetailsP3Data().GetType();
            textName = "Maintain Employment Details Page 3";
        }
        public Element jobTitleBox => new Element(FindElement("txtJobTitle", attributeType: Defs.boLocatorAutomationId));
        public Element probationPeriodRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optProbationPeriod"),"/RadioButton[@Name='Yes']"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optProbationPeriod"), "/RadioButton[@Name='No']")));
        public Element probationEndDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtProbationEndDate"),
            "/Edit")); 
        public Element payrollStaffNumberBox => new Element(FindElement("txtPayrollStaffNumber", attributeType: Defs.boLocatorAutomationId)); 
        public Element employmentStatusLookup => new Element(FindElement("cboEmploymentStatus", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class MaintainEmploymentDetailsP3Data : PageData
    {
        public string jobTitle { get; set; } = null;
        public string probationPeriod { get; set; } = Defs.radioButtonNo;
        public string employmentStatus { get; set; } = "Employed";
        public string probationEndDate { get; set; } = null;
        public string payrollStaffNumber { get; set; } = null;

    }
}
