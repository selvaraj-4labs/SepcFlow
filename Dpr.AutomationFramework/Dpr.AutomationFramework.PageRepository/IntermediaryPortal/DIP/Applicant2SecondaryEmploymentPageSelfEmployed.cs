using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2SecondaryEmploymentPageSelfEmployed : Applicant2PrimaryEmploymentPageSelfEmployed
    {
        public Applicant2SecondaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2SecondaryEmploymentPageSelfEmployedData().GetType();
            textName = "Applicant 2 Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "secondaryEmploymentStatus", "Self Employed"))));
        }
    }
    public class Applicant2SecondaryEmploymentPageSelfEmployedData : Applicant2PrimaryEmploymentPageSelfEmployedData
    {
    }
}
