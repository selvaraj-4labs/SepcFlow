using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CancelCustomerDeceased
{
    public class CancelCustomerDeceasedP2 : GenericFinalWizardPage
    {
        public CancelCustomerDeceasedP2()
        {
            correspondingDataClass = new CancelCustomerDeceasedP2Data().GetType();
            textName = "Cancel Customer Deceased Page 2";
        }
    }

    public class CancelCustomerDeceasedP2Data : GenericFinalWizardPageData
    {
    }
}
