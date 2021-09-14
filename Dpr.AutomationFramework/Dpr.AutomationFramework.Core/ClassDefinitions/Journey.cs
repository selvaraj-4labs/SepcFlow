using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public abstract class Journey
    {
        public List<BasePage> visitList;
        public Data journeyData;
        public string url;
        public List<List<string>> journeyDataChangeList = new List<List<string>>();
        public BasePage currentPage;
        protected bool logAndOutputInput;

        /// <summary>
        /// Abstract version of the InitialiseDriver method.
        /// </summary>
        /// <returns>The instance of journey object.</returns>
        public abstract Journey InitialiseDriver(int timeOutInSeconds);

        /// <summary>
        /// Destroy the driver that is linked to a journey.
        /// </summary>
        public abstract void DestroyDriver();

        /// <summary>
        /// Sets the driver to the scope of the current page.
        /// </summary>
        public abstract void SetCurrenPageDriver();

        /// <summary>
        /// Start the process of automation.
        /// </summary>
        public abstract void Go();

        /// <summary>
        /// Add a page into the journeyList.
        /// </summary>
        /// <param name="pageAddition">The page to be added.</param>
        /// <param name="pageLookout">The page that the 'pageAddition' comes after.</param>
        public void UpdateVisitList(BasePage pageAddition,
            BasePage pageLookout)
        {
            for (int i = 0; i <= visitList.Count - 1; i++)
            {
                if (visitList[i].Equals(pageLookout))
                {
                    visitList.Insert(i + 1, pageAddition);
                }
            }
        }

        /// <summary>
        /// Change the Happy Path Data.
        /// </summary>
        /// <param name="pageClassName">The page that will be updated.</param>
        /// <param name="inputControlName">The element on a page that will be updated.</param>
        /// <param name="newValue">The updated value.</param>
        /// <returns>The journey instance.></returns>
        public Journey ChangeJourneyData(string pageClassName,
            string inputControlName,
            string newValue)
        {
            List<string> journeyChange = new List<string>();
            journeyChange.Add(pageClassName);
            journeyChange.Add(inputControlName);
            journeyChange.Add(newValue);
            journeyDataChangeList.Add(journeyChange);

            return this;
        }

        /// <summary>
        /// Define the page from which automation should start.
        /// </summary>
        /// <param name="url">The URL of the start page.</param>
        /// <returns>The journey instance.</returns>
        public abstract Journey StartFrom(string url);

        /// <summary>
        /// Perform the updates on the journey data.
        /// </summary>
        public void UpdateJourneyData()
        {
            foreach (List<string> sList in journeyDataChangeList)
            {
                MethodInfo dataGetForCall = journeyData.GetType().GetMethod("GetFor");
                dynamic dataGetForCallReturn = dataGetForCall.Invoke(
                    journeyData, 
                    new object[] {sList.ElementAt(0) });
                dynamic a = dataGetForCallReturn.GetType();
                dynamic b = a.GetMethod("SetValueOf");
                dynamic c = b.Invoke(dataGetForCallReturn,
                    new object[]
                    {
                        sList.ElementAt(1),
                        sList.ElementAt(2)
                    });
            }
            journeyDataChangeList.Clear();
        }

        /// <summary>
        /// Sets the pages of the visitList.
        /// </summary>
        /// <param name="pages">The list of pages.</param>
        /// <returns>The updated journey object.</returns>
        public Journey Visit(List<BasePage> pages)
        {
            this.visitList = pages;
            foreach (BasePage p in pages)
            {
                journeyData.AddPageDataLink(p.className, p.correspondingDataClass);
            }
            UpdateJourneyData();
            return this;
        }
    }
}
