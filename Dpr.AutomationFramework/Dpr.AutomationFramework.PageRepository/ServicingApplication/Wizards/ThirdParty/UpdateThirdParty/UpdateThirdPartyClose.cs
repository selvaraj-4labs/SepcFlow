using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyClose : GenericWizardClose
    {
        public UpdateThirdPartyClose()
        {
            correspondingDataClass = new UpdateThirdPartyCloseData().GetType();
            textName = "Update Third Party Close";
        }
    }
    public class UpdateThirdPartyCloseData : GenericWizardCloseData
    {
    }
}
