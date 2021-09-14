using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2PrimaryEmploymentPageFixedTermContract : Applicant1PrimaryEmploymentPageFixedTermContract
    {
        public Applicant2PrimaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2PrimaryEmploymentPageFixedTermContractData().GetType();
            textName = "Applicant 2 Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "employmentStatus", "Fixed Term Contract"))));
        }
    }
    public class Applicant2PrimaryEmploymentPageFixedTermContractData : Applicant1PrimaryEmploymentPageFixedTermContractData
    {
    }
}
