using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant2PrimaryEmploymentPageFixedTermContract : FMA_Applicant1PrimaryEmploymentPageFixedTermContract
    {
        public FMA_Applicant2PrimaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant2PrimaryEmploymentPageFixedTermContractData().GetType();
            textName = "FMA Applicant 2 Primary Employment Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_numberOfApplicants", "2"))
                .Add(new Condition("DIP_ApplicationSummaryPage", "_app2EmploymentType", "Fixed Term Contract"))));
        }
    }

    public class FMA_Applicant2PrimaryEmploymentPageFixedTermContractData : FMA_Applicant1PrimaryEmploymentPageFixedTermContractData
    {
    }
}
