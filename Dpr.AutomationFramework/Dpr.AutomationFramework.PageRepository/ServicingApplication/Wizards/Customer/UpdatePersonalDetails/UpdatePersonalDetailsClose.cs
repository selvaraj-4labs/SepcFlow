using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails
{
    public class UpdatePersonalDetailsClose : GenericWizardClose
    {
        public UpdatePersonalDetailsClose()
        {
            correspondingDataClass = new UpdatePersonalDetailsCloseData().GetType();
            textName = "Update Personal Details Close";
        }
    }
    public class UpdatePersonalDetailsCloseData : GenericWizardCloseData
    {
    }
}
