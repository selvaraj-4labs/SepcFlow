using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class WaitFor
    {
        public Element waitElement { get; set; }
        public List<By> waitElements { get; }
        public int timeToWaitInSeconds { get; } = 0;

        public WaitFor(Element waitElement)
        {
            this.waitElement = waitElement;
            this.waitElements = new List<By>();
        }

        public WaitFor(Element waitElement, int timeToWaitInSeconds)
        {
            this.waitElement = waitElement;
            this.waitElements = new List<By>();
            this.timeToWaitInSeconds = timeToWaitInSeconds;
        }

        public WaitFor AddWaitElement(By waitElement)
        {
            if (waitElements.Count > 3)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "WaitFor.AddWaitElement - cannot add the WaitElement with " +
                    "locator '" + waitElement.ToString() + "' because tha maximum " +
                    "number of waitElements is 4 and the current number of " +
                    "elements is '" + waitElements.Count + "'.");
            }
            this.waitElements.Add(waitElement);

            return this;
        }
    }
}
