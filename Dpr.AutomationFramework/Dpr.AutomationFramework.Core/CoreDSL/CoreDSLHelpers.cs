using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using System;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.CoreDSL
{
   public class CoreDSLHelpers
   {
        #region Defined Methods
        // Old version.
        public string GetDateRelativeToToday(string relativeDate)
        {
            switch (relativeDate.ToLower().Replace(" ", ""))
            {
                case "todaysdate":
                    relativeDate = DateTime.Today.ToString("dd/MM/yyyy");
                    break;

                case "tomorrowsdate":
                    relativeDate = DateTime.Today.AddDays(1)
                        .ToString("dd/MM/yyyy");
                    break;

                case "yesterdaysdate":
                    relativeDate = DateTime.Today.AddDays(-1)
                        .ToString("dd/MM/yyyy");
                    break;

                case "one month from today":
                case "onemonthfromtoday":
                    relativeDate = DateTime.Today.AddMonths(1)
                        .ToString("dd/MM/yyyy");
                    break;

                case "16tomorrow":
                    relativeDate = DateTime.Today.AddYears(-16)
                        .AddDays(1).ToString("dd/MM/yyyy");
                    break;

                case "16today":
                    relativeDate = DateTime.Today.AddYears(-16)
                        .ToString("dd/MM/yyyy");
                    break;

                case "21tomorrow":
                    relativeDate = DateTime.Today.AddYears(-21)
                        .AddDays(1).ToString("dd/MM/yyyy");
                    break;

                case "21today":
                    relativeDate = DateTime.Today.AddYears(-21)
                        .ToString("dd/MM/yyyy");
                    break;

                default:
                    break;
            }
            return relativeDate;
        }

        // New - at some point, update the references that use the old version.
        public string GetDateRelativeToToday(int numberOfUnits, string timeFrame)
        {
            string relativeDate = string.Empty;

            switch (timeFrame.ToLower().Replace(" ", ""))
            {
                case "years":
                    relativeDate = DateTime.Today.AddYears(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                case "months":
                    relativeDate = DateTime.Today.AddMonths(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                case "weeks":
                    relativeDate = DateTime.Today.AddDays(numberOfUnits * 7).ToString("dd/MM/yyyy");
                    break;

                case "days":
                    relativeDate = DateTime.Today.AddDays(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                case "hours":
                    relativeDate = DateTime.Today.AddHours(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                case "minutes":
                    relativeDate = DateTime.Today.AddMinutes(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                case "seconds":
                    relativeDate = DateTime.Today.AddSeconds(numberOfUnits).ToString("dd/MM/yyyy");
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "GetDateRelativeToToday: The time frame " + timeFrame +
                        " is not an acceptable type, please review.");
                    break;
            }
            return relativeDate;
        }

        /// <summary>
        /// Capitalises each of the leading characters of a string 
        /// (leaves the rest as they are).
        /// NOTE: 
        /// Did not use '.Capitalise()' due to that method
        /// converting the rest of the letters to lower case.
        /// </summary>
        /// <param name="stringToCapitalise">The string to 'capitalise'</param>
        /// <returns>A sanitised string</returns>
        public string CapitaliseFirstChar(string stringToCapitalise)
        {
            char[] stringArray = stringToCapitalise.ToCharArray();

            if (stringArray.Length >= 1)
            {
                if (char.IsLower(stringArray[0]))
                {
                    stringArray[0] = char.ToUpper(stringArray[0]);
                }
            }

            // Scan through the letters, checking for spaces.  
            for (int i = 1; i < stringArray.Length; i++)
            {
                if (stringArray[i - 1] == ' ')
                {
                    if (char.IsLower(stringArray[i]))
                    {
                        stringArray[i] = char.ToUpper(stringArray[i]);
                    }
                }
            }
            return new string(stringArray);
        }

        /// <summary>
        /// Converts the ordinal number of the account to an integer
        /// </summary>
        /// <param name="whichAccount">The ordinal number of the account</param>
        /// <returns>An integer value represening the ordinal value</returns>
        public int GetWhichIterationOfAccount(string whichAccount)
        {
            int acctNum = -1;
            switch (whichAccount.ToLower())
            {
                case "1st":
                case "first":
                    acctNum = 0;
                    break;

                case "2nd":
                case "second":
                    acctNum = 1;
                    break;

                case "3rd":
                case "third":
                    acctNum = 2;
                    break;

                case "4th":
                case "fourth":
                    acctNum = 3;
                    break;

                case "5th":
                case "fifth":
                    acctNum = 4;
                    break;

                case "6th":
                case "sixth":
                    acctNum = 5;
                    break;

                case "7th":
                case "seventh":
                    acctNum = 6;
                    break;

                case "8th":
                case "eighth":
                    acctNum = 7;
                    break;

                case "9th":
                case "ninth":
                    acctNum = 8;
                    break;

                case "10th":
                case "tenth":
                    acctNum = 9;
                    break;

                default:
                    new TestEnder().FailEnd(
                        Defs.failNonAssert,
                        "The '" + whichAccount + "' account is not valid. " +
                        "Valid options are: 1st, 2nd, 3rd, 4th, 5th, 6th, " +
                        "7th, 8th, 9th.");
                    break;
            }

            return acctNum;
        }

        public (List<BasePage>, List<BasePage>) SeparateVisitList(List<BasePage> wholeVisitList, string pageName)
        {
            List<BasePage> currentVisitList = new List<BasePage>();
            List<BasePage> remainingVisitList = new List<BasePage>();
            bool reachedPageFlag = false;

            foreach (BasePage page in wholeVisitList)
            {
                if (page.className == pageName)
                {
                    reachedPageFlag = true;
                }
                if (reachedPageFlag == false)
                {
                    currentVisitList.Add(page);
                }
                else
                {
                    remainingVisitList.Add(page);
                }
            }
            if (reachedPageFlag == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "The page '" + pageName + "' does not exist in the current " +
                    "journey. Please verify the page name is correct.");
            }   
            return (currentVisitList, remainingVisitList);
        }
        #endregion
    }
}
