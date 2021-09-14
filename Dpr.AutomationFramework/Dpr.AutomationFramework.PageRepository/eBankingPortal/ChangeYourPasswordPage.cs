using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class ChangeYourPasswordPage : WebBasePage
    {
        public ChangeYourPasswordPage()
        {
            pageLoadedElement = currentPassword;
            correspondingDataClass = new ChangeYourPasswordPageData().GetType();
            textName = "EBanking Change your password";
        }

        public Element currentPassword => new Element(FindElement("OldPassword"));

        public Element newPassword => new Element(FindElement("NewPassword"));

        public Element confirmNewPassword => new Element(FindElement("ConfirmPassword"));

        public Element passwordHint => new Element(FindElement("PasswordHint"));

        public Element changePassword => new Element(FindElement("Change password", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true);
    }

    public class ChangeYourPasswordPageData : PageData
    {
        public string currentPassword { set; get; } = null;

        public string newPassword  { set; get; } = null;

        public string confirmNewPassword  { set; get; } = null;

        public string passwordHint  { set; get; } = null;
    }
}
