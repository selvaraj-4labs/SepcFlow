using System;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class LocatorList
    {
        public List<List<string>> attributeLocatorList { get; set; } = new List<List<string>>();

        public LocatorList Add(string locatorType, string locatorValue)
        {
            List<string> list= new List<string>();
            list.Add(locatorType);
            list.Add(locatorValue);
            attributeLocatorList.Add(list);

            return this;
        }

        internal LocatorList Add(string boLocatorAutomationId)
        {
            throw new NotImplementedException();
        }
    }
}
