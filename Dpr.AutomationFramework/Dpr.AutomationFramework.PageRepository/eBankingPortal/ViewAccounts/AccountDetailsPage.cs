using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ViewAccounts
{
    public class AccountDetailsPage : WebBasePage
    {
        public AccountDetailsPage()
        {
            pageLoadedElement = transactions;
            correspondingDataClass = new AccountDetailsPageData().GetType();
            textName = "EBanking Account Details Page";
        }
        public Element makeAPayment => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/div[2]/div/div/div/div[2]/ul/li[4]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element transferMoney => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/div[2]/div/div/div/div[2]/ul/li[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element makeADeposit => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/div[2]/div/div/div/div[2]/ul/li[6]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element editAccountDetails => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/div[2]/div/div/div/div[1]/ul/li[7]/a[1]"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element setMaturityInstruction => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=container"), "/section[4]/div/div/div/div/div/article/div[2]/div/div/div/div[1]/ul/li[7]/a[2]"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element transactions => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=loans_details"), "/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element futurePayments => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "=loans_FuturePayments"), "/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element cancelFuturePayment1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/table/tbody/tr[1]/td[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element cancelFuturePayment2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/table/tbody/tr[2]/td[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element cancelFuturePayment3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/table/tbody/tr[3]/td[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element cancelFuturePayment4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/table/tbody/tr[4]/td[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element cancelFuturePayment5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/table/tbody/tr[5]/td[5]/a"))
            .SetIsButtonFlag(true).SetCompletePageFlag(false);
        public Element periodFrom => new Element(FindElement("FromDate"))
            .SetCompletePageFlag(false);
        public Element periodTo => new Element(FindElement("ToDate"))
            .SetCompletePageFlag(false);
        public Element filter => new Element(FindElement("Filter", attributeType: Defs.locatorValue))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);        
        public Element transactionTableDateRow1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorClass, "=display-table transactions-table"), "/tbody/tr[1]/td[1]"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element transactionsHeader => new Element(FindElement("Transactions", attributeType: Defs.locatorText, tag: "span"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element authorisedPaymentsHeader  => new Element(FindElement("Authorised Payments", attributeType: Defs.locatorText, tag: "span"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element regularPaymentsHeader => new Element(FindElement("Regular Payments", attributeType: Defs.locatorText, tag: "span"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public override void ContextClickElement(By elementLocator)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AccountDetailsPageData : PageData
    {
    }
}
