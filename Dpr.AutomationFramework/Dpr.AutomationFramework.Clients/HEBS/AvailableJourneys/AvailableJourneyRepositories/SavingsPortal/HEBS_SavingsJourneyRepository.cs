using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableJourneys.AvailableJourneyRepositories.SavingsPortal
{
    public class HEBS_SavingsJourneyRepository : JourneyRepository
    {
        public override List<BasePage> GetPagesFor(string journeyName, TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return pages;
        }

        public override List<BasePage> GetPagesFor(TestContext testContext)
        {
            List<BasePage> pages = new List<BasePage>();
            return HEBS_SavingsJourneyRepo(pages, testContext);
        }

        // -------------------- Journey Definition Repository -------------------- //

        public List<BasePage> HEBS_SavingsJourneyRepo(List<BasePage> pages, TestContext testContext)
        {
            pages.Add(new HEBS_EAP00());
            pages.Add(new HEBS_EAP01());
            pages.Add(new HEBS_EAP02());
            pages.Add(new HEBS_SaveAndRestore());
            pages.Add(new HEBS_EAP03());
            pages.Add(new HEBS_EAP04());
            pages.Add(new HEBS_EAP04JointApplicant());
            pages.Add(new HEBS_EAP05());
            pages.Add(new HEBS_EAP05SecondSig());
            pages.Add(new HEBS_EAP05ThirdSig());
            pages.Add(new HEBS_EAP05FourthSig());
            pages.Add(new HEBS_EAP06());
            pages.Add(new HEBS_EAP07());
            pages.Add(new HEBS_EAP07SecondShareholder());
            pages.Add(new HEBS_EAP07ThirdShareholder());
            pages.Add(new HEBS_EAP07FourthShareholder());
            pages.Add(new HEBS_EAP09());
            pages.Add(new HEBS_EAP12());
            pages.Add(new HEBS_EAP27(testContext));
            pages.Add(new HEBS_EAP15());
            pages.Add(new HEBS_EAP19());
            pages.Add(new HEBS_EAP25());
            pages.Add(new HEBS_CreditStub());
            pages.Add(new HEBS_EAP14());
            pages.Add(new HEBS_DecisionPage());
            return pages;
        }
    }
}
