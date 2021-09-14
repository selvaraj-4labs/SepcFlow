using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.ConfirmCustomerDeceased
{
    public class ConfirmCustomerDeceasedP3 : GenericFinalWizardPage
    {
        public ConfirmCustomerDeceasedP3()
        {
            correspondingDataClass = new ConfirmCustomerDeceasedP3Data().GetType();
            textName = "Confirm Customer Deceased Page 3";
        }
    }

    public class ConfirmCustomerDeceasedP3Data : GenericFinalWizardPageData
    {
    }
}
