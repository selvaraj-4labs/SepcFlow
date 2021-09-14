using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using OpenQA.Selenium;
using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class ProductSelectionPage : WebBasePage
    {
        private readonly TestContext _testContext;

        public ProductSelectionPage(TestContext testContext)
        {
            _testContext = testContext;
            pageLoadedElement = repaymentType;
            correspondingDataClass = new ProductSelectionPageData().GetType();
            textName = "DIP Product Selection Page";
        }

        #region Locators

        #region 'Loan Details' Section
        public Element repaymentType => new Element(FindElement("ctl00_RepaymentType"));
        public Element declaredTermYears => new Element(FindElement("txtRequestedLoanTerm"));
        public Element declaredMonthsYears => new Element(FindElement("txtRequestedLoanMonths"));
        public Element loanAmount => new Element(FindElement("LoanAmount"));
        public Element capitalAndInterestAmount => new Element(FindElement("ctl00_CapAndIntAmount"));
        public Element interestOnlyAmount => new Element(FindElement("ctl00_InterestOnlyAmount"));
        #endregion

        #region 'Product Filter' Section
        public Element productCategory => new Element(FindElement("ProductRange"));
        public Element rateType => new Element(FindElement("InterestRateOption"));
        public Element productFeaturesCashBack350 => new Element(FindElement("item0_FeatureFilterPackSelect"));
        public Element productFeaturesFreeLegals => new Element(FindElement("item1_FeatureFilterPackSelect"));
        public Element productFeaturesFreeValuation => new Element(FindElement("item2_FeatureFilterPackSelect"));
        public Element productFeaturesCashBack200 => new Element(FindElement("item3_FeatureFilterPackSelect"));
        public Element filter => new Element(new ButtonGroup()
            .AddButtonElement("Filter", FindElement("MyFindButton")));
        #endregion

        #region 'Available Products' Section

        public Element productTableRowCounter => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MC_DevProductChoiceWithDescription1_ctl02_ProductsGrid_layoutTable"),
            "/tbody/tr"));

        #region Product Name Section
        public Element productName_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[2]/td[1]"));

        public Element productName_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[4]/td[1]"));

        public Element productName_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[6]/td[1]"));

        public Element productName_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[8]/td[1]"));

        public Element productName_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[10]/td[1]"));

        public Element productName_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[12]/td[1]"));

        public Element productName_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[14]/td[1]"));

        public Element productName_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[16]/td[1]"));

        public Element productName_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[18]/td[1]"));

        public Element productName_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[20]/td[1]"));
        #endregion

        #region 'Rate Type' Section
        public Element rateType_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[3]/td[1]"));
        public Element rateType_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[5]/td[1]"));

        public Element rateType_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[7]/td[1]"));

        public Element rateType_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[9]/td[1]"));

        public Element rateType_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[11]/td[1]"));

        public Element rateType_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[13]/td[1]"));

        public Element rateType_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[15]/td[1]"));

        public Element rateType_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[17]/td[1]"));

        public Element rateType_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[19]/td[1]"));

        public Element rateType_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[21]/td[1]"));
        #endregion

        #region 'Initial Rate' Section
        public Element initialRate_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[3]/td[2]"));
        public Element initialRate_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[5]/td[2]"));

        public Element initialRate_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[7]/td[2]"));

        public Element initialRate_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[9]/td[2]"));

        public Element initialRate_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[11]/td[2]"));

        public Element initialRate_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[13]/td[2]"));

        public Element initialRate_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[15]/td[2]"));

        public Element initialRate_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[17]/td[2]"));

        public Element initialRate_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[19]/td[2]"));

        public Element initialRate_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[21]/td[2]"));
        #endregion

        #region 'Initial Monthly Payment' Section
        public Element initialMonthlyPayment_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[3]/td[3]"));
        public Element initialMonthlyPayment_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[5]/td[3]"));

        public Element initialMonthlyPayment_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[7]/td[3]"));

        public Element initialMonthlyPayment_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[9]/td[3]"));

        public Element initialMonthlyPayment_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[11]/td[3]"));

        public Element initialMonthlyPayment_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[13]/td[3]"));

        public Element initialMonthlyPayment_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[15]/td[3]"));

        public Element initialMonthlyPayment_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[17]/td[3]"));

        public Element initialMonthlyPayment_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[19]/td[3]"));

        public Element initialMonthlyPayment_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[21]/td[3]"));
        #endregion

        #region 'Max LTV' Section
        public Element maxLTV_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[3]/td[4]"));
        public Element maxLTV_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[5]/td[4]"));

        public Element maxLTV_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[7]/td[4]"));

        public Element maxLTV_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[9]/td[4]"));

        public Element maxLTV_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[11]/td[4]"));

        public Element maxLTV_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[13]/td[4]"));

        public Element maxLTV_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[15]/td[4]"));

        public Element maxLTV_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[17]/td[4]"));

        public Element maxLTV_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[19]/td[4]"));

        public Element maxLTV_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[21]/td[4]"));
        #endregion

        #region 'Product Fee' Section
        public Element productFee_1 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[3]/td[5]"));
        public Element productFee_2 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[5]/td[5]"));

        public Element productFee_3 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[7]/td[5]"));

        public Element productFee_4 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[9]/td[5]"));

        public Element productFee_5 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[11]/td[5]"));

        public Element productFee_6 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[13]/td[5]"));

        public Element productFee_7 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[15]/td[5]"));

        public Element productFee_8 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[17]/td[5]"));

        public Element productFee_9 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[19]/td[5]"));

        public Element productFee_10 => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "ProductsGrid_layoutTable"),
            "/tbody/tr[21]/td[5]"));
        #endregion

        #region 'Select' Radio Button Section

        // Required as the if '_userInputProductName' is set to null
        // then no value will be completed. This value will be ignored
        // if '_userInputProductName' is set to a non-null value
        public Element selectFirstProduct => new Element(new ButtonGroup()
            .AddButtonElement("1", FindElement("ProductsGridSelect", "_0")));

        public Element select_1 => new Element(FindElement("ProductsGridSelect", "_0", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_2 => new Element(FindElement("ProductsGridSelect", "_1", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_3 => new Element(FindElement("ProductsGridSelect", "_2", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_4 => new Element(FindElement("ProductsGridSelect", "_3", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_5 => new Element(FindElement("ProductsGridSelect", "_4", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_6 => new Element(FindElement("ProductsGridSelect", "_5", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_7 => new Element(FindElement("ProductsGridSelect", "_6", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_8 => new Element(FindElement("ProductsGridSelect", "_7", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_9 => new Element(FindElement("ProductsGridSelect", "_8", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_10 => new Element(FindElement("ProductsGridSelect", "_9", tag: "input"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        #endregion

        #region Page Link Section
        public Element resultsCount => new Element(FindElement("MC_DevProductChoiceWithDescription1_ctl02_ProductsPager"));

        public string productPagerDefault = "//*[contains(@id,'ProductsPager')]/a[contains(@title,'Page ";
        #endregion

        #endregion


        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

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

    public class ProductSelectionPageData : PageData
    {
        public string _userInputProductName { get; set; } = null;
        
        public string selectFirstProduct { get; set; } = "1";

        #region 'Product Filter' Section
        public string productCategory { get; set; } = null;
        public string rateType { get; set; } = null;
        public string productFeaturesCashBack350 { get; set; } = null;
        public string productFeaturesFreeLegals { get; set; } = null;
        public string productFeaturesFreeValuation { get; set; } = null;
        public string productFeaturesCashBack200 { get; set; } = null;
        public string filter { get; set; } = null;
        #endregion

    }
}
