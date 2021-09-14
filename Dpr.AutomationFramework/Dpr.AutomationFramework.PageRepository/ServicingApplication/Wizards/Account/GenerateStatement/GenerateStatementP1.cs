using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.GenerateStatement
{
    public class GenerateStatementP1 : AppBasePage
    {
        public GenerateStatementP1()
        {
            pageLoadedElement = dateRangeRbtn;
            correspondingDataClass = new GenerateStatementP1Data().GetType();
            textName = "Generate Statement Page 1";
        }

        public Element dateRangeRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Date Range", FindElement("rbDateRange", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Tax Year", FindElement("rbTaxYear", attributeType: Defs.boLocatorAutomationId)));

        public Section dateRangeSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "dateRange", "Date Range"))));
        public Element fromeDateBox => new Element(FindElement("dtFromDate", attributeType: Defs.boLocatorAutomationId));
        public Element toDateBox => new Element(FindElement("dtToDate", attributeType: Defs.boLocatorAutomationId));
        public SectionEnd dateRangeSectionEnd => new SectionEnd();

        public Element taxYearEndBox => new Element(FindElement("cboTaxYearEnd", attributeType: Defs.boLocatorAutomationId), new ConditionList()
            .Add(new Condition(className, "dateRange", "Tax Year")));

        public Element nextBtn => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class GenerateStatementP1Data : PageData
    {
        public string dateRange { get; set; } = "Date Range";
        public string fromDate { get; set; } = null;
        public string toDate { get; set; } = DateTime.Today.AddDays(1).ToShortDateString();
        public string taxYearEnd { get; set; } = null;
    }
}
