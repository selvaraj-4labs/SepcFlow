using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP08 : Applicant1EmploymentInitialisationPage
    {
        public CBS_DIP08()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new CBS_DIP08Data().GetType();
            textName = "CBS Applicant 1 Employment Initialisation Page";
        }
    }

    public class CBS_DIP08Data : Applicant1EmploymentInitialisationPageData
    {
    }
}
