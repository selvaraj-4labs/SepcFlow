using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1SecondaryEmploymentPageSelfEmployed : Applicant1PrimaryEmploymentPageSelfEmployed
    {
        public Applicant1SecondaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1SecondaryEmploymentPageSelfEmployedData().GetType();
            textName = "Applicant 1 Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "secondaryEmploymentStatus", "Self Employed"))));
        }
    }
    public class Applicant1SecondaryEmploymentPageSelfEmployedData : Applicant1PrimaryEmploymentPageSelfEmployedData
    {
    }
}
