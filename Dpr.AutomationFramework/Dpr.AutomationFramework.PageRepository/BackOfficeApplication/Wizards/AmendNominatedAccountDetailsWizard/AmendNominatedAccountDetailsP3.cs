using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendNominatedAccountDetailsWizard
{
    public class AmendNominatedAccountDetailsP3 : BOWizardBasePage
    {

        public AmendNominatedAccountDetailsP3()
        {
            pageLoadedElement = finishBtn;
            correspondingDataClass = new AmendNominatedAccountDetailsP3Data().GetType();
            textName = "Amend Nominated Account Details Page 3";
        }

        public Element finishBtn => new Element(FindElement("Finish", Defs.boLocatorName))
            .SetIsButtonFlag(true);


    }


    public class AmendNominatedAccountDetailsP3Data : PageData
    {
    }

}
