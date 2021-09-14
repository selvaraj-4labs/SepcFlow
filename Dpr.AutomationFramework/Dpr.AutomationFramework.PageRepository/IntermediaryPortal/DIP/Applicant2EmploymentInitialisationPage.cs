using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2EmploymentInitialisationPage : Applicant1EmploymentInitialisationPage
    {
        public Applicant2EmploymentInitialisationPage()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new Applicant2EmploymentInitialisationPageData().GetType();
            textName = "Applicant 2 Employment Initialisation Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }
    }
    public class Applicant2EmploymentInitialisationPageData : Applicant1EmploymentInitialisationPageData
    {
    }
}
