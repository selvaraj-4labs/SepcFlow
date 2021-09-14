using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.ModifyAccountTags
{
    public class ModifyAccountTagsOpen : GenericWizardOpen
    {
        public ModifyAccountTagsOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new ModifyAccountTagsOpenData().GetType();
            textName = "Modify Account Tags Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountAdmin;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickModifyAccountTags => processActions.modifyAccountTags;
    }

    public class ModifyAccountTagsOpenData : GenericWizardOpenData
    {

    }
}
