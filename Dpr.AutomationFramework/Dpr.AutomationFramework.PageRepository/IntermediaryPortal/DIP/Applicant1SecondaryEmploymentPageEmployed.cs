using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1SecondaryEmploymentPageEmployed : Applicant1PrimaryEmploymentPageEmployed
    {
        public Applicant1SecondaryEmploymentPageEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1SecondaryEmploymentPageEmployedData().GetType();
            textName = "Applicant 1 Secondary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "secondaryEmploymentStatus", "Employed"))));
        }
    }
    public class Applicant1SecondaryEmploymentPageEmployedData : Applicant1PrimaryEmploymentPageEmployedData
    {
    }
}
