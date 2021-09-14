using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendExpenditureWizard
{
    public class AmendExpenditureP3 : BOWizardBasePage
    {
        public AmendExpenditureP3()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendExpenditureP3Data().GetType();
            textName = "Amend Expenditure Page 3";
            windowTitle = "Amend Expenditure";
        }
        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendExpenditureP3Data : PageData
    {
    }
}
