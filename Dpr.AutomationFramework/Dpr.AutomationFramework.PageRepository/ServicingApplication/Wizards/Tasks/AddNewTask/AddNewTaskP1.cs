using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Tasks.AddNewTask
{
    public class AddNewTaskP1 : AppBasePage
    {
        public AddNewTaskP1()
        {
            pageLoadedElement = taskRbtn;
            correspondingDataClass = new AddNewTaskP1Data().GetType();
            textName = "Add New Task Page 1";
        }

        public Element taskRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Adhoc", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optTaskDetailType"),
                "/RadioButton[@Name =\"Adhoc\"]"))
            .AddRadioButtonElement("Predefined", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optTaskDetailType"),
                "/RadioButton[@Name =\"Predefined\"]")));

        public Element typeRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Work", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optTaskType"),
                "/RadioButton[@Name =\"Work\"]"))
            .AddRadioButtonElement("Call", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "optTaskType"),
                "/RadioButton[@Name =\"Call\"]")));

        public Element descriptionBox => new Element(FindElement("txtTaskDescription", attributeType: Defs.boLocatorAutomationId));
        public Element priorityLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTaskPriority"),
            "/Edit"));
        public Element customerLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTaskCustomer"),
            "/Edit"));
        public Element actionLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboTaskAction"),
            "/Edit"));
        public Element roleLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboAssignmentRole"),
            "/Edit"));
        public Element teamLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboAssignmentTeam"),
            "/Edit"));
        public Element userLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboAssignmentUser"),
            "/Edit"));
        public Element riskProfileLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboRiskProfile"),
            "/Edit"));

        public Element schedulingRbtn => new Element(new RadioButton()
        .AddRadioButtonElement("Immediate", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "optSchedulingType"),
            "/RadioButton[@Name =\"Immediate\"]"))
        .AddRadioButtonElement("Specfic Date", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "optSchedulingType"),
            "/RadioButton[@Name =\"Specific Date:\"]")));

        public Element schedulingSpecificDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtSchedulingSpecificDate"),
            "/Edit"))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "scheduling", "Specfic Date")));
        public Element schedulingSpecificTimeBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtSchedulingSpecificTime"),
            "/Edit"))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "scheduling", "Specfic Date")));


        public Element remarksBox => new Element(FindElement("gbUserRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddNewTaskP1Data : PageData
    {
        private string _schedulingSpecificDate = null;

        public string task { get; set; } = "Adhoc";
        public string type { get; set; } = "Work";
        public string description { get; set; } = "TestTask";
        public string priority { get; set; } = "Low";
        public string customer { get; set; } = null;
        public string action { get; set; } = null;
        public string role { get; set; } = "Access To All Actions";
        public string team { get; set; } = null;
        public string user { get; set; } = null;
        public string riskProfile { get; set; } = null;
        public string scheduling { get; set; } = null;
        public string schedulingSpecificDate
        {
            get
            {
                if (_schedulingSpecificDate == null)
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
                        _schedulingSpecificDate.Replace("/", "");
                }
            }
            set
            {
                _schedulingSpecificDate = value;
            }
        }
        public string remarks { get; set; } = "TestRemarks";
    }
}
