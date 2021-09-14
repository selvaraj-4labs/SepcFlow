using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP00 : WebBasePage
    {
        public Element selectProduct;

        public HEBS_EAP00()
        {
            pageLoadedElement = fixedRateBondIssue999;
            correspondingDataClass = new HEBS_EAP00Data().GetType();
            textName = "Product Selection";
        }

        #region Retail Product Links
        public Element notice30Annual => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Notice 30 annual")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element notice30Monthly => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Notice 30 monthly")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element notice90Annual => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Notice 90 annual")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element notice90Monthly => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Notice 90 monthly")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element fixedRateBondIssue999 => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Fixed Rate Bond Issue 999")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element branchRegularSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Branch Regular Saver ")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element branchRegularSaverStaffEdition => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Branch Regular Saver Staff Edition")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element branchSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Branch Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element homeDepositSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Home Deposit Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element instantAccessSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Instant Access Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element localCharitySaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Local Charity Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element potteriesPrizeSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Potteries Prize Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region Corporate Product Links
        public Element corporateSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Corporate Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region ISA Product Links
        public Element cashISAInstantAccess => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Cash ISA Instant Access")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);

        public Element cashISARegularSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Cash ISA Regular Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region Child Product Links
        public Element youngSaver => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Young Saver")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        #region Child ISA Product Links
        public Element juniorISA => new Element(FindElement(new LocatorList()
                .Add(Defs.locatorText, "Junior ISA")))
                .SetCompletePageFlag(false)
                .SetIsButtonFlag(true);
        #endregion

        public void SelectProduct(Data data)
        {
            string productName = data.GetFor(className).productName;
            // Old version, commented out 06/07/2020
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

    public class HEBS_EAP00Data : PageData
    {
        public string productName { set; get; }
        public string productType { set; get; }
    }
}
