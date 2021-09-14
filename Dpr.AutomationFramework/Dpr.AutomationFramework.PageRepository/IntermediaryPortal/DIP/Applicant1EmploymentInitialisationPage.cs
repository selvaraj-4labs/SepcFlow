using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1EmploymentInitialisationPage : WebBasePage
    {
        public Applicant1EmploymentInitialisationPage()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new Applicant1EmploymentInitialisationPageData().GetType();
            textName = "Applicant 1 Employment Initialisation Page";
        }

        #region 'Primary Employment status' Section
        public Element employmentStatus => new Element(FindElement("ctl01_pnlApplicantPanel_ctl00_EmploymentType", tag: "select"));
        
        public Element percentageShareOwner => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl01_pnlApplicantPanel_ctl00_IsShareholding_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl01_pnlApplicantPanel_ctl00_IsShareholding_btn_rbl_1")),
            new ConditionList()
            .Add(new Condition(className, "employmentStatus", "Employed")));

        #endregion

        #region 'Secondary Employment status' Section

        public Section secondaryEmploymentSection => new Section(new Element(new ConditionList()
                .Add(new Condition(className, "employmentStatus", "Employed")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "employmentStatus", "Self Employed")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "employmentStatus", "Fixed Term Contract"))));

        public Element secondaryEmployment => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl04_FactfindList_ctl00_ctl00_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl04_FactfindList_ctl00_ctl00_rbl_1", tag: "input")));

        public Element secondaryEmploymentStatus => new Element(FindElement("ctl02_pnlApplicantPanel_ctl00_EmploymentType", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "secondaryEmployment", Defs.radioButtonYes)));

        public Element secondaryPercentageShareOwner => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl02_pnlApplicantPanel_ctl00_IsShareholding_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl02_pnlApplicantPanel_ctl00_IsShareholding_btn_rbl_1", tag: "input")),
            new ConditionList()
                .Add(new Condition(className, "secondaryEmploymentStatus", "Employed")));

        public SectionEnd secondaryEmploymentSectionEnd => new SectionEnd();
        #endregion

        #region 'Other sources of income' Section
        public Element otherSourcesOfIncome => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_ctl00_FactfindList_ctl00_ctl00_rbl_1", tag: "input")));
        #endregion

        #region 'Income changes' Section
        public Element incomeChanges => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl03_FactfindList_ctl00_ctl00_rdoQuestion_btn_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl03_FactfindList_ctl00_ctl00_rdoQuestion_btn_rbl_1", tag: "input")));

        public Element incomeChangesDetails => new Element(FindElement("txtFurtherDetails", tag: "input"),
            new ConditionList()
            .Add(new Condition(className, "incomeChanges", Defs.radioButtonYes)));
        #endregion

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class Applicant1EmploymentInitialisationPageData : PageData
    {
        public string employmentStatus { get; set; } = "Employed";
        public string percentageShareOwner { get; set; } = Defs.radioButtonNo;

        public string secondaryEmployment { get; set; } = Defs.radioButtonNo;
        public string secondaryEmploymentStatus { get; set; } = null;
        public string secondaryPercentageShareOwner { get; set; } = Defs.radioButtonNo;

        public string otherSourcesOfIncome { get; set; } = Defs.radioButtonNo;

        public string incomeChanges { get; set; } = Defs.radioButtonNo;

        public string incomeChangesDetails { get; set; } = "Automation Additional Details";
    }
}
