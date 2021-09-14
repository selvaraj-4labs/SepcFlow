using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP15 : FeesAndFeaturesPage
    {
        private readonly TestContext _testContext;

        public CBS_DIP15(TestContext testContext) : base(testContext)
        {
            _testContext = testContext;
            pageLoadedElement = intermediaryFees;
            correspondingDataClass = new CBS_DIP15Data().GetType();
            textName = "CBS Fees And Features Page";
        }
    }

    public class CBS_DIP15Data : FeesAndFeaturesPageData
    {
    }
}
