using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.AddNewFee
{
    public class AddNewFeeP2 : GenericFinalWizardPage
    {
        public AddNewFeeP2()
        {
            correspondingDataClass = new AddNewFeeP2Data().GetType();
            textName = "Add New Fee Page 2";
        }
    }



    public class AddNewFeeP2Data : GenericFinalWizardPageData
    {
    }
}
