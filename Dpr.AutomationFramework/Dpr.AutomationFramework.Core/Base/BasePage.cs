using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base
{
    public abstract class BasePage
    {

        #region Paramter Definition / 'AbstractBasePage' Constructor
        protected bool logAndOutputInput;

        public string className => GetClassName();
        
        public Type correspondingDataClass;
        
        public Element pageLoadedElement;
        
        public string textName;

        public PageCondition pageCondition { get; set; } = null;
        #endregion


        #region Abstract Methods
        public abstract void ClickElement(By elementLocator);

        public abstract void DoubleClickElement(By elementLocator);

        public abstract void ContextClickElement(By elementLocator);

        public abstract void CompleteElement(string value, By locator);

        public abstract void CompleteElement(
            string expectedValue,
            Element condElement, 
            Data data);

        public abstract bool ExplicitWait(
            By primaryTardyElementLocator,
            By secondaryTardyElementLocator = null,
            By tertiaryTardyElementLocator = null,
            int timeoutInSeconds = 45);

        public abstract int GetNumberOfElements(By elementLocator);

        public abstract string GetTextFromElement(By elementLocator);

        public abstract bool IsElementDisplayed(
            By elementLocator,
            bool isInputElement = false);

        public abstract bool IsElementDisplayed(
            Element element,
            bool isInputElement = false);

        public abstract void SetDriver(object driver);

        public abstract void WaitForNextScreen(By waitDependentElement);

        public abstract void WaitForNextScreen(Element waitDependentElement);
        #endregion


        #region Defined Methods

        public bool AreAllSectionConditionsMet(List<Section> sectionList)
        {
            bool allSectionConditionsMet = true;
            foreach (Section s in sectionList)
            {
                if (s.conditionsMet == false)
                {
                    allSectionConditionsMet = false;
                    break;
                }
            }
            if (!allSectionConditionsMet && logAndOutputInput)
            {
                ReportGenerator.AddNotes(
                    Thread.CurrentThread.ManagedThreadId.ToString(),
                    "not completing because conditions for this " +
                    "element to display are not met");
            }
                
            return allSectionConditionsMet;
        }

        public bool AreElementConditionsMet(Element condElement, Data data)
        {
            bool overallConditionMet = false;
            List<bool> conditionListListResult = new List<bool>();

            foreach (ConditionList conditionList in condElement.condListList)
            {
                bool conditionListMet = true;
                foreach (Condition condition in conditionList.condList)
                {
                    if (condition.conditionType == Defs.conditionTypeEqual && 
                        condition.ElementBy == null)
                    {
                        if (!AreStringsEqual(data.GetFor(condition.elementClassName).GetValueOf(condition.Element), condition.requiredValue))
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionTypeEqual && condition.ElementBy != null)
                    {
                        if (!AreStringsEqual(GetTextFromElement(condition.ElementBy),
                            condition.requiredValue))
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionTypeNotEqual && condition.ElementBy == null)
                    {
                        if (AreStringsEqual(data.GetFor(condition.elementClassName).GetValueOf(condition.Element), condition.requiredValue))
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionTypeCompareYearDifferenceMmYyyy && condition.ElementBy == null)
                    {
                        string elementData = data.GetFor(condition.elementClassName).GetValueOf(condition.Element);
                        int expectedYearDifference = Int32.Parse(condition.requiredValue
                                                    .Replace("<", "")
                                                    .Replace("=", "")
                                                    .Replace(">", ""));

                        double differenceInYears = GetDifferenceInYearsMmYyyy(elementData);

                        //if (condition.requiredValue.Contains("=") && condition.requiredValue.Contains("<") && differenceInYears > expectedYearDifference)
                        //    conditionListMet = false;
                        //else if (condition.requiredValue.Contains("=") && !condition.requiredValue.Contains("<") && differenceInYears != expectedYearDifference)
                        //    conditionListMet = false;
                        //else if (!condition.requiredValue.Contains("=") && condition.requiredValue.Contains(">") && differenceInYears >= expectedYearDifference)
                        //    conditionListMet = false;
                        //else if (condition.requiredValue.Contains("=") && condition.requiredValue.Contains(">") && differenceInYears < expectedYearDifference)
                        //    conditionListMet = false;
                        //Less than or equal to
                        if (condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains("<") && 
                            differenceInYears > expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Less than
                        else if (!condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains("<") && 
                            differenceInYears >= expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Equals
                        else if (condition.requiredValue.Contains("=") && 
                            !condition.requiredValue.Contains("<") && 
                            differenceInYears != expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Greater than
                        else if (!condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains(">") &&
                            differenceInYears <= expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Greater than or equal to
                        else if (condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains(">") && 
                            differenceInYears < expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionTypeCompareYearDifferenceDdMmYyyy && condition.ElementBy == null)
                    {
                        string elementData = data.GetFor(condition.elementClassName).GetValueOf(condition.Element);
                        int expectedYearDifference = Int32.Parse(condition.requiredValue
                                                    .Replace("<", "")
                                                    .Replace("=", "")
                                                    .Replace(">", ""));
                        int differenceInYears = GetDifferenceInYearsDdMmYyyy(elementData);

                        //Less than or equal to
                        if (condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains("<") && 
                            differenceInYears > expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                            
                        //Less than
                        else if (!condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains("<") && 
                            differenceInYears >= expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Equals
                        else if (condition.requiredValue.Contains("=") && 
                            !condition.requiredValue.Contains("<") && 
                            !condition.requiredValue.Contains(">") && 
                            differenceInYears != expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Greater than
                        else if (!condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains(">") && 
                            differenceInYears <= expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                        //Greater than or equal to
                        else if (condition.requiredValue.Contains("=") && 
                            condition.requiredValue.Contains(">") && 
                            differenceInYears < expectedYearDifference)
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionTypeNotEqual && condition.ElementBy != null)
                    {
                        if (!AreStringsEqual(GetTextFromElement(condition.ElementBy), condition.requiredValue))
                        {
                            conditionListMet = false;
                        }
                    }
                    else if (condition.conditionType == Defs.conditionIsElementDisplayed)
                    {
                        if (IsElementDisplayed(condition.ElementBy) && 
                            condition.requiredValue == Defs.elementNotDisplayed)
                        {
                            conditionListMet = false;
                        }
                        else if (!IsElementDisplayed(condition.ElementBy) && condition.requiredValue == Defs.elementDisplayed)
                        {
                            conditionListMet = false;
                        }
                            
                    }
                    else
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "Page: '" + className + "'. Element '" +
                            nameof(condElement) + " has the invalid" +
                            "condition type of '" + condition.conditionType +
                            "'. Please review this element on the POM.");

                    }

                }
                conditionListListResult.Add(conditionListMet);
            }
            foreach (bool b in conditionListListResult)
            {
                if (b == true)
                {
                    overallConditionMet = true;
                    break;
                }
            }

            return overallConditionMet;
        }

        public bool AreStringsEqual(string str1, string str2)
        {
            bool returnBool = false;
            if (str1 == null && str2 == null)
            {
                returnBool = true;
            }
            else if (str1 != null && 
                str2 != null && 
                str1.ToLower().Replace(" ", "") == str2.ToLower().Replace(" ", ""))
            {
                returnBool = true;
            }
            return returnBool;
        }

        public void CompleteElement(string expectedValue, ButtonGroup bg)
        {
            bool foundFlag = false;

            foreach (ButtonElement bgOption in bg.buttonOptions)
            {
                if (bgOption.value.ToLower().Replace(" ", "") ==expectedValue.ToLower().Replace(" ", ""))
                {
                    if (logAndOutputInput)
                    {
                        ReportGenerator.AddNotes(
                            Thread.CurrentThread.ManagedThreadId.ToString(),
                            " option '" + expectedValue + "'...");
                    }
                    CompleteElement(expectedValue, bgOption.locator);
                    foundFlag = true;
                    break;
                }
            }

            if (foundFlag == false)
            {
                string availableOptions = "";
                for (int i = 0; i < bg.buttonOptions.Count; i++)
                {
                    if (i != 0)
                        availableOptions += ", ";
                    else if (i == bg.buttonOptions.Count-1)
                        availableOptions += " and ";
                    availableOptions += bg.buttonOptions[i].value;
                    
                }
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The expected value '" + 
                    expectedValue + " is not present in" + "this ButtonGroup." +
                    " Available options for this ButtonGroup are " + availableOptions + ".");
            }
        }

        public void CompleteElement(string expectedValue, RadioButton rb)
        {
            bool foundFlag = false;
            int attemptNum = 0;
            do
            {
                attemptNum++;
                foreach (RadioButtonElement rbOption in rb.radioButtonOptions)
                {
                    // If a possible Rbtn option matches the #expectedValue' click on it.
                    if (rbOption.value.ToLower().Replace(" ", "") == expectedValue.ToLower().Replace(" ", ""))
                    {
                        if (logAndOutputInput)
                        {
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                " option '" + expectedValue + "'...");
                        }
                        CompleteElement("true", rbOption.locator);
                        foundFlag = true;
                        break;
                    }
                }
                if (foundFlag == true)
                {
                    break;
                }
                if (foundFlag == false && expectedValue.ToLower() == "true")
                {
                    expectedValue = "yes";
                }
                else if (foundFlag == false && expectedValue.ToLower() == "false")
                {
                    expectedValue = "no";
                }
            } while (foundFlag == false && attemptNum < 2);

            if (foundFlag == false)
            {
                string availableOptions = "";
                for (int i = 0; i < rb.radioButtonOptions.Count; i++)
                {
                    if (i != 0)
                        availableOptions += ", ";
                    else if (i == rb.radioButtonOptions.Count - 1)
                        availableOptions += " and ";
                    availableOptions += rb.radioButtonOptions[i].value;

                }
                new TestEnder().FailEnd(
                    Defs.failNonAssert, "Page: '" + className + "'. The expected" +
                    " value '" + expectedValue + "' is not present in this " +
                    "RadioButton. Available options for this RadioButton are " + 
                    availableOptions + ".");
            }
        }

        public void CompleteElement(WaitFor wait, Data data)
        {
            if (wait.waitElement == null|| 
                wait.waitElement.condListList == null || 
                AreElementConditionsMet(wait.waitElement, data))
            {
                if (wait.waitElements.Count == 1)
                {
                    if (wait.timeToWaitInSeconds == 0)
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0));
                    }
                    else
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0),
                            timeoutInSeconds: wait.timeToWaitInSeconds);
                    }
                }
                else if (wait.waitElements.Count == 2)
                {
                    if (wait.timeToWaitInSeconds == 0)
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0), 
                            wait.waitElements.ElementAt(1));
                    }
                    else
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0),
                            wait.waitElements.ElementAt(1),
                            timeoutInSeconds: wait.timeToWaitInSeconds);
                    }
                }
                else if (wait.waitElements.Count == 3)
                {
                    if (wait.timeToWaitInSeconds == 0)
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0),
                            wait.waitElements.ElementAt(1),
                            wait.waitElements.ElementAt(2));
                    }
                    if (wait.timeToWaitInSeconds == 0)
                    {
                        ExplicitWait(wait.waitElements.ElementAt(0),
                            wait.waitElements.ElementAt(1),
                            wait.waitElements.ElementAt(2),
                            timeoutInSeconds: wait.timeToWaitInSeconds);
                    }
                }
            }
        }

        public By FindElement(LocatorList locatorList, 
            string xpathSuffix = null, 
            string tag = "*")
        {
            string returnXpathText;
            string xpathText = "//"+tag+"[";
            bool firstAttribute = true;
            string atText = "";

            foreach (List<string> s in locatorList.attributeLocatorList)
            { 
                if (AreStringsEqual(s.ElementAt(0), Defs.locatorText))
                {
                    atText = "";
                }
                else
                {
                    atText = "@";
                }
                if (firstAttribute == true)
                {
                    if (s.ElementAt(1).StartsWith("!") && !s.ElementAt(1).StartsWith("!="))
                    {
                        xpathText += "not(contains(" + atText + "" + s.ElementAt(0) + ",'" + s.ElementAt(1).Substring(1) + "'))";
                    }
                    else if (s.ElementAt(1).StartsWith("!"))
                    {
                        xpathText += "not (" + atText + "" + s.ElementAt(0) + "='" + s.ElementAt(1).Substring(2) + "')";
                    }
                    else if (s.ElementAt(1).StartsWith("="))
                    {
                        xpathText += "" + atText + "" + s.ElementAt(0) + "='" + s.ElementAt(1).Substring(1) + "'";
                    }
                    else
                    {
                        xpathText += "contains(" + atText + "" + s.ElementAt(0) + ",'" + s.ElementAt(1) + "')";
                    }
                    firstAttribute = false;
                }

                else
                {
                    if (s.ElementAt(1).StartsWith("!") && !s.ElementAt(1).StartsWith("!="))
                    {
                        xpathText += "and not(contains(" + atText + "" + s.ElementAt(0) + ",'" + s.ElementAt(1).Substring(1) + "'))";
                    }
                    else if (s.ElementAt(1).StartsWith("!"))
                    {
                        xpathText += "and not (" + atText + "" + s.ElementAt(0) + "='" + s.ElementAt(1).Substring(2) + "')";
                    }
                    else if (s.ElementAt(1).StartsWith("="))
                    {
                        xpathText += "and " + atText + "" + s.ElementAt(0) + "='" + s.ElementAt(1).Substring(1) + "'";
                    }
                    else
                    {
                        xpathText += "and contains(" + atText + "" + s.ElementAt(0) + ",'" + s.ElementAt(1) + "')";
                    }
                }
            }

            if (xpathSuffix == null)
            {
                returnXpathText = xpathText + "]";
            }
            else
            {
                returnXpathText = xpathText + "]" + xpathSuffix;
            }

            return By.XPath(returnXpathText);
        }
        
        public virtual By FindElement(string mainLocator, 
            string additionalLocator = null, 
            string additionalLocator2 = null, 
            string additionalLocator3 = null, 
            string attributeType = Defs.locatorId,
            string tag = "*")
        {
            LocatorList locatorList = new LocatorList();

            locatorList.Add(attributeType, mainLocator);

            if (additionalLocator != null)
            {
                locatorList.Add(attributeType, additionalLocator);
                if (additionalLocator2 != null)
                {
                    locatorList.Add(attributeType, additionalLocator2);
                    if (additionalLocator3 != null)
                    {
                        locatorList.Add(attributeType, additionalLocator3);
                    }
                }

            }
            return FindElement(locatorList, tag: tag);
        }
        
        public string GetClassName()
        {
            return GetType().Name;
        }

        private double GetDifferenceInYearsMmYyyy(string date)
        {
            int providedMonth = int.Parse(date.Substring(0, date.IndexOf("/")));
            int providedYear = int.Parse(date.Substring(date.IndexOf("/") + 1, date.Length - 1 - date.IndexOf("/")));
            DateTime today = DateTime.Today;
            int yearDifference = today.Year - providedYear;
            int monthDifference = today.Month - providedMonth;
            double totalDifference = (double)yearDifference + ((double)monthDifference / (double)12);
            return totalDifference;
        }

        private int GetDifferenceInYearsDdMmYyyy(string date)
        {
            DateTime comparisonDate = DateTime.ParseExact(date,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;

            int totalDifference = today.Year - comparisonDate.Year;

            if (comparisonDate.CompareTo(today.AddYears(-totalDifference)) > 0)
            {
                totalDifference--;
            }

            return totalDifference;
        }

        public Element GetPageElement(string elementName)
        {
            Element returnElement = null;
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (prop.PropertyType.Name == "Element")
                {
                    if (prop.Name == elementName)
                    {
                        returnElement = (Element)prop.GetValue(this);
                        break;
                    }
                }
            }
            if (returnElement == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The element '" + elementName +
                    "' cannot be found on this POM page.");
            }
            return returnElement;
        }
        
        public string GetTextFromElement(Element element)
        {
            return GetTextFromElement(element.locator);
        }

        #endregion

    }
}
