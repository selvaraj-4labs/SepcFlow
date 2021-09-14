using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2PrimaryEmploymentPageSelfEmployed : Applicant1PrimaryEmploymentPageSelfEmployed
    {
        public Applicant2PrimaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2PrimaryEmploymentPageSelfEmployedData().GetType();
            textName = "Applicant 2 Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "employmentStatus", "Self Employed"))));
        }
    }
    public class Applicant2PrimaryEmploymentPageSelfEmployedData : Applicant1PrimaryEmploymentPageSelfEmployedData
    {
    }
}
