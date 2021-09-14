using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant2PrimaryEmploymentPageEmployed : FMA_Applicant1PrimaryEmploymentPageEmployed
    {
        public FMA_Applicant2PrimaryEmploymentPageEmployed()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant2PrimaryEmploymentPageEmployedData().GetType();
            textName = "FMA Applicant 2 Primary Employment Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_numberOfApplicants", "2"))
                .Add(new Condition("DIP_ApplicationSummaryPage", "_app2EmploymentType", "Employed"))));
        }
    }

    public class FMA_Applicant2PrimaryEmploymentPageEmployedData : FMA_Applicant1PrimaryEmploymentPageEmployedData
    {
    }
}
