using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.AvailableJourneys.SavingsPortal
{
    public class SavingsJourneyRepository : JourneyRepository
    {
        // PLACEHOLDER
        public override List<BasePage> GetPagesFor(string journeyName, TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return pages;
        }

        public override List<BasePage> GetPagesFor(TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return SavingsJourneyRepo(pages, testContext);
        }



        // -------------------- Journey Definition Repository -------------------- //

        public List<BasePage> SavingsJourneyRepo(List<BasePage> pages, TestContext testContext)
        {

            pages.Add(new ProductSelection());
            pages.Add(new EAP01());
            pages.Add(new EAP02());
            pages.Add(new SaveAndRestore());
            pages.Add(new EAP03());
            pages.Add(new EAP04());
            pages.Add(new EAP04JointApplicant());
            pages.Add(new EAP05());
            pages.Add(new EAP05SecondSig());
            pages.Add(new EAP05ThirdSig());
            pages.Add(new EAP05FourthSig());
            pages.Add(new EAP06());
            pages.Add(new EAP07());
            pages.Add(new EAP07SecondShareholder());
            pages.Add(new EAP07ThirdShareholder());
            pages.Add(new EAP07FourthShareholder());
            //pages.Add(new EAP08());
            pages.Add(new EAP09());
            pages.Add(new EAP12());
            pages.Add(new EAP27(testContext));
            pages.Add(new EAP15());
            pages.Add(new EAP19());
            pages.Add(new EAP25());
            pages.Add(new CreditStub());
            //pages.Add(new AnotherProductOffering());
            pages.Add(new EAP14());
            pages.Add(new DecisionPage());

            return pages;
        }
    }
}
