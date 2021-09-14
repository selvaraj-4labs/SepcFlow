

using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class BrokerHomePagePBR: WebBasePage
    {
        public BrokerHomePagePBR()
        {
            pageLoadedElement = dipBtn;
            correspondingDataClass = new BrokerHomeDataPBR().GetType();
        }
        public Element dipBtn => new Element(By.XPath("//a[@href='Application/Apply/Dip/']"))
            .SetIsButtonFlag(true);






    }

    public class BrokerHomeDataPBR : PageData
    {

    }
}

