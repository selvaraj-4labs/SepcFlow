using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyClose : GenericWizardClose
    {
        public AddNewThirdPartyClose()
        {
            correspondingDataClass = new AddNewThirdPartyCloseData().GetType();
            textName = "Add New Third Party Close";
        }
    }
    public class AddNewThirdPartyCloseData : GenericWizardCloseData
    {
    }
}
