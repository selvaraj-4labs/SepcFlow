using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.MaintainEmploymentDetails
{
    public class MaintainEmploymentDetailsP9 : GenericFinalWizardPage
    {
        public MaintainEmploymentDetailsP9()
        {
            correspondingDataClass = new MaintainEmploymentDetailsP9Data().GetType();
            textName = "Maintain Employment Details Page 8";
        }
    }
    public class MaintainEmploymentDetailsP9Data : GenericFinalWizardPageData
    {

    }
}
