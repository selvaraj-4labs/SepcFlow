using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ContactCustomer
{
    public class ContactCustomerP2 : GenericFinalWizardPage
    {
        public ContactCustomerP2()
        {
            correspondingDataClass = new ContactCustomerP2Data().GetType();
            textName = "Contact Customer Page 2";
        }
    }

    public class ContactCustomerP2Data : GenericFinalWizardPageData
    {
    }
}
