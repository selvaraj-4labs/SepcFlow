using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_Applicant2DetailsPage : FMA_Applicant1DetailsPage
    {
        public FMA_Applicant2DetailsPage()
        {
            pageLoadedElement = niNumber;
            correspondingDataClass = new FMA_Applicant2DetailsPageData().GetType();
            textName = "FMA Applicant 2 Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                    .Add(new Condition("DIP_ApplicationSummaryPage", "_numberOfApplicants", "2"))));
        }
    }

    public class FMA_Applicant2DetailsPageData : FMA_Applicant1DetailsPageData
    {
    }
}
