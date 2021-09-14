using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Roles.AddCeaseRole
{
    public class AddCeaseRoleP3 : GenericFinalWizardPage
    {
        public AddCeaseRoleP3()
        {
            correspondingDataClass = new AddCeaseRoleP3Data().GetType();
            textName = "Add Cease Role Page 3";
        }
    }

    public class AddCeaseRoleP3Data : GenericFinalWizardPageData
    {
    }
}
