using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.ConfirmCustomerInLongTermCare
{
    public class ConfirmCustomerInLongTermCareP3 : GenericFinalWizardPage
    {
        public ConfirmCustomerInLongTermCareP3()
        {
            correspondingDataClass = new ConfirmCustomerInLongTermCareP3Data().GetType();
            textName = "Confirm Customer In Long Term Care Page 3";
        }
    }

    public class ConfirmCustomerInLongTermCareP3Data : GenericFinalWizardPageData
    {
    }
}
