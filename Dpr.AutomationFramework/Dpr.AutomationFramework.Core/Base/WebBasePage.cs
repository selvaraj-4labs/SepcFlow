using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base
{
    public abstract class WebBasePage : BasePage
    {

        #region Paramter Definition / 'WebBasePage' Constructor


       public static By applicationErrorLocator = 
            By.XPath("//*[contains(text(),'Application Error')]");

        public Element saveBtn => new Element(FindElement("btnSave"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element backBtn => new Element(FindElement("Previous"))
         .SetCompletePageFlag(false)
         .SetIsButtonFlag(true);

        public bool displayedAfterNextPageBackBtn = true;

        public Element passDecisionMessageBox;

        public Element failDecisionMessageBox;
        
        public Element decisionBox;


        public IWebDriver driver { get; set; }


        public string passExpectedMessage;

        public string failExpectedMessage;
        
        public string javascriptPageNavigator { set; get; }


        public bool specialPageValidationRequired { set; get; } = false;

  
        public bool validateAllRadioButtonCombinations { set; get; } = false;


        public static string validationXpathTemplate =
            "//*[contains(@id, 'ValidationSummary')]/ul/li[ITERATEME]";

        public TestContext testContext;

        public WebBasePage()
        {
            #region Savings Specific
            passExpectedMessage = null;
            failExpectedMessage = null;
            passDecisionMessageBox = null;
            failDecisionMessageBox = null;
            #endregion

            #region Originations Specfic
            decisionBox = null;
            #endregion
        }

        #endregion

        #region Abstract Method Definition

        /// <summary>
        /// Click the element specified.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public override void ClickElement(By elementLocator)
        {
            GetUniqueInputElement(elementLocator).Click();
        }

        /// <summary>
        /// Higher level function that determines how to complete an element.
        /// </summary>
        /// <param name="value">The value with which complete the element. </param>
        /// <param name="locator">Used to locate the element (defined in Page Objects).</param>
        public override void CompleteElement(string value, By locator)
        {
            IWebElement element = GetUniqueInputElement(locator);
            string attributeType = element.GetAttribute("type");
            if (element.TagName.ToLower() != "select")
            {
                switch (attributeType)
                {
                    case "textarea":
                    case "password":
                    case "text":
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "completing with '" + value + "'");
                        }
                        element.Clear();
                        element.Click();
                        element.SendKeys(Keys.Delete);

                        // Break long strings down to blocks of 50 characters 
                        // else webdriver sometimes times out
                        if (value.Length > 50)
                        {
                            int currentStartIndex = 0;
                            List<string> inputTextList = new List<string>();
                            do
                            {
                                if (currentStartIndex + 50 > value.Length - 1)
                                {
                                    inputTextList.Add(value.Substring(
                                        currentStartIndex,
                                        value.Length - currentStartIndex));
                                }
                                else
                                {
                                    inputTextList.Add(value.Substring(
                                        currentStartIndex,
                                        50));
                                }
                                currentStartIndex += 50;
                            } while (currentStartIndex < value.Length);
                            foreach (string s in inputTextList)
                            {
                                element.SendKeys(s);
                            }
                        }
                        else
                        {
                            element.SendKeys(value);
                        }

                        // TEMP COMMENT OUT FOR CBS. REPLACE FOR TEC
                        //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
                        //jse.ExecuteScript("arguments[0].focus(); arguments[0].blur(); return true", element);
                        //driver.FindElement(By.Id("container")).Click();
                        break;

                    case "checkbox":
                        if ((value == Defs.checkBoxSelected && element.Selected == false) ||
                            (value == Defs.checkBoxNotSelected && element.Selected == true))
                        {
                            if (logAndOutputInput)
                            {
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "clicking");
                            }
                            element.SendKeys(Keys.Space);
                        }
                        break;

                    case "radio":
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "clicking");
                        }
                        element.SendKeys(Keys.Space);
                        break;

                    case "submit":
                    case "button":
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "clicking");
                        }
                        ClickElement(locator);
                        break;

                    default:
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "clicking");
                        }
                        ClickElement(locator);
                        break;
                }
            }
            else if (element.TagName.ToLower() == "select")
            {
                SelectElementFromLookup(element, value);
            }
            else if (element.TagName.ToLower() == "textarea")
            {
                element.Clear();
                element.Click();
                element.SendKeys(Keys.Delete);
                element.SendKeys(value);
            }

            try
            {
                string drTitle = driver.Title;
            }
            catch (UnhandledAlertException)
            {
                driver.SwitchTo().Alert().Accept();
                driver.SwitchTo().DefaultContent();
            }
        }

        /// <summary>
        /// Right click the element located at 'elemenetLocator'.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public override void ContextClickElement(By elementLocator)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Higher level function that determines whether the
        /// conditions for a given element have been met in order
        /// to complete it correctly.
        /// </summary>
        /// <param name="expectedValue">The value that an element 'defaults' to.</param>
        /// <param name="condElement">The element with conditions applied to it.</param>
        /// <param name="data">Contants the data for the currect journey.</param>
        public override void CompleteElement(string expectedValue,
            Element condElement,
            Data data)
        {
            bool areConditionsMet = false;

            if (expectedValue == null && !condElement.GetIsButton())
            {
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(), 
                        "not completing because no data provided for this element");
                }
            }
            else
            {
                if (condElement.condListList != null)
                {
                    areConditionsMet = AreElementConditionsMet(condElement, data);
                    if (!areConditionsMet && logAndOutputInput)
                    {
                        ReportGenerator.AddNotes(
                            Thread.CurrentThread.ManagedThreadId.ToString(),
                            "not completing because conditions for this element" +
                            " to display are not met");
                    }
                        
                }
                if (condElement.condListList == null || areConditionsMet)
                {
                    if (condElement.locator != null)
                    {
                        if (condElement.buttonPressRequiredIfRepeater != null &&
                                (IsElementDisplayed(condElement, true) == false))
                        {
                            ClickElement(condElement.buttonPressRequiredIfRepeater);
                            if (logAndOutputInput)
                            {
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "clicking pre req button requirement...");
                            } 
                        }
                        CompleteElement(expectedValue, condElement.locator);
                    }

                    else if (condElement.radioButton != null)
                    {
                        if (condElement.buttonPressRequiredIfRepeater != null &&
                            IsElementDisplayed(condElement.radioButton.radioButtonOptions.ElementAt(0).locator, true) == false)
                        {
                            ClickElement(condElement.buttonPressRequiredIfRepeater);
                            if (logAndOutputInput)
                            {
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "clicking pre req button requirement...");
                            }    
                        }
                        CompleteElement(expectedValue, condElement.radioButton);
                    }

                    else if (condElement.buttonGroup != null)
                    {
                        if (condElement.buttonPressRequiredIfRepeater != null &&
                            IsElementDisplayed(condElement.buttonGroup.buttonOptions.ElementAt(0).locator, true) == false)
                        {
                            ClickElement(condElement.buttonPressRequiredIfRepeater);
                            if (logAndOutputInput)
                            {
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "clicking pre req button requirement...");
                            }
                        }

                        CompleteElement(expectedValue, condElement.buttonGroup);
                    }

                    else
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "Page: '" + className + "'. The element '" + nameof(condElement) + 
                            "' is malformed. It is not set up as a standard element, radio " +
                            "button or button group. Each of these properties currently resolves " +
                            "to null. Please review this element in the POM.");
                    }
                }
            }
        }

        /// <summary>
        /// Used to cause the WebDriver to wait for a set amount of time
        /// or until certain elements have appeared.
        /// </summary>
        /// <param name="primaryTardyElementLocator">The first element to wait for.</param>
        /// <param name="secondaryTardyElementLocator">The second element to wait for.</param>
        /// <param name="tertiaryTardyElementLocator">The third element to wait for.</param>
        /// <param name="timeoutInSeconds">The maximum amount of time to wait.</param>
        /// <returns>A flag that determines whether the element has been located.</returns>
        public override bool ExplicitWait(
            By primaryTardyElementLocator,
            By secondaryTardyElementLocator = null,
            By tertiaryTardyElementLocator = null,
            int timeoutInSeconds = 45)
        {
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 0);
            WebDriverWait wait = new WebDriverWait(driver,
                new TimeSpan(0, 0, timeoutInSeconds));
            bool elementFoundFlag = wait.Until(condition =>
            {
                bool foundFlag = false;
                try
                {
                    foundFlag = IsElementDisplayed(primaryTardyElementLocator);

                }
                catch (StaleElementReferenceException)
                {
                }
                catch (NoSuchElementException)
                {
                }
                if (secondaryTardyElementLocator != null && foundFlag == false)
                {
                    try
                    {
                        foundFlag = IsElementDisplayed(secondaryTardyElementLocator);
                    }
                    catch (StaleElementReferenceException) { }
                    catch (NoSuchElementException) { }
                    if (tertiaryTardyElementLocator != null && foundFlag == false)
                    {
                        try
                        {
                            foundFlag = IsElementDisplayed(tertiaryTardyElementLocator);
                        }
                        catch (StaleElementReferenceException) { }
                        catch (NoSuchElementException) { }
                    }
                }
                return foundFlag;
            });
            driver.Manage().Timeouts().ImplicitWait = 
                new TimeSpan(0, 0, 45);
            return elementFoundFlag;
        }

        /// <summary>
        /// Return the number of elements that have been located using
        /// the locator.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <returns>The number of elements found using the given locator.</returns>
        public override int GetNumberOfElements(By elementLocator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            int returnNum = driver.FindElements(elementLocator).Count;
            driver.Manage().Timeouts().ImplicitWait = 
                TimeSpan.FromSeconds(45);
            return returnNum;
        }

        /// <summary>
        /// Retrieve the text from the element.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <returns>Returns the text from the elemen in string form.</returns>
        public override string GetTextFromElement(By elementLocator)
        {
            string returnText = null;
            IWebElement element = GetUniqueInputElement(elementLocator);

            if (element.TagName == "input" &&
                element.GetAttribute("type") == "text")
            {
                returnText = element.Text;
                returnText = element.GetAttribute("value");
            }
            else if (element.TagName != "input")
            {
                returnText = element.Text;
            }

            if (returnText == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. No text has been returned from " +
                    "the element with locator '" + elementLocator.ToString() + 
                    "'." + " Please review this element in the POM");
            } 
            return returnText;
        }

        /// <summary>
        /// Determines whether an element is displayed on the portal.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <param name="isInputElement">A flag to determine whether the element in question can recieve input.</param>
        /// <returns>A boolean flag that represents whether the element has been found.</returns>
        public override bool IsElementDisplayed(
            By elementLocator, 
            bool isInputElement = false)
        {
            if (isInputElement == false)
            {
                return GetNumberOfElements(elementLocator) > 0 &&
                    (driver.FindElement(elementLocator).Displayed == true || 
                    (driver.FindElement(elementLocator).Displayed == false &&
                        driver.FindElement(elementLocator).Size.Height > 0));
            }
            else
            {
                return GetNumberOfElements(elementLocator) > 0 &&
                    (GetUniqueInputElement(elementLocator,0).Displayed == true || 
                    (GetUniqueInputElement(elementLocator,0).Displayed == false && 
                        GetUniqueInputElement(elementLocator,0).Size.Height > 0));
            }
        }

        /// <summary>
        /// Determines whether an element is displayed on the portal.
        /// </summary>
        /// <param name="element">Used to locate the element (defined in Page Objects).</param>
        /// <param name="isInputElement">A flag to determine whether the element in question can recieve input.</param>
        /// <returns>A boolean flag that represents whether the element has been found.</returns>
        public override bool IsElementDisplayed(
            Element element, 
            bool isInputElement = false)
        {
            bool returnBool = false;
            if (element.locator != null)
            {
                returnBool = IsElementDisplayed(element.locator, isInputElement);
            }
            else if (element.radioButton!=null)
            {
                returnBool = IsElementDisplayed(
                    element.radioButton.radioButtonOptions.ElementAt(0).locator,
                    isInputElement);
            }
            else if (element.buttonGroup != null)
            {
                returnBool = IsElementDisplayed(
                    element.buttonGroup.buttonOptions.ElementAt(0).locator,
                    isInputElement);
            }
            return returnBool;
        }

        /// <summary>
        /// Assign the currently operation driver to the instance of the journey.
        /// </summary>
        /// <param name="driver">The driver in question</param>
        public override void SetDriver(object driver)
        {
            if (driver.GetType().Name != "ChromeDriver")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Method: 'WebBasePage.SetDriver(object driver)'. Driver " +
                    "type supplied :'" + driver.GetType().ToString() + "', " +
                    "but required driver type is 'ChromeDriver'.");
            }
            this.driver = (IWebDriver)driver;
        }

        /// <summary>
        /// Wait until an element is displayed.
        /// Used to wait for a webpage to display.
        /// </summary>
        /// <param name="waitDependentElement">The locator of the element on 
        /// the webpage that is used to verify the page is displayed.</param>
        public override void WaitForNextScreen(By waitDependentElement)
        {
            bool controlFound = ExplicitWait(
                waitDependentElement,
                applicationErrorLocator,
                timeoutInSeconds: 45);

            if (controlFound == true)
            {
                if (GetNumberOfElements(applicationErrorLocator) != 0)
                {
                    new TestEnder().FailEnd(Defs.failNonAssert,
                        "Application Error is displayed - page '" + 
                        this.className + "' was expected.", driver, testContext);
                }
            }
            else
            {
                if (!controlFound)
                {
                    new TestEnder().FailEnd(
                        Defs.failAssert, 
                        "The '" + this.className + 
                            "' page was not displayed", 
                        driver, testContext);
                }
            }
        }

        /// <summary>
        /// Wait until an element is displayed.
        /// Used to wait for a webpage to display.
        /// </summary>
        /// <param name="waitDependentElement">The element on the 
        /// webpage that is used to verify the page is displayed.</param>
        public override void WaitForNextScreen(Element waitDependentElement)
        {
            if (waitDependentElement.radioButton != null)
            {
                WaitForNextScreen(
                    waitDependentElement.radioButton.radioButtonOptions.ElementAt(0).locator);
            }
            else if (waitDependentElement.buttonGroup != null)
            {
                WaitForNextScreen(
                    waitDependentElement.buttonGroup.buttonOptions.ElementAt(0).locator);
            }
            else if (waitDependentElement.locator != null)
            {
                WaitForNextScreen(waitDependentElement.locator);
            }
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, "Page: '" + className + 
                    "'. The element '" + nameof(waitDependentElement) + 
                    "' is malformed. " + "It is not set up as a standard " +
                    "element, radio button or button group. Each of these " +
                    "properties currently resolves to null. " + 
                    "Please review this element in the POM.");
            }
        }
        #endregion

        #region Web Page Specific Method Definitions

        /// <summary>
        /// Double click a web element.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public override void DoubleClickElement(By elementLocator)
        { 
            throw new NotImplementedException(); 
        }

        /// <summary>
        /// Click an element with conditions applied to it.
        /// NOTE: Only will be clikced if the element conditions have been met.
        /// </summary>
        /// <param name="condElement">Conditional element in question.</param>
        /// <param name="data">The data used in the journey instance.</param>
        public void ClickElement(Element condElement, Data data)
        {
            bool areConditionsMet = false;

            if (condElement.condListList != null) 
            {
                areConditionsMet = AreElementConditionsMet(condElement, data);
            }
            if (condElement.condListList == null || areConditionsMet)
            {
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        "clicking");
                }
                GetUniqueInputElement(condElement.locator).Click();
            }
            else if (logAndOutputInput)
            {
                ReportGenerator.AddNotes(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "not completing because conditions for this element " +
                    "to display are not met");
            }
        }

        /// <summary>
        /// Calls the main version of the 'CompletePage method'.
        /// Sets 'continueToNextPageFlag' to true.
        /// </summary>
        /// <param name="driver">The driver assigned to the journey instance.</param>
        /// <param name="data">The data instance for the current journey.</param>
        public virtual void CompletePage(IWebDriver driver, Data data)
        {
            CompletePage(driver, data, true);
        }

        /// <summary>
        /// Complete the relevant elements defined in the POM.
        /// </summary>
        /// <param name="driver">The driver related to this journey.</param>
        /// <param name="data">The data used in the journey instance. </param>
        /// <param name="continueToNextPageFlag">Used to determine whether the framework should automatically move the driver onto the next page of the portal.</param>
        /// <param name="logAndOutputInput">Used to determine whether the name of the POM class should be logged.</param>
        public virtual void CompletePage(
            IWebDriver driver, 
            Data data, 
            bool continueToNextPageFlag = true, 
            bool logAndOutputInput = false)
        {
            this.logAndOutputInput = logAndOutputInput;
            this.driver = driver;
            if (this.pageCondition == null || 
                AreElementConditionsMet(this.pageCondition.conditions, data) == true)
            {
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        "\r\n<br><b>" + className + "</b>");
                }
                WaitForNextScreen(pageLoadedElement);
                List<Section> sectionTracker = new List<Section>();
                Section currentSection;
                string requiredValue;
                Element currentElement;

                foreach (PropertyInfo prop in this.GetType().GetProperties())
                {
                    string propType = null;
                    currentElement = null;

                    if (prop.PropertyType.Name == "Element")
                    {
                        currentElement = (Element)prop.GetValue(this);
                        if (logAndOutputInput)
                        {
                            //Console.Write("\r\n'{0}'...", prop.Name);
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "\r\n'"+ prop.Name + "'...");

                            if (!currentElement.completePageElement)
                            {
                                //Console.Write("not completing because this is not part of the typical page logic");
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "not completing because this is not " +
                                    "part of the typical page logic");
                            }
                        }
                    }
                    if (prop.PropertyType.Name == "Section" || 
                        prop.PropertyType.Name == "SectionEnd" || 
                        prop.PropertyType.Name == "WaitFor" || 
                        (currentElement != null && currentElement.completePageElement == true))
                    {
                        requiredValue = null;

                        if (!prop.Name.Contains("Btn") && 
                            prop.PropertyType.Name != "WaitFor" && 
                            prop.PropertyType.Name != "Section" && 
                            prop.PropertyType.Name != "SectionEnd")
                        {
                            MethodInfo dataGetForCall = data.GetType().GetMethod("GetFor");
                            dynamic dataGetForCallReturn = dataGetForCall.Invoke(
                                data, 
                                new object[] { className });
                            requiredValue = dataGetForCallReturn.GetType()
                                .GetMethod("GetValueOf")
                                .Invoke(dataGetForCallReturn,
                                new object[]
                                {
                                prop.Name
                                    .Replace("Lookup", "")
                                    .Replace("Rbtn", "")
                                    .Replace("Chbox", "")
                                    .Replace("Box", "")
                                });
                        }
                        propType = prop.PropertyType.Name;

                        if (prop.PropertyType.Name == "SectionEnd")
                        {
                            sectionTracker.RemoveAt(sectionTracker.Count - 1);
                        }

                        else if (prop.PropertyType.Name == "Section")
                        {
                            currentSection = (Section)prop.GetValue(this);
                            currentSection.SetSectionConditionMetStatus(
                                AreElementConditionsMet(currentSection.conditions, data));
                            sectionTracker.Add(currentSection);
                        }

                        else if (sectionTracker.Count == 0 || AreAllSectionConditionsMet(sectionTracker) == true)
                        {

                            switch (propType)
                            {
                                case "RadioButton":
                                    CompleteElement(requiredValue, (RadioButton)prop.GetValue(this));
                                    break;

                                case "By":
                                    if (!prop.Name.Contains("Btn"))
                                    {
                                        CompleteElement(requiredValue, (By)prop.GetValue(this));
                                    }

                                    else
                                    {
                                        ClickElement((By)prop.GetValue(this));
                                    }
                                    break;

                                case "WaitFor":
                                    CompleteElement((WaitFor)prop.GetValue(this), data);
                                    break;

                                case "Element":

                                    if (currentElement.GetIsButton() == true)
                                    {
                                        if (continueToNextPageFlag == true ||
                                            (continueToNextPageFlag == false && currentElement.GetIsPageContinueButton() == false))
                                        {
                                            ClickElement(currentElement, data);
                                        }
                                    }

                                    else
                                    {
                                        CompleteElement(requiredValue, currentElement, data);
                                    }
                                    break;

                                default:
                                    Console.WriteLine("PropertyType incorrect");
                                    break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Retrieve from a webpage an element and determine whether the
        /// locator only returns a single value (1 element found).
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <param name="timeoutInSeconds">The maximum amount of time to wait.</param>
        /// <returns></returns>
        public virtual IWebElement GetUniqueInputElement(
            By elementLocator,
            int timeoutInSeconds = 45)
        {
            ReadOnlyCollection<IWebElement> elementCollection = null;
            List<IWebElement> potentialElementList = new List<IWebElement>();
            IWebElement returnElement = null;

            int timerInterval = 75;
            int timer = 0;
            bool firstIteration = true;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);

            do
            {
                if (firstIteration == false)
                {
                    Thread.Sleep(timerInterval);
                    timer += timerInterval;
                }
                else
                {
                    firstIteration = false;
                }

                elementCollection = driver.FindElements(elementLocator);

                if (elementCollection.Count > 1)
                {
                    potentialElementList = new List<IWebElement>();

                    foreach (IWebElement e in elementCollection)
                    {
                        if (e.TagName.ToLower() == "input" || 
                            e.TagName.ToLower() == "select" || 
                            e.TagName.ToLower() == "a" || 
                            e.TagName.ToLower() == "textarea")
                        {
                            potentialElementList.Add(e);
                        }
                    }

                    if (potentialElementList.Count == 1)
                    {
                        returnElement = potentialElementList.ElementAt(0);
                    }

                    else if (potentialElementList.Count > 1)
                    {
                        int displayNum = 0;
                        IWebElement displayedEle = null;
                        foreach (IWebElement ele in potentialElementList)
                        {
                            if (ele.Displayed)
                            {
                                displayNum++;
                                displayedEle = ele;
                            }
                        }
                        if (displayNum == 1)
                            returnElement = displayedEle;
                    }
                }

                else
                {
                    if (elementCollection.Count == 1)
                    {
                        return elementCollection.ElementAt(0);
                    }
                }
            } while (potentialElementList.Count != 1 && 
                timer < timeoutInSeconds * 1000 && 
                elementCollection.Count != 1 && 
                returnElement == null);

            if (elementCollection.Count == 0 || 
                potentialElementList.Count == 0)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The element with locator '" +
                    elementLocator.ToString() + "' was not found. Please " +
                    "review the locator.", driver, testContext);
            }

            if (potentialElementList.Count > 1 && 
                returnElement == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The locator '" +
                    elementLocator.ToString() + "' returned multiple " +
                    "elements. Please review on POM.", driver, testContext);
            }
            driver.Manage().Timeouts().ImplicitWait = 
                TimeSpan.FromSeconds(45);

            return returnElement;
        }

        /// <summary>
        /// Select a certain lookup value from a lookup list.
        /// </summary>
        /// <param name="lookupElement">The lookup element.</param>
        /// <param name="value">The value of the lookup value.</param>
        public void SelectElementFromLookup(
            IWebElement lookupElement, 
            string value)
        {
            string requiredElementText = null;
            SelectElement lookupSel = new SelectElement(lookupElement);
            if (logAndOutputInput)
            {
                ReportGenerator.AddNotes(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "selecting '" + value + "' from lookup list.");
            }
            foreach (IWebElement option in lookupSel.Options)
            {
                if (AreStringsEqual(option.Text, value))
                { 
                    requiredElementText = option.Text;
                    break;
                }
            }

            //Assert.IsNotNull(requiredElementText, "'{0}' not found in the lookup list!", value);
            //Some lookup lists seem to be affected by implicit wait time for '.SelectByText'. 
            // Do not see any logic behind it. Setting implicit wait to 0 resolves issue.
            if (requiredElementText != null)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
                lookupSel.SelectByText(requiredElementText);
                driver.Manage().Timeouts().ImplicitWait = 
                    TimeSpan.FromSeconds(45);
            }
            else
            {
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        "value provided by data not found in lookup - " +
                        "leaving as default value");
                }
            }
        }
        #endregion

    }
}
