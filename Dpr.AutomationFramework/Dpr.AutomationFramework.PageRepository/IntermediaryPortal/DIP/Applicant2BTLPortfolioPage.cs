using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2BTLPortfolioPage : Applicant1BTLPortfolioPage
    {
        public Applicant2BTLPortfolioPage()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new Applicant2BTLPortfolioPageData().GetType();
            textName = "Applicant 2 BTL Portfolio Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }
    }
    public class Applicant2BTLPortfolioPageData : Applicant1BTLPortfolioPageData
    {
    }
}
