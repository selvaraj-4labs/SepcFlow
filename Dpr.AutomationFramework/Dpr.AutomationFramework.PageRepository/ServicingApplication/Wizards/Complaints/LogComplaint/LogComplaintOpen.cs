using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Complaints.LogComplaint
{
    public class LogComplaintOpen : GenericWizardOpen
    {
        public LogComplaintOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new LogComplaintOpenData().GetType();
            textName = "Log Complaint Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.customer;
        public Element clickWizard => processActions.logComplaint;
    }

    public class LogComplaintOpenData : GenericWizardOpenData
    {
    }
}
