using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant2PrimaryEmploymentPageSelfEmployed : FMA_Applicant1PrimaryEmploymentPageSelfEmployed
    {
        public FMA_Applicant2PrimaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant2PrimaryEmploymentPageSelfEmployedData().GetType();
            textName = "FMA Applicant 2 Primary Employment Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_numberOfApplicants", "2"))
                .Add(new Condition("DIP_ApplicationSummaryPage", "_app2EmploymentType", "Self Employed"))));
        }
    }

    public class FMA_Applicant2PrimaryEmploymentPageSelfEmployedData : FMA_Applicant1PrimaryEmploymentPageSelfEmployedData
    {
    }
}
