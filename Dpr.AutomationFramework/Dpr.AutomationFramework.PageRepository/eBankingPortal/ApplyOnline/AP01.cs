using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{ 
    public class AP01 : WebBasePage
    {
        public Element selectProduct;

        public AP01()
        {
            pageLoadedElement = titleTag;
            correspondingDataClass = new AP01Data().GetType();
            textName = "Product Selection Page";
        }

        public Element titleTag => new Element(FindElement("Apply for new savings account", attributeType: Defs.locatorText));

        #region TEVTestApp02 Product Links

        #region 'Cash ISA Accounts' Section
        public Element cashISA_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Cash ISA - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element juniorISA_1Year_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Junior ISA 1 Year - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element retailISA_1Year_Fixed_Annual => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail ISA 1 Year Fixed (A)")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element retailISA_6Month_Fixed_Annual => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail ISA 6 Month Fixed (A)")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region 'Other Savings Accounts' Section
        public Element FixedRate1Y_Quarterly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "1 Yr Fixed Rate (Quarterly) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element NoticeAccount120D => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "120Notice")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element ChildFixedTermBond1Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Child Fixed Term Bond 1 Year (Monthly) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element FixedTermBond1Y_Annual_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term 1 Year Bond (A) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element FixedTermBond1Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term 1 Year Bond (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element FixedTermBond2Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term Bond 2 Year (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element InstantAccess_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term Bond 2 Year (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element RetailFixed_6Month_Monthly_Issue2 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail Fixed 6 Month (Monthly Interest) - Issue2")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element RetailFixedTermBond2Y_Annual_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail Fixed Term 2 Year Bond (A) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element RetailFixedTermBond2Y_Annual_Issue2 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail Fixed Term 2 Year Bond (A) - Issue 2")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #endregion

        public void SelectProduct(Data data)
        {
            string productName = data.GetFor(className).productName;
            // Old version, commented out 02/07/2020
            //selectProduct = new Element(FindElement(new LocatorList()
            //.Add(Defs.locatorText, productName)))
            //.SetIsButtonFlag(true);

            selectProduct = new Element(FindElement(""));
            selectProduct.locator = By.XPath("//*[text()='" + productName + "']");

            if (logAndOutputInput)
            {
                Console.Write("Selecting product '{0}'", productName);
            }

            ClickElement(selectProduct.locator);
        }

        public override void CompletePage(
            IWebDriver driver,
            Data data,
            bool continueToNextPageFlag = true,
            bool logAndOutputInput = false)
        {
            this.logAndOutputInput = logAndOutputInput;
            this.driver = driver;
            WaitForNextScreen(pageLoadedElement);
            SelectProduct(data);
        }
    }


    public class AP01Data : PageData
    {
        public string productName { set; get; }
        public string productType { set; get; }
    }
}
