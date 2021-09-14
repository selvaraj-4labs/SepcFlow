using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant2PrimaryEmploymentDetailsPage : FMA_Applicant1PrimaryEmploymentDetailsPage
    {
        public FMA_Applicant2PrimaryEmploymentDetailsPage()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new FMA_Applicant2PrimaryEmploymentDetailsPageData().GetType();
            textName = "FMA Applicant 2 Primary Employment Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_numberOfApplicants", "2"))));
        }
    }

    public class FMA_Applicant2PrimaryEmploymentDetailsPageData : FMA_Applicant1PrimaryEmploymentDetailsPageData
    {
    }
}
