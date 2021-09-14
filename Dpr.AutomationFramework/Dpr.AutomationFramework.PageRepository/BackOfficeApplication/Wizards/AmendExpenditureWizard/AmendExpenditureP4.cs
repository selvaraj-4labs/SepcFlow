using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendExpenditureWizard
{
    public class AmendExpenditureP4 : BOWizardBasePage
    {
        public AmendExpenditureP4()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new AmendExpenditureP4Data().GetType();
            textName = "Amend Expenditure Page 3";
            windowTitle = "Amend Expenditure";
        }
        public Element finish => new Element(FindElement("Finish", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class AmendExpenditureP4Data : PageData
    {
    }
}
