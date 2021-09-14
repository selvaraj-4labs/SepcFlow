using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class EBankingAccountsPage : WebBasePage
    {
        public EBankingAccountsPage()
        {
            pageLoadedElement = new Element(FindElement("Your accounts", attributeType: Defs.locatorText, tag: "span"));
            correspondingDataClass = new EBankingAccountsPageData().GetType();
            textName = "EBanking Login Page";
        }

        #region Your Accounts Section
        //Account 1
        public Element textContainingAccountType1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[1]/div/div[1]/ul/li[1]"))
            .SetCompletePageFlag(false);

        public Element textContainingAccountNumber1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[1]/div/div[1]/ul/li[2]"))
            .SetCompletePageFlag(false);

        public Element makeAPayment1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[1]/div/div[2]/ul/li[2]/a"))
            .SetCompletePageFlag(false);

        public Element transferMoney1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[1]/div/div[2]/ul/li[3]/a"))
            .SetCompletePageFlag(false);

        public Element viewAccount1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[1]/div/div[1]/ul/li[3]/a"))
            .SetCompletePageFlag(false);
        
        public Element fundsAmount1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div/div/div[2]/ul/li[1]"))
            .SetCompletePageFlag(false);


        //Account 2
        public Element textContainingAccountType2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[1]/ul/li[1]"))
            .SetCompletePageFlag(false);

        public Element textContainingAccountNumber2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[1]/ul/li[2]"))
            .SetCompletePageFlag(false);

        public Element makeAPayment2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[2]/ul/li[2]/a"))
            .SetCompletePageFlag(false);

        public Element transferMoney2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[2]/ul/li[3]/a"))
            .SetCompletePageFlag(false);


        public Element viewAccount2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[1]/ul/li[3]/a"))
            .SetCompletePageFlag(false);

        public Element fundsAmount2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[2]/div/div[2]/ul/li[1]"))
            .SetCompletePageFlag(false);


        //Account 3
        public Element textContainingAccountType3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[1]/ul/li[1]"))
            .SetCompletePageFlag(false);

        public Element textContainingAccountNumber3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[1]/ul/li[2]"))
            .SetCompletePageFlag(false);

        public Element makeAPayment3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[2]/ul/li[2]/a"))
            .SetCompletePageFlag(false);

        public Element transferMoney3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[2]/ul/li[3]/a"))
            .SetCompletePageFlag(false);


        public Element viewAccount3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[1]/ul/li[3]/a"))
            .SetCompletePageFlag(false);

        public Element fundsAmount3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[3]/div/div[2]/ul/li[1]"))
            .SetCompletePageFlag(false);

        //Account 4
        public Element textContainingAccountType4 => new Element(FindElement(new LocatorList()
          .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[1]/ul/li[1]"))
          .SetCompletePageFlag(false);

        public Element textContainingAccountNumber4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[1]/ul/li[2]"))
            .SetCompletePageFlag(false);

        public Element makeAPayment4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[2]/ul/li[2]/a"))
            .SetCompletePageFlag(false);

        public Element transferMoney4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[2]/ul/li[3]/a"))
            .SetCompletePageFlag(false);


        public Element viewAccount4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[1]/ul/li[3]/a"))
            .SetCompletePageFlag(false);

        public Element fundsAmount4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[4]/div/div[2]/ul/li[1]"))
            .SetCompletePageFlag(false);

        //Account 5
        public Element textContainingAccountType5 => new Element(FindElement(new LocatorList()
        .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[1]/ul/li[1]"))
        .SetCompletePageFlag(false);

        public Element textContainingAccountNumber5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[1]/ul/li[2]"))
            .SetCompletePageFlag(false);

        public Element makeAPayment5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[2]/ul/li[2]/a"))
            .SetCompletePageFlag(false);

        public Element transferMoney5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[2]/ul/li[3]/a"))
            .SetCompletePageFlag(false);


        public Element viewAccount5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[1]/ul/li[3]/a"))
            .SetCompletePageFlag(false);

        public Element fundsAmount5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div[1]/div/div/div[1]/div[2]/div/div[5]/div/div[2]/ul/li[1]"))
            .SetCompletePageFlag(false);



        #endregion

        #region Apply Online Section

        public Element savingsBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Savings")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        #endregion

        #region Account Summary Section

        public Element accountSummaryBtn => new Element(FindElement("=Account Summary", attributeType: Defs.locatorText))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        public Element yourDetailsBtn => new Element(FindElement("=Your details", attributeType: Defs.locatorText))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        public Element viewDocumentsBtn => new Element(FindElement("=View documents", attributeType: Defs.locatorText, tag: "a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        public Element messageCentreBtn => new Element(FindElement("=Message centre", attributeType: Defs.locatorText))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        #endregion

        #region Message Centre Section

        public Element newMail => new Element(FindElement("New Mail", attributeType: Defs.locatorText, tag: "a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        public Element manageYourSecureMail => new Element(FindElement("Manage your Secure mail", attributeType:Defs.locatorText, tag: "a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        #endregion

        public Element homeBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorTitle, "Home")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);


        public Element signOutBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorTitle, "Sign out")))
            .SetCompletePageFlag(false);

        #region Your details section

        public Element changeYourDetailsBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "=Change your details")))
            .SetCompletePageFlag(false);


        public Element companyDetails => new Element(FindElement("Company details", attributeType: Defs.locatorText, tag: "a"))
           .SetCompletePageFlag(false);
        #endregion

        #region Methods to select correct accounts element

        private string GetAccountNumberOnPage(string accountNum)
        {
            string accountNumOnPage = null;
            for (int i = 1; i <= 5; i++)
            {
                if (GetTextFromElement(GetPageElement("textContainingAccountNumber"+i.ToString())).Contains(accountNum))
                {
                    accountNumOnPage = i.ToString();
                    break;
                }
            }
            if (accountNumOnPage == null)
                new TestEnder().FailEnd(Defs.failNonAssert, "The account number '"+ accountNum + "' is not displayed on page.");

            return accountNumOnPage;
        }

        /*
        public void ClickMakeAPayment(string accountNum)
        {
            ClickElement(GetPageElement("makeAPayment" + GetAccountNumberOnPage(accountNum)).locator);
        }

        public void ClickTransferMoney(string accountNum)
        {
            ClickElement(GetPageElement("transferMoney" + GetAccountNumberOnPage(accountNum)).locator);
        }

        public void ClickViewAccount(string accountNum)
        {
            ClickElement(GetPageElement("viewAccount" + GetAccountNumberOnPage(accountNum)).locator);
        }

        public string GetFundsAmount(string accountNum)
        {
            return GetTextFromElement(GetPageElement("viewAccount" + GetAccountNumberOnPage(accountNum)));
        }
        */

        public Element GetMakeAPaymentElement(string accountNum)
        {
            return GetPageElement("makeAPayment" + GetAccountNumberOnPage(accountNum));
        }

        public Element GetTransferMoneyElement(string accountNum)
        {
            return GetPageElement("transferMoney" + GetAccountNumberOnPage(accountNum));
        }

        public Element GetViewAccountElement(string accountNum)
        {
            return GetPageElement("viewAccount" + GetAccountNumberOnPage(accountNum));
        }

        public Element GetFundsAmountElement(string accountNum)
        {
            return GetPageElement("fundsAmount" + GetAccountNumberOnPage(accountNum));
        }

        public Element GetProductTypeElement(string accountNum)
        {
            return GetPageElement("textContainingAccountType" + GetAccountNumberOnPage(accountNum));
        }


        #endregion

    }

    public class EBankingAccountsPageData : PageData
    {
        //public string fundsAmount { set; get; } = null;
    }
}
