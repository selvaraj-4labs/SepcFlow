using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal
{
    public class LoginPage : WebBasePage
    {

        public LoginPage()
        {
            pageLoadedElement = username;
            correspondingDataClass = new LoginPageData().GetType();
            textName = "Mortgages Login Page";
        }
            public Element username => new Element(FindElement("txtUserName"));

            public Element password => new Element(FindElement("MC_txtPassword"));

            //public Element termsAndConditionsChbox => new Element(FindElement("MC_chkAcceptTermsRead"));

            public Element logon => new Element(FindElement("Logon"))
                .SetIsButtonFlag(true);
    }


    public class LoginPageData : PageData
    {
        public string username { get; set; } = "Holmes";
        public string password { get; set; } = "Password2"; // Updatd from "Password1" to "Password2" - 14/04/2020
        //public string termsAndConditions { get; set; } = Defs.checkBoxSelected;
    }
}
