using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP13 : WebBasePage
    {
        public CBS_DIP13()
        {
            pageLoadedElement = numbeOfNonApplicantAdultDependents;
            correspondingDataClass = new CBS_DIP13Data().GetType();
            textName = "CBS Household Expenditure Page";
            //pageCondition = new PageCondition(new Element(new ConditionList()
            //        .Add(new Condition("CBS_DIP02", "loanType", "Residential"))));
        }
        #region Household details for all applicants

        public Element numberOfHouseholds => new Element(FindElement("ctl01_FactfindList", tag: "select"));

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

    public class CBS_DIP13Data : PageData
    {
        public string numberOfHouseholds { get; set; } = "1";
        public string numbeOfNonApplicantAdultDependents { get; set; } = "0";
        public string numberOfChildDependents { get; set; } = "0";
    }
}
