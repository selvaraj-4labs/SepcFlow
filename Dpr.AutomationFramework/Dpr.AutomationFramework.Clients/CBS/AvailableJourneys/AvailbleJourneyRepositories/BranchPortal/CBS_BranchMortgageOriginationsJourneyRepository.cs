using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.AvailableJourneys;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.BranchPortal.CBS_BranchMortgageOriginationsJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.BranchPortal
{
    public class CBS_BranchMortgageOriginationsJourneyRepository : JourneyRepository
	{
		// Placeholder
		public override List<BasePage> GetPagesFor(TestContext testContext)
		{
			List<BasePage> pages = new List<BasePage>();
			return pages;
		}

		public override List<BasePage> GetPagesFor(string journeyName, TestContext testContext)
		{
			List<BasePage> pages = new List<BasePage>();
			BranchMortgageOriginationsJourneys moJourney;
			CBS_BranchMortgageOriginationsJourneyRepository moRepo = new CBS_BranchMortgageOriginationsJourneyRepository();

			// Try to check if the value journeyName is in savingsJourney.
			bool tryParse = Enum.TryParse(journeyName, out moJourney);
			if (tryParse == false)
			{
				new TestEnder().FailEnd(
					Defs.failNonAssert,
					"The journey type '" + journeyName + "' does not exist. " +
					"Please ensure the provided journey type is correct.");
			}
			pages = moRepo.BranchMOJourneyRepo(moJourney, pages);

			return pages;
		}

		public List<BasePage> BranchMOJourneyRepo(BranchMortgageOriginationsJourneys journeyName, List<BasePage> pages)
		{
			switch (journeyName)
			{
				case BranchMortgageOriginationsJourneys.dip:

					pages.Add(new CBS_BranchHomePage());
					pages.Add(new CBS_BranchCustomerSearch());
					pages.Add(new CBS_PrivacyNotice());

					pages.Add(new CBS_ADV_DIP01());
					pages.Add(new CBS_ADV_DIP02());
					pages.Add(new CBS_ADV_DIP03());
					pages.Add(new CBS_ADV_DIP04());

					pages.Add(new CBS_ADV_DIP06());
					pages.Add(new CBS_ADV_DIP07());
					pages.Add(new CBS_ADV_DIP08());
					pages.Add(new CBS_ADV_DIP09_Employed());
					pages.Add(new CBS_ADV_DIP09_FTC());
					pages.Add(new CBS_ADV_DIP09_SelfEmployed());
					pages.Add(new CBS_ADV_DIP09_2ndEmployed());
					pages.Add(new CBS_ADV_DIP09_2ndFTC());
					pages.Add(new CBS_ADV_DIP09_2ndSelfEmployed());

					pages.Add(new CBS_ADV_DIP10());
					pages.Add(new CBS_ADV_DIP11());
					pages.Add(new CBS_ADV_DIP12());

					pages.Add(new CBS_ADV_DIP06_2());
					pages.Add(new CBS_ADV_DIP07_2());
					pages.Add(new CBS_ADV_DIP08_2());
					pages.Add(new CBS_ADV_DIP09_Employed_2());
					pages.Add(new CBS_ADV_DIP09_FTC_2());
					pages.Add(new CBS_ADV_DIP09_SelfEmployed_2());
					pages.Add(new CBS_ADV_DIP09_2ndEmployed_2());
					pages.Add(new CBS_ADV_DIP09_2ndFTC_2());
					pages.Add(new CBS_ADV_DIP09_2ndSelfEmployed_2());
					pages.Add(new CBS_ADV_DIP10_2());
					pages.Add(new CBS_ADV_DIP11_2());
					pages.Add(new CBS_ADV_DIP12_2());

					pages.Add(new CBS_ADV_DIP06_3());
					pages.Add(new CBS_ADV_DIP07_3());
					pages.Add(new CBS_ADV_DIP08_3());
					pages.Add(new CBS_ADV_DIP09_Employed_3());
					pages.Add(new CBS_ADV_DIP09_FTC_3());
					pages.Add(new CBS_ADV_DIP09_SelfEmployed_3());
					pages.Add(new CBS_ADV_DIP09_2ndEmployed_3());
					pages.Add(new CBS_ADV_DIP09_2ndFTC_3());
					pages.Add(new CBS_ADV_DIP09_2ndSelfEmployed_3());
					pages.Add(new CBS_ADV_DIP10_3());
					pages.Add(new CBS_ADV_DIP11_3());
					pages.Add(new CBS_ADV_DIP12_3());

					pages.Add(new CBS_ADV_DIP06_4());
					pages.Add(new CBS_ADV_DIP07_4());
					pages.Add(new CBS_ADV_DIP08_4());
					pages.Add(new CBS_ADV_DIP09_Employed_4());
					pages.Add(new CBS_ADV_DIP09_FTC_4());
					pages.Add(new CBS_ADV_DIP09_SelfEmployed_4());
					pages.Add(new CBS_ADV_DIP09_2ndEmployed_4());
					pages.Add(new CBS_ADV_DIP09_2ndFTC_4());
					pages.Add(new CBS_ADV_DIP09_2ndSelfEmployed_4());
					pages.Add(new CBS_ADV_DIP10_4());
					pages.Add(new CBS_ADV_DIP11_4());
					pages.Add(new CBS_ADV_DIP12_4());

					pages.Add(new CBS_ADV_DIP13());
					pages.Add(new CBS_ADV_DIP14());
					pages.Add(new CBS_ADV_DIP15());
					pages.Add(new CBS_ADV_DIP17());
					pages.Add(new CBS_BranchSummary());
					break;
			}
			return pages;
		}
	}
}
