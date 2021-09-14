using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal
{
    public class CBS_LoginPage : WebBasePage
    {
        public CBS_LoginPage()
        {
            pageLoadedElement = username;
            correspondingDataClass = new CBS_LoginPageData().GetType();
            textName = "CBS Mortgages Login Page";
        }

        public Element username => new Element(FindElement("txtUserName", tag: "input"));

        public Element password => new Element(FindElement("MC_txtPassword", tag: "input"));

        public Element logon => new Element(FindElement("Logon"))
            .SetIsButtonFlag(true);
    }

    public class CBS_LoginPageData : PageData
    {
        public string username { get; set; } = "Broker123";
        public string password { get; set; } = "Password2";
    }
}
