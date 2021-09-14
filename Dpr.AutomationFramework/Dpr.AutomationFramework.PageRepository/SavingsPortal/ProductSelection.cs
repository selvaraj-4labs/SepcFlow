using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class ProductSelection : WebBasePage
    {
        public Element selectProduct;

        public ProductSelection()
        {
            pageLoadedElement = NoticeAccount120D_Issue1;
            correspondingDataClass = new ProductSelectionData().GetType();
            textName = "Product Selection";
        }

        #region TEVTestApp01 Product Links

        #region Retail Product Links
        public Element NoticeAccount120D_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "120 day Notice Account - Issue 1")))
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

        public Element FixedRate1Y_Quarterly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "1 Yr Fixed Rate (Quarterly) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element FixedRateBond1Y_Annual => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term Bond 1 Year Annual")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element FixedRateBond2Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Term Bond 2 Year (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element RetailFixed_6M_MonthlyInterest_Issue2 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail Fixed 6 Month (Monthly Interest) - Issue2")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element BonusSaver_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Bonus Saver - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element InstantAccess_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Instant Access - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region Corporate Product Links
        public Element CorporateFixedTermBond_1Y_Annual_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate 1 Year Fixed Term Bond (A) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element CorporateFixedTermBond_1Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate 1 Year Fixed Term Bond (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element CorporateFixedRateBond_2Y_Annual_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate 2 Year Fixed Rate Bond (A) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element CorporateFixedTermBond_2Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate 2 Year Fixed Term Bond (M) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element Corporate35D_NA_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate 35Day NA (Monthly) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element CorporateCashISA_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate Cash ISA - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element CorporateInstantAccess => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corportate Instant Access")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region ISA Product Links
        public Element RetailISA_1Y_Fixed_AnnualInterest_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail ISA 1 Year Fixed (Annual Interest) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element RetailISA_6M_Fixed_AnnualInterest_Issue => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Retail ISA 6 Month Fixed (Annual Interest) - Issue")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        public Element CashISA_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Cash ISA - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        #endregion

        #region Child Product Links
        public Element ChildFixedTermBond1Y_Monthly_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Child Fixed Term Bond 1 Year (Monthly) - Issue 1")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region Child ISA Product Links
        public Element JuniorISA_1Y_Issue1 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Junior ISA 1 Year - Issue 1")))
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


    public class ProductSelectionData : PageData
    {
        public string productName { set; get; }
        public string productType { set; get; }
    }
}
