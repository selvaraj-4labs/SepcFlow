using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_AP01 : AP01
    {
        public HEBS_AP01()
        {
            pageLoadedElement = titleTag;
            correspondingDataClass = new HEBS_AP01Data().GetType();
            textName = "Product Selection Page";
        }
        public new void SelectProduct(Data data)
        {
            string productName = data.GetFor(className).productName;
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

    public class HEBS_AP01Data : AP01Data
    {
    }
}
