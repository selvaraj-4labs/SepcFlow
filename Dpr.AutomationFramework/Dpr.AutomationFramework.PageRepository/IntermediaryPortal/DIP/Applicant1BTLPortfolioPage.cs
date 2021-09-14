using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1BTLPortfolioPage : WebBasePage
    {
        public Applicant1BTLPortfolioPage()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new Applicant1BTLPortfolioPageData().GetType();
            textName = "Applicant 1 BTL Portfolio Page";
            //pageCondition = new PageCondition(new Element(new ConditionList()
            //        .Add(new Condition("ApplicantAndLoanTypePage", "loanType", "BTL"))));
        }
        public Element ownAnyBTLProperties => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("AnyBTLProperties_btn", "_rbl_0", tag:"input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("AnyBTLProperties_btn", "_rbl_1", tag: "input")));
        
        public Section btlPortfolioDetailsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "ownAnyBTLProperties", Defs.radioButtonYes))));

        public Element totalNumberOfProperties => new Element(FindElement("txtTotalNumberOfProperties", tag:"input"));
        public Element estimatedValueOfPortfolio => new Element(FindElement("txtEstimatedValueOfPortfolio", tag: "input"));
        public Element totalOutstandingBalanceOfMortgages => new Element(FindElement("txtTotalOutstandingBalanceOfMortgages", tag: "input"));
        public Element totalMonthlyMortgagePayments => new Element(FindElement("txtTotalMonthlyPortfolioMortgagePayments", tag: "input"));
        public Element portfolioManagedByAnAgent => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoQuestion_btn", "_rbl_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoQuestion_btn", "_rbl_1", tag: "input")));

        public SectionEnd btlPortfolioDetailsSectionEnd => new SectionEnd();
        public Element next => new Element(FindElement("Next")).SetIsButtonFlag(true);
    }
    public class Applicant1BTLPortfolioPageData : PageData
    {
        public string ownAnyBTLProperties { get; set; } = Defs.radioButtonNo;
        public string totalNumberOfProperties { get; set; } = null;
        public string estimatedValueOfPortfolio { get; set; } = null;
        public string totalOutstandingBalanceOfMortgages { get; set; } = null;
        public string totalMonthlyMortgagePayments { get; set; } = null;
        public string portfolioManagedByAnAgent { get; set; } = Defs.radioButtonNo;
    }
}
