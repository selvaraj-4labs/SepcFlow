using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.CeaseThirdParty
{
    public class CeaseThirdPartyClose : GenericWizardClose
    {
        public CeaseThirdPartyClose()
        {
            correspondingDataClass = new CeaseThirdPartyCloseData().GetType();
            textName = "Cease Third Party Close";
        }
    }
    public class CeaseThirdPartyCloseData : GenericWizardCloseData
    {
    }
}
