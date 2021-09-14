using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.ResumeCustomerStatus
{
    public class ResumeCustomerStatusP2 : GenericFinalWizardPage
    {
        public ResumeCustomerStatusP2()
        {
            correspondingDataClass = new ResumeCustomerStatusP2Data().GetType();
            textName = "Resume Customer Status Page 2";
        }
    }

    public class ResumeCustomerStatusP2Data : GenericFinalWizardPageData
    {
    }
}

