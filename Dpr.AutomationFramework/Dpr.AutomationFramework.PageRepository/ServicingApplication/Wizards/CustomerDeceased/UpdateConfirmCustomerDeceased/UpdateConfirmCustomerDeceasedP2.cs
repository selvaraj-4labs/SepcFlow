using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.UpdateConfirmCustomerDeceased
{
    public class UpdateConfirmCustomerDeceasedP2 : GenericFinalWizardPage
    {
        public UpdateConfirmCustomerDeceasedP2()
        {
            correspondingDataClass = new UpdateConfirmCustomerDeceasedP2Data().GetType();
            textName = "Update Confirm Customer Deceased Page 2";
        }
    }

    public class UpdateConfirmCustomerDeceasedP2Data : GenericFinalWizardPageData
    {
    }
}
