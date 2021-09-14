using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class AccountTypePage : WebBasePage
    {
        public AccountTypePage()
        {
            pageLoadedElement = new Element(FindElement("Your account types", attributeType: Defs.locatorText));
            correspondingDataClass = new AccountTypePageData().GetType();
            textName = "EBanking Account Type Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition(className, "dedupe", "true"))));
        }

        //*[@id="container"]/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[1]/a
        public Element accountToSelect => new Element(new ButtonGroup()
            .AddButtonElement("company1", FindElement(new LocatorList().Add(Defs.locatorId, "=container"), xpathSuffix: "/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[1]/a"))
            .AddButtonElement("company2", FindElement(new LocatorList().Add(Defs.locatorId, "=container"), xpathSuffix: "/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[2]/a"))
            .AddButtonElement("company3", FindElement(new LocatorList().Add(Defs.locatorId, "=container"), xpathSuffix: "/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[3]/a"))
            .AddButtonElement("company4", FindElement(new LocatorList().Add(Defs.locatorId, "=container"), xpathSuffix: "/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[4]/a"))
            .AddButtonElement("company5", FindElement(new LocatorList().Add(Defs.locatorId, "=container"), xpathSuffix: "/section[4]/div/div/div[1]/div/div/div/div[2]/div/div/ul/li[5]/a")));



    }

    public class AccountTypePageData : PageData
    {
        public string dedupe { get; set; } = "false";

        public string accountToSelect { get; set; } = "personal";
    }
}
