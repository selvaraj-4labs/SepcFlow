using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CancelCustomerInLongTermCare
{
    public class CancelCustomerInLongTermCareP2 : GenericFinalWizardPage
    {
        public CancelCustomerInLongTermCareP2()
        {
            correspondingDataClass = new CancelCustomerInLongTermCareP2Data().GetType();
            textName = "Update Customer In Long Term Care Page 2";
        }
    }

    public class CancelCustomerInLongTermCareP2Data : GenericFinalWizardPageData
    {
    }
}
