using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text.RegularExpressions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData
{
    public abstract class PageData
    {
        public IDictionary<string, string> objectProps = new Dictionary<string, string>();


        public string GetValueOf(string varName)
        {
            string returnVal = null;
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (prop.Name == varName)
                {
                    if (prop.GetValue(this) == null)
                    {
                        returnVal = null;
                    }
                    else
                    {
                        returnVal = prop.GetValue(this).ToString();
                    }
                    break;
                }
            }
            return returnVal; 
        }

        public void SetValueOf(string varName, string newValue)
        {
            bool foundFlag = false;
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (prop.Name == varName)
                {
                    foundFlag = true;
                    prop.SetValue(this, newValue ); 
                    break;
                }
            }
            if (foundFlag == false)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Unable to set the value of the data '" + varName + 
                    "' because it cannot be found on this page. Ensure the " +
                    "page name and field name are correct in specflow table. " +
                    "Ensure the data item exists in the POM.");
            }
        }

        public void SetAllDataToNull()
        {
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (prop.PropertyType.Name.ToLower() == "string")
                    prop.SetValue(this, null);
            }
        }


        public string UniqueStringGenerator()
        {
            long dateInTicks = DateTime.Now.Ticks;
            byte[] bytes = BitConverter.GetBytes(dateInTicks);
            string uniqueString = Convert.ToBase64String(bytes)
                .Replace('+', '_')
                .Replace('/', '-')
                .TrimEnd('=');

            // Removing the numbers.
            uniqueString = Regex.Replace(uniqueString, "[^a-zA-Z]", "");

            string guid = System.Guid.NewGuid().ToString("N");
            uniqueString += guid.Substring(0, 4);
            int convertResult;
            string sanitisedUniqueString="";
            string substitutes = "abcdefghij";
            for (int i=0; i<uniqueString.Length; i++)
            {
                if (int.TryParse(uniqueString[i].ToString(), out convertResult))
                {
                    sanitisedUniqueString += substitutes[convertResult];
                }
                else
                 sanitisedUniqueString += uniqueString[i]; 
            }
            ////Add 5 random letters to ensure uniqueness
            //string charList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //int index;
            //Random rnd = new Random();
            //for (int i=0; i<5; i++)
            //{
            //    index = rnd.Next
            //        (0, charList.Length);
            //    uniqueString += charList[index];
            //}

            return sanitisedUniqueString;
        }
    }

    //JourneyData
    public class Data 
    {
        IDictionary<string, PageData> dataObjects { get; set; } = new Dictionary<string, PageData>();
        public string GetFirstPageName()
        {
            return dataObjects.ElementAt(0).Key;
        }

        public void ConcatData(Data dataToConcat)
        {
            this.dataObjects = dataObjects
                .Concat(dataToConcat.dataObjects)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public bool DoesKeyExistInData(string searchKey)
        {
            bool returnBool = false;
            foreach (KeyValuePair<string, PageData> item in dataObjects)
            {
                if (item.Key == searchKey)
                {
                    returnBool = true;
                    break;
                }
            }
            return returnBool;
        }

        public void AddPageDataLink(string className, Type dataObjectType)
        {
            bool dataAlreadyExistsFlag = false;
            foreach (KeyValuePair<string, PageData> item in dataObjects)
            {
                if (item.Key == className)
                {
                    dataAlreadyExistsFlag = true;
                }
            }
            if (dataAlreadyExistsFlag == false)
            {
                dataObjects.Add(className, (PageData)Activator.CreateInstance(dataObjectType));
            }
        }

        public void SetAllDataToNull(string startPage, string endPage)
        {
            bool nullifyFlag = false;
            foreach (KeyValuePair<string, PageData> item in dataObjects)
            {
                if (item.Key == startPage)
                {
                    nullifyFlag = true;
                }
                if (nullifyFlag == true)
                {
                    item.Value.SetAllDataToNull();
                }
                if (item.Key == endPage)
                {
                    break;
                }
            }
        }

        public dynamic GetFor(string className)
        {
            dynamic returnData = null;
            foreach (KeyValuePair<string, PageData> item in dataObjects)
            {
                if (item.Key == className)
                {
                    returnData = item.Value;
                    break;
                }
            }
            if (returnData == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "Data cannot be found for the page '" + className + "'." + 
                    " Please ensure the page name is correct and that data " +
                    "exists for it in the POM.");
            }
            return returnData;
        }

        public void DisplayAll()
        {
            foreach (KeyValuePair<string, PageData> item in dataObjects)
            {
                Console.WriteLine("DATA FOR {0}:", item.Value.GetType().Name);
                foreach (PropertyInfo prop in item.Value.GetType().GetProperties())
                {
                    if (prop.PropertyType.Name.ToLower() == "string")
                    {
                        Console.WriteLine("    {0}  -  {1}", prop.Name, prop.GetValue(item.Value));
                    }
                }
            }
        }
    }
}




