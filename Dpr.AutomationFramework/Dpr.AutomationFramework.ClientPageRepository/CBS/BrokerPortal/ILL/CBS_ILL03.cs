using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.ILL
{
    public class CBS_ILL03 : WebBasePage
    {
        public CBS_ILL03()
        {
            pageLoadedElement = loanPurpose;
            correspondingDataClass = new CBS_ILL03Data().GetType();
            textName = "CBS Submission Details";
        }
        public Element loanPurpose => new Element(new RadioButton()
            .AddRadioButtonElement("Purchase", FindElement("LoanPurpose_0"))
            .AddRadioButtonElement("Remortgage", FindElement("LoanPurpose_1")));

        public Element estimatedValue => new Element(FindElement("OpenMarketValue", tag: "input"));
        public Element loanAmount => new Element(FindElement("txtLoanAmount"));
        public Element termRequirements => new Element(FindElement("ddlTermRequirements", tag: "select"));
        #region 'Term Requirements' Additional Section
        public Section termRequirementsSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "termRequirements", "Standard")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "termRequirements", "Both"))));
        public Element termYears => new Element(FindElement("txtLoanTerm", "!Months", tag: "input"));
        public Element termMonths => new Element(FindElement("txtLoanTermMonths", tag: "input"));
        public SectionEnd termRequirementsSectionEnd => new SectionEnd();
        #endregion
        public Element repaymentType => new Element(FindElement("ddlRepaymentType", tag: "select"));
        public Element next => new Element(FindElement("Next")).SetIsButtonFlag(true);
    }

    public class CBS_ILL03Data : PageData
    {
        public string loanPurpose { get; set; } = "Purchase";
        public string estimatedValue { get; set; } = "200000";
        public string loanAmount { get; set; } = "100000";
        public string termRequirements { get; set; } = "Standard";
        public string termYears { get; set; } = "20";
        public string termMonths { get; set; } = "0";
        public string repaymentType { get; set; } = "Capital Repayment";
    }
}
