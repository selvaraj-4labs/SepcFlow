using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyP5 : GenericFinalWizardPage
    {
        public UpdateThirdPartyP5()
        {
            correspondingDataClass = new UpdateThirdPartyP5Data().GetType();
            textName = "Update Third Party Page 5";
        }
    }
    public class UpdateThirdPartyP5Data : GenericFinalWizardPageData
    {
    }

}
