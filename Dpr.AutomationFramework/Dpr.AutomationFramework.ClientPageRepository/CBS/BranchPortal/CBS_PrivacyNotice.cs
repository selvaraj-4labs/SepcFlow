using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal
{
    public class CBS_PrivacyNotice : WebBasePage
    {
        public CBS_PrivacyNotice()
        {
            pageLoadedElement = privacyNotice;
            correspondingDataClass = new CBS_PrivacyNoticeData().GetType();
            textName = "CBS Branch Privacy Notice Page";
        }

        public Element privacyNotice => new Element(FindElement("ctl00_chkAcceptDeclaration"));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_PrivacyNoticeData : PageData
    {
        public string privacyNotice { get; set; } = Defs.checkBoxSelected;
    }
}
