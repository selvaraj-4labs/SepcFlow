using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class WholeScenarioData
    {
        public List<Data> dataList = new List<Data>();


        public void AddScenarioData(Data journeyData)
        {
            Data removeItem = null;
            foreach(Data data in dataList)
            {
                if (data.DoesKeyExistInData(journeyData.GetFirstPageName()))
                {
                    removeItem = data;
                    break;
                }
            }
            if (removeItem != null)
            {
                dataList.Remove(removeItem);
            }
            dataList.Add(journeyData);
        }


        public string GetScenarioData(string pageName, string dataItemName)
        {
            Data requiredData = null;
            foreach (Data data in dataList)
            {
                if (data.DoesKeyExistInData(pageName))
                {
                    requiredData = data;
                    break;
                }
            }

            if (requiredData == null)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "WholeScenarioData.GetScenarioData - unable to find data " +
                    "for the journey that contains the page name '" + pageName + "'.");
            }
            return requiredData.GetFor(pageName).GetValueOf(dataItemName);
        }
    }
}
