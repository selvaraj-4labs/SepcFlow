using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP6 : GenericFinalWizardPage
    {
        public AddNewThirdPartyP6()
        {
            correspondingDataClass = new AddNewThirdPartyP6Data().GetType();
            textName = "Add New Third Party Page 6";
        }
    }

    public class AddNewThirdPartyP6Data : GenericFinalWizardPageData
    {
    }
}
