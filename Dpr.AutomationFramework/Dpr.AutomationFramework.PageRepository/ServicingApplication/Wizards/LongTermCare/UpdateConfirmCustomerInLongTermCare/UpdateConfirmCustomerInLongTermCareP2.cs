using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.UpdateConfirmCustomerInLongTermCare
{
    public class UpdateConfirmCustomerInLongTermCareP2 : GenericFinalWizardPage
    {
        public UpdateConfirmCustomerInLongTermCareP2()
        {
            correspondingDataClass = new UpdateConfirmCustomerInLongTermCareP2Data().GetType();
            textName = "Update Customer In Long Term Care Page 2";
        }
    }

    public class UpdateConfirmCustomerInLongTermCareP2Data : GenericFinalWizardPageData
    {
    }
}
