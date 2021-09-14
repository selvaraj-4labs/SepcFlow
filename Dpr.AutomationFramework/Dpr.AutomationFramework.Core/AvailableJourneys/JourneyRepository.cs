using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys
{
    // Abstract JourneyRepository design.
    public abstract class JourneyRepository
    {
        public abstract List<BasePage> GetPagesFor(TestContext testContext);

        public abstract List<BasePage> GetPagesFor(string journeyName, TestContext testContext);
    }
}
