using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.ModifyAccountTags
{
    public class ModifyAccountTagsClose : GenericWizardClose
    {
        public ModifyAccountTagsClose()
        {
            correspondingDataClass = new ModifyAccountTagsCloseData().GetType();
            textName = "Modify Account Tags Close";
        }
    }

    public class ModifyAccountTagsCloseData : GenericWizardCloseData
    {
    }
}
