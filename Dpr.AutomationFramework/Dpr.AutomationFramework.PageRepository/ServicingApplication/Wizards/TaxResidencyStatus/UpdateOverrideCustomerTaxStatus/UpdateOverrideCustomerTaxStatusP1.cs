using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.OverrideCustomerTaxStatus;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateOverrideCustomerTaxStatus
{
    public class UpdateOverrideCustomerTaxStatusP1 : OverrideCustomerTaxStatusP2
    {
        public UpdateOverrideCustomerTaxStatusP1()
        {
            correspondingDataClass = new UpdateOverrideCustomerTaxStatusP1Data().GetType();
            textName = "Update Override Customer Tax Status Page 1";
        }

    }

    public class UpdateOverrideCustomerTaxStatusP1Data : OverrideCustomerTaxStatusP2Data
    {
        
    }
}
