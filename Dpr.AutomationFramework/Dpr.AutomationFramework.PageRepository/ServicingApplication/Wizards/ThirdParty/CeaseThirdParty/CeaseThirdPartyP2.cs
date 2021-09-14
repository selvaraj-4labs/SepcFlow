using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.CeaseThirdParty
{
    public class CeaseThirdPartyP2 : GenericFinalWizardPage
    {
        public CeaseThirdPartyP2()
        {
            correspondingDataClass = new CeaseThirdPartyP2Data().GetType();
            textName = "Cease Third party Page 2";
        }
    }

    public class CeaseThirdPartyP2Data : GenericFinalWizardPageData
    {
    }
}
