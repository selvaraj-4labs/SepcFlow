using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class HouseholdExpenditurePage : WebBasePage
    {
        public HouseholdExpenditurePage()
        {
            pageLoadedElement = numbeOfNonApplicantAdultDependents;
            correspondingDataClass = new HouseholdExpenditurePageData().GetType();
            textName = "Household Expenditure Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                    .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "Residential"))));

            /*.AddNewConditionList(new ConditionList()
    .Add(new Condition("ApplicantAndLoanTypePage", "applicantType", "Individual")*/
        }

        #region Household details for all applicants

        public Element numberOfHouseholds => new Element(FindElement("ctl01_FactfindList", tag:"select"));
            
            /* Condition removed 22062020
             * new ConditionList()
            .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL")*/
        
        #endregion

        #region Dependants section locators

        public Element numbeOfNonApplicantAdultDependents => new Element(FindElement("cboNoOfAdultDependants", tag: "select"));

        public Element numberOfChildDependents => new Element(FindElement("cboNoOfDependants", tag: "select"));

        #endregion


        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }


    public class HouseholdExpenditurePageData : PageData
    {
        public string numberOfHouseholds { get; set; } = "1";
        public string numbeOfNonApplicantAdultDependents { get; set; } = "0";
        public string numberOfChildDependents { get; set; } = "0";


    }
}
