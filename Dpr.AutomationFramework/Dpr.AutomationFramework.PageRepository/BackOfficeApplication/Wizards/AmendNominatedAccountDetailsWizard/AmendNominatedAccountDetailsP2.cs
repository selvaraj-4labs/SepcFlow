using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendNominatedAccountDetailsWizard
{
    public class AmendNominatedAccountDetailsP2 : BOWizardBasePage
    {

        public AmendNominatedAccountDetailsP2()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new AmendNominatedAccountDetailsP2Data().GetType();
            textName = "Amend Nominated Account Details Page 2";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);


    }


    public class AmendNominatedAccountDetailsP2Data : PageData
    {
    }

}
