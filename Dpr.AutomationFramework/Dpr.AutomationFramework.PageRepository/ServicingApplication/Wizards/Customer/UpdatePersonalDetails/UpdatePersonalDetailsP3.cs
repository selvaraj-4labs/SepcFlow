using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails
{
    public class UpdatePersonalDetailsP3 : GenericFinalWizardPage
    {
        public UpdatePersonalDetailsP3()
        {
            correspondingDataClass = new UpdatePersonalDetailsP3Data().GetType();
            textName = "Update Personal Details Page 3";
        }
    }

    public class UpdatePersonalDetailsP3Data : GenericFinalWizardPageData
    {
    }
}
