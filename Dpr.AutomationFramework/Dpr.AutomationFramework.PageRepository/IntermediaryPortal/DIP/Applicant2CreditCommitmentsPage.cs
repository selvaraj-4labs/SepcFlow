using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2CreditCommitmentsPage : Applicant1CreditCommitmentsPage
    {
        public Applicant2CreditCommitmentsPage()
        {
            pageLoadedElement = estimatedValueOfCurrentResidentialPropertyBox;
            correspondingDataClass = new Applicant2CreditCommitmentsPageData().GetType();
            textName = "Applicant 2 Credit Commitments Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                    .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }
    }
    public class Applicant2CreditCommitmentsPageData : Applicant1CreditCommitmentsPageData
    {

    }
}
