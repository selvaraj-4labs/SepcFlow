using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_PBD01 : ProductSelectionPage
    {

        private readonly TestContext _testContext;

        public CBS_PBD01(TestContext testContext) : base(testContext)
        {
            _testContext = testContext;
            pageLoadedElement = repaymentType;
            correspondingDataClass = new CBS_PBD01Data().GetType();
            textName = "CBS DIP Product Selection Page";
        }

        #region Locators


        #region 'Product Filter' Section
        public new Element productCategory => new Element(FindElement("ProductRange"));
        public new Element rateType => new Element(FindElement("InterestRateOption"));
        public new Element filter => new Element(FindElement("ctl00_MyFindButton")).SetIsButtonFlag(true).SetCompletePageFlag(false);
        #endregion

        #region Page Link Section
        public new Element resultsCount => new Element(FindElement("MC_DevProductChoiceWithDescription1_ctl02_ProductsPager"));

        public new string productPagerDefault = "//*[contains(@id,'ProductsPager')]/a[contains(@title,'Page ";
        #endregion

        #endregion

        #region Private Methods
        // Determines the number of pages that are displayed
        // using the 'productPagerTab' element
        private int DeterminePageNumber()
        {
            decimal numberOfProducts;
            List<Element> _pageLinkList = new List<Element>();
            string productPagerString = GetTextFromElement(resultsCount.locator);

            // Trim the string to the total number of products.
            int resultIndex = productPagerString.IndexOf("   ");
            if (resultIndex != -1)
            {
                productPagerString = productPagerString.Substring(0, resultIndex);
            }

            productPagerString = productPagerString.Split(' ').Last();

            //Returning 17 not 17.1?? Something to do with the conversion to int?
            numberOfProducts = (Convert.ToDecimal(productPagerString)) / 10m;

            int numberOfPageLinks = (int)Math.Ceiling(numberOfProducts);

            return numberOfPageLinks;
        }

        // Searches for and selects the product
        private void SelectProduct(Data data)
        {
            // Creating a link between the select button and product name
            Element[,] NameBtnArray =
                new Element[,]
                {
                    { select_1, productName_1 },
                    { select_2, productName_2 },
                    { select_3, productName_3 },
                    { select_4, productName_4 },
                    { select_5, productName_5 },
                    { select_6, productName_6 },
                    { select_7, productName_7 },
                    { select_8, productName_8 },
                    { select_9, productName_9 },
                    { select_10, productName_10 }
                };

            ClickElement(filter.locator);
            WaitForNextScreen(select_1);

            // Retrieving the value that the user input
            string productNameUserInput = data.GetFor(className)._userInputProductName;

            // Determine the number of products 
            //from the number of rows in the table
            int numberOfProdcuts = (GetNumberOfElements(productTableRowCounter.locator) - 1) / 2;

            int numberOfProductPages = DeterminePageNumber();

            bool productFoundFlag = false;

            int i = 0;
            // Load the first page.
            ClickElement(filter.locator);
            WaitForNextScreen(select_1);
            do
            {
                // For every product page, search the page for the product name
                for (int j = 0; j < numberOfProdcuts; j++)
                {
                    // Retrieve the value from relevant productName box.
                    string rowProductName = GetTextFromElement(NameBtnArray[j, 1].locator);

                    // If true, then product has been found.
                    if (rowProductName == productNameUserInput)
                    {
                        CompleteElement(" ", NameBtnArray[j, 0].locator);
                        productFoundFlag = true;
                        break;
                    }
                }

                if (productFoundFlag == false)
                {
                    // Move onto the next product page
                    string nextProductPage = productPagerDefault + (i + 1).ToString() + "')]";
                    ClickElement(By.XPath(nextProductPage));
                    //ClickElement(pageLinkList[i].locator);
                    ClickElement(filter.locator);
                    WaitForNextScreen(select_1);

                }
                i++;
            } while (i < numberOfProductPages &&
                productFoundFlag == false);

            // Display a fail if the product is not found
            if (productFoundFlag == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The product with name '" +
                    productNameUserInput + "' was not found. Please " +
                    "review the product name.",
                    driver,
                    _testContext);
            }
        }
        #endregion

        #region CompletePage Override
        public override void CompletePage(
            IWebDriver driver,
            Data data,
            bool continueToNextPageFlag = true,
            bool logAndOutputInput = false)
        {
            // Checks if the variable '_userInputProductName' has 
            // a value, if so, then user has specificed a product
            if (data.GetFor(className)._userInputProductName == null)
            {
                // Calling the default 'CompletePage' method
                base.CompletePage(
                    driver,
                    data,
                    continueToNextPageFlag = true,
                    logAndOutputInput = false);
                return;
            }

            // Override 'CompletePage' logic
            else
            {
                this.logAndOutputInput = logAndOutputInput;
                this.driver = driver;
                WaitForNextScreen(pageLoadedElement);
                SelectProduct(data);
                ClickElement(next, data);
                return;
            }

        }
        #endregion
    }

    public class CBS_PBD01Data : ProductSelectionPageData
    {
    }
}
