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
    class LoginPagePBR : WebBasePage
    {
   

            public LoginPagePBR()
            {
                pageLoadedElement = firstCharacter;
                correspondingDataClass = new LoginData().GetType();
            }
            public Element firstCharacter => new Element(FindElement("MC_cboChar1TextControl"));

            public Element secondCharacter => new Element(FindElement("MC_cboChar2TextControl"));

            public Element thirdCharacter => new Element(FindElement("MC_cboChar3TextControl"));

            public Element logonBtn => new Element(FindElement("MC_cmdAuthenticate"))
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


        public class LoginData : PageData
        {
            public string firstCharacter { get; set; } = "A";
            public string secondCharacter { get; set; } = "A";
            public string thirdCharacter { get; set; } = "A";
            
        }
    }



