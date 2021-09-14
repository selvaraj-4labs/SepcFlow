using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2SecondaryEmploymentPageEmployed : Applicant2PrimaryEmploymentPageEmployed
    {
        public Applicant2SecondaryEmploymentPageEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2SecondaryEmploymentPageEmployedData().GetType();
            textName = "Applicant 2 Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "secondaryEmploymentStatus", "Employed"))));
        }
    }
    public class Applicant2SecondaryEmploymentPageEmployedData : Applicant2PrimaryEmploymentPageEmployedData
    {
    }
}
