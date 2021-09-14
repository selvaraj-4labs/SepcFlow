using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.ILL
{
    public class CBS_ILL05 : WebBasePage
    {
        private readonly TestContext _testContext;

        public CBS_ILL05(TestContext testContext)
        {
            _testContext = testContext;
            pageLoadedElement = repaymentType;
            correspondingDataClass = new CBS_ILL05Data().GetType();
            textName = "CBS Product Selection Page";
        }

        #region Locators Section

        #region 'Loan Details' Section
        public Element repaymentType => new Element(FindElement("ctl00_RepaymentType-button")).SetCompletePageFlag(false);
        public Element declaredTermYears => new Element(FindElement("txtRequestedLoanTerm", tag: "input")).SetCompletePageFlag(false);
        public Element declaredTermMonths => new Element(FindElement("txtRequestedLoanMonths", tag: "input")).SetCompletePageFlag(false);
        public Element loanAmount => new Element(FindElement("LoanAmount", tag: "input")).SetCompletePageFlag(false);
        public Element capitalAndInterestAmount => new Element(FindElement("CapAndIntAmount", tag: "input")).SetCompletePageFlag(false);
        public Element interestOnlyAmount => new Element(FindElement("InterestOnlyAmount", tag: "input")).SetCompletePageFlag(false);
        #endregion

        #region 'Product Filter' Section
        public Element productCategory => new Element(FindElement("ctl00_ProductRange", tag: "select"));
        public Element rateType => new Element(FindElement("ctl00_InterestRateOption", tag: "select"));
        public Element prodcutFeatures => new Element(FindElement("item0_FeatureFilterPackSelect", tag: "input"));
        public Element filter => new Element(FindElement("FindButton", "!My", tag: "input"));
        #endregion

        #region 'Available Products' Section
        public Element productTableRowCounter => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MC_ProductChoice1_ctl02_ProductsGrid_layoutTable"),
            "/tbody/tr"));

        #region 'Product Name' Subsection
        public Element productName_1 => new Element(FindElement("ProductName_0"));
        public Element productName_2 => new Element(FindElement("ProductName_1"));
        public Element productName_3 => new Element(FindElement("ProductName_2"));
        public Element productName_4 => new Element(FindElement("ProductName_3"));
        public Element productName_5 => new Element(FindElement("ProductName_4"));
        public Element productName_6 => new Element(FindElement("ProductName_5"));
        public Element productName_7 => new Element(FindElement("ProductName_6"));
        public Element productName_8 => new Element(FindElement("ProductName_7"));
        public Element productName_9 => new Element(FindElement("ProductName_8"));
        public Element productName_10 => new Element(FindElement("ProductName_9"));
        #endregion

        #region 'Rate Type' Subsection
        public Element rateType_1 => new Element(FindElement("RateType_0"));
        public Element rateType_2 => new Element(FindElement("RateType_1"));
        public Element rateType_3 => new Element(FindElement("RateType_2"));
        public Element rateType_4 => new Element(FindElement("RateType_3"));
        public Element rateType_5 => new Element(FindElement("RateType_4"));
        public Element rateType_6 => new Element(FindElement("RateType_5"));
        public Element rateType_7 => new Element(FindElement("RateType_6"));
        public Element rateType_8 => new Element(FindElement("RateType_7"));
        public Element rateType_9 => new Element(FindElement("RateType_8"));
        public Element rateType_10 => new Element(FindElement("RateType_9"));
        #endregion

        #region 'Initial Rate' Subsection
        public Element initialRate_1 => new Element(FindElement("InitialRate_0"));
        public Element initialRate_2 => new Element(FindElement("InitialRate_1"));
        public Element initialRate_3 => new Element(FindElement("InitialRate_2"));
        public Element initialRate_4 => new Element(FindElement("InitialRate_3"));
        public Element initialRate_5 => new Element(FindElement("InitialRate_4"));
        public Element initialRate_6 => new Element(FindElement("InitialRate_5"));
        public Element initialRate_7 => new Element(FindElement("InitialRate_6"));
        public Element initialRate_8 => new Element(FindElement("InitialRate_7"));
        public Element initialRate_9 => new Element(FindElement("InitialRate_8"));
        public Element initialRate_10 => new Element(FindElement("InitialRate_9"));
        #endregion

        #region 'Initial Monthly Payment' Subsection
        public Element initialMonthlyPayment_1 => new Element(FindElement("MonthlyPayment_0"));
        public Element initialMonthlyPayment_2 => new Element(FindElement("MonthlyPayment_1"));
        public Element initialMonthlyPayment_3 => new Element(FindElement("MonthlyPayment_2"));
        public Element initialMonthlyPayment_4 => new Element(FindElement("MonthlyPayment_3"));
        public Element initialMonthlyPayment_5 => new Element(FindElement("MonthlyPayment_4"));
        public Element initialMonthlyPayment_6 => new Element(FindElement("MonthlyPayment_5"));
        public Element initialMonthlyPayment_7 => new Element(FindElement("MonthlyPayment_6"));
        public Element initialMonthlyPayment_8 => new Element(FindElement("MonthlyPayment_7"));
        public Element initialMonthlyPayment_9 => new Element(FindElement("MonthlyPayment_8"));
        public Element initialMonthlyPayment_10 => new Element(FindElement("MonthlyPayment_9"));
        #endregion

        #region 'Max LTV' Subsection
        public Element maxLTV_1 => new Element(FindElement("RiskScheme_0"));
        public Element maxLTV_2 => new Element(FindElement("RiskScheme_1"));
        public Element maxLTV_3 => new Element(FindElement("RiskScheme_2"));
        public Element maxLTV_4 => new Element(FindElement("RiskScheme_3"));
        public Element maxLTV_5 => new Element(FindElement("RiskScheme_4"));
        public Element maxLTV_6 => new Element(FindElement("RiskScheme_5"));
        public Element maxLTV_7 => new Element(FindElement("RiskScheme_6"));
        public Element maxLTV_8 => new Element(FindElement("RiskScheme_7"));
        public Element maxLTV_9 => new Element(FindElement("RiskScheme_8"));
        public Element maxLTV_10 => new Element(FindElement("RiskScheme_9"));
        #endregion

        #region 'Product Fee' Subsection
        public Element productFee_1 => new Element(FindElement("BookingFee_0"));
        public Element productFee_2 => new Element(FindElement("BookingFee_1"));
        public Element productFee_3 => new Element(FindElement("BookingFee_2"));
        public Element productFee_4 => new Element(FindElement("BookingFee_3"));
        public Element productFee_5 => new Element(FindElement("BookingFee_4"));
        public Element productFee_6 => new Element(FindElement("BookingFee_5"));
        public Element productFee_7 => new Element(FindElement("BookingFee_6"));
        public Element productFee_8 => new Element(FindElement("BookingFee_7"));
        public Element productFee_9 => new Element(FindElement("BookingFee_8"));
        public Element productFee_10 => new Element(FindElement("BookingFee_9"));
        #endregion

        #region 'Select' Subsection
        public Element selectFirstProduct => new Element(new ButtonGroup()
            .AddButtonElement("1", FindElement("ProductsGridSelect", "_0")));
        public Element select_1 => new Element(FindElement("ProductsGridSelect_0"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_2 => new Element(FindElement("ProductsGridSelect_1"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_3 => new Element(FindElement("ProductsGridSelect_2"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_4 => new Element(FindElement("ProductsGridSelect_3"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_5 => new Element(FindElement("ProductsGridSelect_4"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_6 => new Element(FindElement("ProductsGridSelect_5"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_7 => new Element(FindElement("ProductsGridSelect_6"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_8 => new Element(FindElement("ProductsGridSelect_7"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_9 => new Element(FindElement("ProductsGridSelect_8"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element select_10 => new Element(FindElement("ProductsGridSelect_9"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        #endregion

        #region Page Link Subsection
        public Element productPagerTab => new Element(FindElement("ProductsPager", tag: "span"));
        public Element pageLink_1 => new Element(FindElement("Page 1", attributeType: Defs.locatorTitle));
        public Element pageLink_2 => new Element(FindElement("Page 2", attributeType: Defs.locatorTitle));
        #endregion

        #endregion

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

        #endregion

        #region Private Method
        private int DeterminePageNumber()
        {
            int numberOfPageLinks = new int();
            List<Element> _pageLinkList = new List<Element>();
            string productPagerString = GetTextFromElement(productPagerTab.locator);

            productPagerString = productPagerString.Substring(productPagerString.Length -1, 1);
            numberOfPageLinks = Convert.ToInt32(productPagerString);

            return numberOfPageLinks;
        }

        private void SelectProduct(Data data)
        {
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

            List<Element> pageLinkList = new List<Element>()
            {
                pageLink_1,
                pageLink_2
            };

            string productNameUserInput = data.GetFor(className)._userInputProductName;

            int numberOfProdcuts = (GetNumberOfElements(productTableRowCounter.locator) - 1) / 2;

            int numberOfProductPages = DeterminePageNumber();

            bool productFoundFlag = false;

            int i = 0;
            do
            {
                for (int j = 0; j < numberOfProdcuts; j++)
                {
                    string rowProductName = GetTextFromElement(NameBtnArray[j, 1].locator);

                    if (rowProductName == productNameUserInput)
                    {
                        CompleteElement(" ", NameBtnArray[j,0].locator);
                        productFoundFlag = true;
                        break;
                    }
                }

                if (productFoundFlag == false)
                {
                    ClickElement(pageLinkList[i].locator);
                    WaitForNextScreen(select_1);
                }
                i++;
            } while (i < numberOfProductPages && productFoundFlag == false);

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

        #region Complete Page Override
        public override void CompletePage(
            IWebDriver driver,
            Data data,
            bool continueToNextPageFlag = true,
            bool logAndOutputInput = false)
        {
            if (data.GetFor(className)._userInputProductName == null)
            {
                base.CompletePage(
                    driver,
                    data,
                    continueToNextPageFlag = true,
                    logAndOutputInput = false);
                return;
            }

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

    public class CBS_ILL05Data : PageData
    {
        public string _userInputProductName { get; set; } = null;

        public string selectFirstProduct { get; set; } = "1";
    }
}
