using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base
{
    public abstract class AppBasePage : BasePage
    {
        #region Paramter Definition / 'AppBasePage' Constructor

        public WindowsDriver<WindowsElement> driver { get; set; }

        #endregion

        #region Abstract Method Definition

        /// <summary>
        /// Click the element specified.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public override void ClickElement(By elementLocator)
        {
            List<string> paramType = new List<string>();
            paramType.Add(elementLocator.GetType().Name);

            List<object> parameters = new List<object>();
            parameters.Add(elementLocator);

            new ImplicitTimer(this, "ClickElement_Logic", "void", paramType, parameters).Go();
        }

        /// <summary>
        /// The logic that is used to complete a double click on an element.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public void ClickElement_Logic(By elementLocator)
        {
            driver.Mouse.MouseMove(
                GetUniqueInputElement(elementLocator).Coordinates);
            driver.Mouse.Click(null);
        }

        /// <summary>
        /// Higher level function that determines how to complete an element.
        /// </summary>
        /// <param name="value">The value with which complete the element. </param>
        /// <param name="locator">Used to locate the element (defined in Page Objects).</param>
        public override void CompleteElement(string value, By locator)
        {
            List<string> paramType = new List<string>();
            paramType.Add(value.GetType().Name);
            paramType.Add(locator.GetType().Name);

            List<object> parameters = new List<object>();
            parameters.Add(value);
            parameters.Add(locator);


            new ImplicitTimer(this, "CompleteElement_Logic", "void", paramType, parameters).Go();
        }

        /// <summary>
        /// Higher level function that determines whether the
        /// conditions for a given element have been met in order
        /// to complete it correctly.
        /// </summary>
        /// <param name="expectedValue">The value that an element 'defaults' to.</param>
        /// <param name="condElement">The element with conditions applied to it.</param>
        /// <param name="data">Contants the data for the currect journey.</param>
        public override void CompleteElement(
            string expectedValue, 
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
                            "not completing because conditions for this element to display are not met");
                    }
                }

                if (condElement.condListList == null || areConditionsMet)
                {
                    if (condElement.locator != null)
                    {
                        if (condElement.buttonPressRequiredIfRepeater != null &&
                            GetUniqueInputElement(condElement.locator).Displayed == false)
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
                            GetUniqueInputElement(condElement.radioButton.radioButtonOptions.ElementAt(0).locator).Displayed == false)
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
                            GetUniqueInputElement(condElement.buttonGroup.buttonOptions.ElementAt(0).locator).Displayed == false)
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
                            "Page: '" + className + "'. The element '" + 
                            nameof(condElement) + "' is malformed. It " +
                            "is not set up as a standard element, " +
                            "radio button or button group. Each of these " +
                            "properties currently resolves to null. " +
                            "Please review this element in the POM.");

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
            int timeoutInSeconds = 90)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutInSeconds));
            bool elementFoundFlag = wait.Until(condition =>
            {
                bool foundFlag = false;
                try
                {
                    foundFlag = GetNumberOfElements(primaryTardyElementLocator) > 0;
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
                        foundFlag = GetNumberOfElements(secondaryTardyElementLocator) > 0;
                    }
                    catch (StaleElementReferenceException)
                    {
                    }
                    catch (NoSuchElementException)
                    {
                    }
                    if (tertiaryTardyElementLocator != null && foundFlag == false)
                    {
                        try
                        {
                            foundFlag = GetNumberOfElements(tertiaryTardyElementLocator) > 0;
                        }
                        catch (StaleElementReferenceException)
                        {
                        }
                        catch (NoSuchElementException)
                        {
                        }
                    }
                }
                return foundFlag;
            });
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
            ReadOnlyCollection<WindowsElement> elementList;
            string stringXpath;

            if (elementLocator.ToString().ToLower().Contains("xpath"))
            {
                stringXpath = ModifyXPath(elementLocator);
                elementList = driver.FindElementsByXPath(stringXpath);
            }
            else
            {
                stringXpath = ModifyAutomationId(elementLocator);
                elementList = driver.FindElementsByAccessibilityId(stringXpath);
            }
            

            return elementList.Count;
        }

        /// <summary>
        /// Retrieve the text from the element.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <returns>Returns the text from the elemen in string form.</returns>
        public override string GetTextFromElement(By elementLocator)
        {
            string returnText = null;
            WindowsElement element = GetUniqueInputElement(elementLocator);

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
                    "Page: '" + className + "'. No text has been returned " +
                    "from the element with locator '" + 
                    elementLocator.ToString() + "'. Please review this " +
                    "element in the POM");
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
            bool isInputElement)
        {
            return GetNumberOfElements(elementLocator) > 0 &&
                driver.FindElement(elementLocator).Displayed;
        }

        /// <summary>
        /// Determines whether an element is displayed on the portal.
        /// </summary>
        /// <param name="element">Used to locate the element (defined in Page Objects).</param>
        /// <param name="isInputElement">A flag to determine whether the element in question can recieve input.</param>
        /// <returns>A boolean flag that represents whether the element has been found.</returns>
        public override bool IsElementDisplayed(
            Element element, 
            bool isInputElement)
        {
            bool returnBool = false;
            if (element.locator != null)
            {
                returnBool = IsElementDisplayed(element.locator, isInputElement);
            }
            else if (element.radioButton != null)
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
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Page: '" + className + "'. The element '" + nameof(element) + 
                    "' is malformed.It is not set up as a standard element, " +
                    "radio button or button group. Each of these properties " +
                    "currently resolves to null. Please review this element in the POM.");
            }
                

            return returnBool;
        }

        /// <summary>
        /// Assign the currently operation driver to the instance of the journey.
        /// </summary>
        /// <param name="driver">The driver in question</param>
        public override void SetDriver(object driver)
        {
            if (driver.GetType().Name != "WindowsDriver`1")
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Method: 'AppBasePage.SetDriver(object driver)'. Driver " +
                    "type supplied :'" + driver.GetType().ToString() + 
                    "', but required driver type is 'WindowsDriver`1'.");
            }
            this.driver = (WindowsDriver<WindowsElement>)driver;
        }

        /// <summary>
        /// Wait until an element is displayed.
        /// Used to wait for a webpage to display.
        /// </summary>
        /// <param name="waitDependentElement">The locator of the element on 
        /// the webpage that is used to verify the page is displayed.</param>
        public override void WaitForNextScreen(By waitDependentElement)
        {
           // WindowsElement waitElement = GetUniqueInputElement(waitDependentElement);

            List<string> parameterTypes = new List<string>();
            parameterTypes.Add("By");

            List<object> parameters = new List<object>();
            parameters.Add(waitDependentElement);

            new ImplicitTimer(this, "GetUniqueInputElement", "WindowsElement", parameterTypes, parameters).Go();
            /*
            bool controlFound = ExplicitWait(waitDependentElement);

            if (controlFound == false)
            {
                Assert.IsTrue(controlFound, "Expected pages is not displayed");
            }
            */

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(StaticInfo.implicitTimeoutInSeconds));
            //wait.Until(ExpectedConditions.ElementIsVisible(waitDependentElement));
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
                WaitForNextScreen(waitDependentElement.radioButton.radioButtonOptions.ElementAt(0).locator);
            }
            // Update for Page Conditions
            else if (waitDependentElement.buttonGroup != null)
            {
                WaitForNextScreen(waitDependentElement.buttonGroup.buttonOptions.ElementAt(0).locator);
            }
            // --------------------------
            else if (waitDependentElement.locator != null)
            {
                WaitForNextScreen(waitDependentElement.locator);
            }
            else
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Page: '" + className + "'. The element '" + 
                    nameof(waitDependentElement) + "' is malformed. " +
                    "It is not set up as a standard element, radio button or " +
                    "button group. Each of these properties currently resolves to null. " +
                    "Please review this element in the POM.");

            }
        }

        #endregion

        #region Application Page Specific Method Definitions

        /// <summary>
        /// Click an element with conditions applied to it.
        /// NOTE: Only will be clikced if the element conditions have been met.
        /// </summary>
        /// <param name="condElement">Conditional element in question.</param>
        /// <param name="data">The data used in the journey instance.</param>
        /// <param name="doubleClick">A flag that determines whether a double click
        /// should be performed on the element.</param>
        public void ClickElement(Element condElement, 
            Data data, 
            bool doubleClick = false)
        {
            List<string> paramType = new List<string>();
            paramType.Add(condElement.GetType().Name);
            paramType.Add(data.GetType().Name);
            paramType.Add(doubleClick.GetType().Name);

            List<object> parameters = new List<object>();
            parameters.Add(condElement);
            parameters.Add(data);
            parameters.Add(doubleClick);

            new ImplicitTimer(this, "ClickElement_Logic", "void", paramType, parameters).Go();
        }

        /// <summary>
        /// The logic that is used to complete a double click on an element.
        /// </summary>
        /// <param name="condElement">The target conditional element.</param>
        /// <param name="data">The data for the given journey.</param>
        /// <param name="doubleClick">A flag that determines whether a double click is required.</param>
        public void ClickElement_Logic(Element condElement, 
            Data data, 
            bool doubleClick = false)
        {
            bool areConditionsMet = false;

            if (condElement.condListList != null)
            {
                areConditionsMet = AreElementConditionsMet(condElement, data);
            }
            if (condElement.condListList == null || 
                areConditionsMet)
            {
                if (doubleClick == false)
                {
                    // GetUniqueInputElement(condElement.locator).Click();
                    driver.Mouse.MouseMove(GetUniqueInputElement(condElement.locator).Coordinates);
                    if (logAndOutputInput)
                    {
                        ReportGenerator.AddNotes(
                            Thread.CurrentThread.ManagedThreadId.ToString(),
                            "clicking");
                    }
                    driver.Mouse.Click(null);
                }
                else
                {
                    driver.Mouse.MouseMove(GetUniqueInputElement(condElement.locator).Coordinates);
                    if (logAndOutputInput)
                    {
                        ReportGenerator.AddNotes(
                            Thread.CurrentThread.ManagedThreadId.ToString(),
                            "clicking");
                    }
                    driver.Mouse.DoubleClick(null);
                }
            }
            else if (logAndOutputInput)
            {
                ReportGenerator.AddNotes(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "not completing because conditions for this " +
                    "element to display are not met");
            }
        }

        /// <summary>
        /// Double click a web element.
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        public override void DoubleClickElement(By elementLocator)
        {
            List<string> paramType = new List<string>();
            paramType.Add(elementLocator.GetType().Name);

            List<object> parameters = new List<object>();
            parameters.Add(elementLocator);

            new ImplicitTimer(this, "DoubleClickElement_Logic", "void", paramType, parameters).Go();
        }

        /// <summary>
        /// The logic that is used to complete a double click on an element.
        /// </summary>
        /// <param name="elementLocator"></param>
        public void DoubleClickElement_Logic(By elementLocator)
        {
           driver.Mouse.MouseMove(
               GetUniqueInputElement(elementLocator).Coordinates);
           driver.Mouse.DoubleClick(null);
        }

        /// <summary>
        /// Context click (right click) the element.
        /// </summary>
        /// <param name="elementLocator">The target element.</param>
        public override void ContextClickElement(By elementLocator)
        {
            List<string> paramType = new List<string>();
            paramType.Add(elementLocator.GetType().Name);

            List<object> parameters = new List<object>();
            parameters.Add(elementLocator);

            new ImplicitTimer(this, "ContextClickElement_Logic", "void", paramType, parameters).Go();
        }

        /// <summary>
        /// The logic that is used to complete a context click on an element.
        /// </summary>
        /// <param name="elementLocator">The target element.</param>
        public void ContextClickElement_Logic(By elementLocator)
        {
            driver.Mouse.MouseMove(
                GetUniqueInputElement(elementLocator).Coordinates);
            driver.Mouse.ContextClick(null);
        }

        /// <summary>
        /// Determine the method in which to complete a box.
        /// </summary>
        /// <param name="value">The value to complete the element with.</param>
        /// <param name="locator">The locator of the target element.</param>
        public void CompleteElement_Logic(string value, By locator)
        {
            WindowsElement element = GetUniqueInputElement(locator);
            string attributeType = element.GetAttribute("LocalizedControlType");

            switch (attributeType)
            {
                // Textbox.
                case "edit":                
                    if (logAndOutputInput)
                    {
                        ReportGenerator.AddNotes(
                            Thread.CurrentThread.ManagedThreadId.ToString(), 
                            "completing with '" + value + "'");
                    }
                    element.Click();
                    try 
                    { 
                        element.Clear(); 
                    }
                    catch
                    { }
                    element.SendKeys(Keys.Delete);
                    element.SendKeys(value);
                    element.SendKeys(Keys.Enter); 
                    break;

                // Dropdown box.
                case "combo box":           
                    SelectElementFromLookup(locator, value);
                break;

                // Checkbox
                case "check box":           
                    if (value.ToLower() == "true" || 
                        value.ToLower() == "false")
                    {
                        string chBoxValue = element.GetAttribute("Value.Value");
                        if (chBoxValue != null)
                        {
                            if (chBoxValue.ToLower() != value.ToLower())
                            {
                                if (logAndOutputInput)
                                {
                                    ReportGenerator.AddNotes(
                                        Thread.CurrentThread.ManagedThreadId.ToString(), 
                                        "clicking");
                                }
                                element.Click();
                            }
                        }
                        else
                        {
                            chBoxValue = element.GetAttribute("Toggle.ToggleState").ToLower();
                            if (chBoxValue == "0" && value.ToLower() == "true")
                            {
                                if (logAndOutputInput)
                                {
                                    ReportGenerator.AddNotes(
                                        Thread.CurrentThread.ManagedThreadId.ToString(), 
                                        "clicking");
                                }
                                element.Click();
                            }
                            else if (chBoxValue == "1" && value.ToLower() == "false")
                            {
                                if (logAndOutputInput)
                                {
                                    ReportGenerator.AddNotes(
                                        Thread.CurrentThread.ManagedThreadId.ToString(), 
                                        "clicking");
                                }
                                element.Click();
                            }
                        }
                    }
                    else
                    {
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(), 
                                "clicking");
                        }
                        element.Click();
                    }

                    break;
                default:
                    element.Click();
                    break;
            }
        }

        /// <summary>
        /// Calls the main version of the 'CompletePage method'.
        /// Sets 'continueToNextPageFlag' to true.
        /// </summary>
        /// <param name="driver">The driver assigned to the journey instance.</param>
        /// <param name="data">The data instance for the current journey.</param>
        public virtual void CompletePage(WindowsDriver<WindowsElement> driver, Data data)
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
            WindowsDriver<WindowsElement> driver, 
            Data data, 
            bool continueToNextPageFlag = true, 
            bool logAndOutputInput = false)
        {
            if (this.pageCondition == null || 
                AreElementConditionsMet(this.pageCondition.conditions, data) == true)
            {
                this.logAndOutputInput = logAndOutputInput;
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(), 
                        "\r\n<br><b>" + className + "</b>");
                }
                this.driver = driver;
                //WaitForNextScreen(pageLoadedElement);
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
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(), 
                                "\r\n'"+prop.Name+"'...");
                            if (!currentElement.completePageElement)
                            {
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "not completing because this is not part " +
                                    "of the typical page logic");
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

                            requiredValue = dataGetForCallReturn
                                .GetType().GetMethod("GetValueOf").Invoke(dataGetForCallReturn,
                                new object[]
                                {
                                prop.Name.Replace("Lookup", "")
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
                                AreElementConditionsMet(
                                    currentSection.conditions,
                                    data));
                            sectionTracker.Add(currentSection);
                        }

                        else if (sectionTracker.Count == 0 ||
                            AreAllSectionConditionsMet(sectionTracker) == true)
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
                Console.Write("\r\n");
            }
        }

        /// <summary>
        /// Retrieve from a webpage an element and determine whether the
        /// locator only returns a single value (1 element found).
        /// </summary>
        /// <param name="elementLocator">Used to locate the element (defined in Page Objects).</param>
        /// <returns></returns>
        public WindowsElement GetUniqueInputElement(By elementLocator)
        {
            WindowsElement returnElement;
            ReadOnlyCollection<WindowsElement> elementList = null;

            string elementXPath;

            // Creating the 'string version' of the Xpath.
            if (elementLocator.ToString().ToLower().Contains("xpath"))
            {
                elementXPath = ModifyXPath(elementLocator);
                elementList = driver.FindElementsByXPath(elementXPath);
            }
            else
            {
                elementXPath = ModifyAutomationId(elementLocator);
                elementList = driver.FindElementsByAccessibilityId(elementXPath);
            }

            if (elementList.Count == 0)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Page: '" + className + "'. The element with locator '" + 
                    elementLocator.ToString() + "' was not found. " +
                    "Please review the locator.",
                    driver);
            }
            // '2' is chosen as there seems to be an invisible 
            // element that sometimes appears on the ribbon section of Servicing.
            // This causes two elements to be returned rather than one.
            if (elementList.Count > 2)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Page: '" + className + "'. The element with locator '" + 
                    elementLocator.ToString() + "' has returned more than " +
                    "one result. Please ensure the xpath is unique.", driver);
            }

            returnElement = elementList.ElementAt(0);
            return returnElement;
        }

        private string ModifyAutomationId(By idLocator)
        {
            return idLocator.ToString().Substring(7);
        }

        /// <summary>
        /// Retrieve a given attribute from a given element.
        /// </summary>
        /// <param name="locator">The locator for the target element.</param>
        /// <param name="attributeName">The attribute name to be returned.</param>
        /// <returns></returns>
        public string GetAttribute(By locator, string attributeName)
        {
            return GetUniqueInputElement(locator).GetAttribute(attributeName);
        }

        /// <summary>
        /// Modify the input element Xpath created to suit the
        /// Appium method of searching.
        /// </summary>
        /// <param name="xpathLocator">The 'web version' of the xpath locator.</param>
        /// <returns>The 'app version' of the xpath locator.</returns>
        private string ModifyXPath(By xpathLocator)
        {
            string xpathString;
            string temp;

            Dictionary<string, string> xPpathLocators = new Dictionary<string, string>
            {

                {Defs.locatorFor,   Defs.boLocatorFor   },
                {Defs.locatorHref,  Defs.boLocatorHref  },
                {Defs.locatorId,    Defs.boLocatorId    },
                {Defs.locatorName,  Defs.boLocatorName  },
                {Defs.locatorText,  Defs.boLocatorText  },
                {Defs.locatorTitle, Defs.boLocatorTitle },
                {Defs.locatorType,  Defs.boLocatorType  },
                {Defs.locatorValue, Defs.boLocatorValue }
            };


            int startIndex;


            #region Converting XPath to a string and removing unecessary sections.
            temp = xpathLocator.ToString();

            startIndex = temp.IndexOf('/');

            xpathString = temp.Substring(startIndex);
            #endregion


            // In this section, the program loops round the dict 'xPpathLocators'
            // checking to see if the lowercase value is present, if so, it 
            // replaces it with th uppercase version.
            foreach (KeyValuePair<string, string> xpathPair in xPpathLocators)
            {
                string locator = "@" + xpathPair.Key;
                if (xpathString.Contains(locator))
                {
                    xpathString = xpathString.Replace(
                        locator, 
                        "@" + xpathPair.Value);
                }
                
            }
            return xpathString;
        }

        /// <summary>
        /// Select a certain lookup value from a lookup list.
        /// </summary>
        /// <param name="lookupElement">The lookup element.</param>
        /// <param name="value">The value of the lookup value.</param>
        public void SelectElementFromLookup(By lookupElement, string value)
        {
            bool exitLoopFlag = false;
            string sanitisedValue = value.ToLower().Replace(" ", "");
            bool valueCorrectFlag = false;
            ClickElement(lookupElement);
            WindowsElement lookupWindowsElement =
                GetUniqueInputElement(lookupElement);
            string currentValue = " ", previousValue = "";
            lookupWindowsElement.SendKeys(Keys.PageUp);
            if (logAndOutputInput)
            {
                ReportGenerator.AddNotes(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "selecing '" + value + "' from lookup list.");
            }

            do
            {
                previousValue = currentValue;
                currentValue = lookupWindowsElement.GetAttribute("Value.Value");
                //currentValue = lookupWindowsElement.GetAttribute("LegacyIAccessible.Name");
                if (currentValue != null)
                {
                    currentValue = currentValue.ToLower().Replace(" ", "");
                }
                if (currentValue == sanitisedValue)
                {
                    valueCorrectFlag = true;
                }
                else
                {
                    lookupWindowsElement.SendKeys(Keys.Down);
                }
                if (previousValue == currentValue && currentValue != null)
                {
                    exitLoopFlag = true;
                }
            }
            while (valueCorrectFlag != true && exitLoopFlag == false);

            if (exitLoopFlag == true)
            {
                lookupWindowsElement.SendKeys(value);
                currentValue = lookupWindowsElement.GetAttribute("Value.Value");
                if (currentValue != null)
                {
                    currentValue = currentValue.ToLower().Replace(" ", "");
                }
            }
            if (currentValue != sanitisedValue)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The lookup list with locator '" +
                    lookupElement.ToString() + "' does not contain the expected " +
                    "value '" + value + "'.");
            }
            //lookupWindowsElement.SendKeys(Keys.Enter);
            lookupWindowsElement.Click();
        }
        #endregion
    }
}