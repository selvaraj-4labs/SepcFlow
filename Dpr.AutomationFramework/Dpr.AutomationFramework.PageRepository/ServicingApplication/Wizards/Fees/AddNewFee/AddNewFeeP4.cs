using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.AddNewFee
{
    public class AddNewFeeP4 : GenericFinalWizardPage
    {
        public AddNewFeeP4()
        {
            correspondingDataClass = new GenericFinalWizardPageData().GetType();
            textName = "Add New Fee Page 4";
        }

        public new Element nextBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Ok"), tag: "Button"))
            .SetIsButtonFlag(true);
    }

    public class AddNewFeeP4Data : GenericFinalWizardPageData
    {
    }
}
