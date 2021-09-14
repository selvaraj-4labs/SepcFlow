using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2SecondaryEmploymentPageFixedTermContract : Applicant2PrimaryEmploymentPageFixedTermContract
    {
        public Applicant2SecondaryEmploymentPageFixedTermContract()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant2SecondaryEmploymentPageFixedTermContractData().GetType();
            textName = "Applicant 2 Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))
                    .Add(new Condition("Applicant2EmploymentInitialisationPage", "secondaryEmploymentStatus", "Fixed Term Contract"))));
        }
    }

    public class Applicant2SecondaryEmploymentPageFixedTermContractData : Applicant2PrimaryEmploymentPageFixedTermContractData
    {
    }
}
