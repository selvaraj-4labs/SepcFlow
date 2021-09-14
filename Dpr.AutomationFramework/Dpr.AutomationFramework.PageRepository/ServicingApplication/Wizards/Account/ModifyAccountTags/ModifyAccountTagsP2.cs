using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.ModifyAccountTags
{
    public class ModifyAccountTagsP2 : GenericFinalWizardPage
    {
        public ModifyAccountTagsP2()
        {
            correspondingDataClass = new ModifyAccountTagsP2Data().GetType();
            textName = "Modify Account Tags Page 2";
        }
    }

    public class ModifyAccountTagsP2Data : GenericFinalWizardPageData
    {
    }
}
