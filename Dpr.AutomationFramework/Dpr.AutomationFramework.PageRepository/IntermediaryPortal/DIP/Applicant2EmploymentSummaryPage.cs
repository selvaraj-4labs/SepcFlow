using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2EmploymentSummaryPage : Applicant1EmploymentSummaryPage
    {

        public Applicant2EmploymentSummaryPage()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new Applicant2EmploymentSummaryPageData().GetType();
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }

    }


    public class Applicant2EmploymentSummaryPageData : Applicant1EmploymentSummaryPageData
    {
    }
}
