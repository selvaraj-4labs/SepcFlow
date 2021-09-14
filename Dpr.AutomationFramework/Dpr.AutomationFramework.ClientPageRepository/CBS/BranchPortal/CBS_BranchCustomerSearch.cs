using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal
{
    public class CBS_BranchCustomerSearch : WebBasePage
    {
        public CBS_BranchCustomerSearch()
        {
            pageLoadedElement = applicantsExisitingCustomers;
            correspondingDataClass = new CBS_BranchCustomerSearchData().GetType();
            textName = "CBS Branch Customer Search Page";
        }

        #region 'Customer Type' Section
        public Element applicantsExisitingCustomers => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl01_ExistingApplicantYesNo_btn_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl01_ExistingApplicantYesNo_btn_rbl_1")));

        public Element applicantType => new Element(FindElement("ctl01_ddlApplicantType", tag: "select"));
        #endregion

        #region 'Application Type' Section
        public Element beingAppliedFor => new Element(FindElement("ctl01_cboApplicationType", tag: "select"),
            new ConditionList()
                .Add(new Condition(className, "applicantsExisitingCustomers", Defs.radioButtonNo)));
        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_BranchCustomerSearchData : PageData
    {
        #region 'Customer Type' Data Section
        public string applicantsExisitingCustomers { get; set; } = Defs.radioButtonNo;
        public string applicantType { get; set; } = "Individual";
        #endregion

        #region 'Application Type' Data Section
        public string beingAppliedFor { get; set; } = "Mortgage";
        #endregion
    }
}
