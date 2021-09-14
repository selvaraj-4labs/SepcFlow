using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2PrimaryEmploymentPageEmployed : Applicant1PrimaryEmploymentPageEmployed
    {
        public Applicant2PrimaryEmploymentPageEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2PrimaryEmploymentPageEmployedData().GetType();
            textName = "Applicant 2 Primary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "employmentStatus", "Employed"))));
        }
    }

    public class Applicant2PrimaryEmploymentPageEmployedData : Applicant1PrimaryEmploymentPageEmployedData
    {
    }
}
