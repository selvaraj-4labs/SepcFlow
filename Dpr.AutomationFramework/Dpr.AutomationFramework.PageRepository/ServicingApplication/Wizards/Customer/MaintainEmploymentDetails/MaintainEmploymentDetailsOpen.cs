using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class MaintainEmploymentDetailsOpen : GenericWizardOpen
    {
        public MaintainEmploymentDetailsOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new MaintainEmploymentDetailsOpenData().GetType();
            textName = "Maintain Employment Details Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.customer;
        public Element clickWizard => processActions.maintainEmploymentDetails;
    }

    public class MaintainEmploymentDetailsOpenData : GenericWizardOpenData
    {
    }
}
