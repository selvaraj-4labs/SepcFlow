using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class LoginDetails: WebBasePage
    {
   


            public LoginDetails()
            {
                pageLoadedElement = usernameBox;
                correspondingDataClass = new LoginDetailsData().GetType();
            }
            public Element usernameBox => new Element(FindElement("MC_txtUserName"));

            public Element passwordBox => new Element(FindElement("MC_txtPassword"));

            public Element termsAndConditionsChbox => new Element(FindElement("MC_chkAcceptTermsRead"));

            public Element logonBtn => new Element(FindElement("Logon"))
                .SetIsButtonFlag(true);





            /* public override void CompletePage(IWebDriver driver, Data data)
             {
                 this.driver = driver;
                 WaitForNextScreen(pageLoadedElement);

                 CompleteElement(data.GetFor(className).username, usernameBox, data);
                 CompleteElement(data.GetFor(className).password, passwordBox);
                 CompleteElement(data.GetFor(className).termsAndConditions, termsAndConditionsChbox);
                 ClickElement(logonBtn);
             }*/


        }


        public class LoginDetailsData : PageData
        {
            public string username { get; set; } = "ed.ferrell@dpr.co.uk";
            public string password { get; set; } = "Password1";
            public string termsAndConditions { get; set; } = Defs.checkBoxSelected;
        }
    }
