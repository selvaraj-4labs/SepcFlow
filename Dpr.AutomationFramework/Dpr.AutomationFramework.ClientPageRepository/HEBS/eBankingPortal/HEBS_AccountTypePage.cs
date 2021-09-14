using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_AccountTypePage : AccountTypePage
    {
        public HEBS_AccountTypePage()
        {
            pageLoadedElement = new Element(FindElement("Your account types", attributeType: Defs.locatorText));
            correspondingDataClass = new HEBS_AccountTypePageData().GetType();
            textName = "EBanking Account Type Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition(className, "dedupe", "true"))));
        }
    }

    public class HEBS_AccountTypePageData : AccountTypePageData
    {
    }
}
