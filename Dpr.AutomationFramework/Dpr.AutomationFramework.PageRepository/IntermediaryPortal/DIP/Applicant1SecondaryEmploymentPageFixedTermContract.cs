using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1SecondaryEmploymentPageFixedTermContract : Applicant1PrimaryEmploymentPageFixedTermContract
    {
        public Applicant1SecondaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1PrimaryEmploymentPageEmployedData().GetType();
            textName = "Applicant 1 Secondary Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "secondaryEmploymentStatus", "Fixed Term Contract"))));
        }
    }
    public class Applicant1SecondaryEmploymentPageFixedTermContractData : Applicant1PrimaryEmploymentPageFixedTermContractData
    {
    }
}
