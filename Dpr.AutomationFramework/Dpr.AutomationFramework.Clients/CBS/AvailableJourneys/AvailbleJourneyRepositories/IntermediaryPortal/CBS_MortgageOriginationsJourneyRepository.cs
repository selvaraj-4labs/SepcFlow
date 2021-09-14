﻿using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.IntermediaryPortal;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.IntermediaryPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.IntermediaryPortal.ILL;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Intermediary.AvailableJourneys;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.IntermediaryPortal.CBS_MortgageOriginationsJourneyList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableJourneys.AvailbleJourneyRepositories.IntermediaryPortal
{
    public class CBS_MortgageOriginationsJourneyRepository : MortgageOriginationsJourneyRepository
    {
		public override List<BasePage> GetPagesFor(string journeyName)
		{
			List<BasePage> pages = new List<BasePage>();
			MortgageOriginationsJourneys moJourney;
			CBS_MortgageOriginationsJourneyRepository moRepo = new CBS_MortgageOriginationsJourneyRepository();

			// Try to check if the value journeyName is in savingsJourney.
			bool tryParse = Enum.TryParse(journeyName, out moJourney);
			if (tryParse == false)
			{
				new TestEnder().FailEnd(
					Defs.failNonAssert,
					"The journey type '" + journeyName + "' does not exist. " +
					"Please ensure the provided journey type is correct.");
			}
			pages = moRepo.MOJourneyRepo(moJourney, pages);

			return pages;
		}
		public List<BasePage> MOJourneyRepo(MortgageOriginationsJourneys journeyName, List<BasePage> pages)
		{
			switch (journeyName)
			{
				case MortgageOriginationsJourneys.ill:
					pages.Add(new CBS_LoginPage());
					pages.Add(new CBS_MemorableWordPage());
					pages.Add(new CBS_BrokerHomePage());
					pages.Add(new CBS_ILL01());
					pages.Add(new CBS_ILL02());
					pages.Add(new CBS_ILL03());
					pages.Add(new CBS_ILL04());
					pages.Add(new CBS_ILL05());
					pages.Add(new CBS_ILL06());
					// TODO: Finish this off when protal bug fixed.
					break;

				case MortgageOriginationsJourneys.dip:
					pages.Add(new CBS_LoginPage());
					pages.Add(new CBS_MemorableWordPage());
					pages.Add(new CBS_BrokerHomePage());

					pages.Add(new CBS_DIP01());
					pages.Add(new CBS_DIP02());
					pages.Add(new CBS_DIP03());
					pages.Add(new CBS_DIP04());
					pages.Add(new CBS_DIP05());
					pages.Add(new CBS_DIP06());
					pages.Add(new CBS_DIP07());
					pages.Add(new CBS_DIP08());
					pages.Add(new CBS_DIP09_Employed());
					pages.Add(new CBS_DIP09_FTC());
					pages.Add(new CBS_DIP09_SelfEmployed());
					pages.Add(new CBS_DIP09_2ndEmployed());
					pages.Add(new CBS_DIP09_2ndFTC());
					pages.Add(new CBS_DIP09_2ndSelfEmployed());
					pages.Add(new CBS_DIP10());
					pages.Add(new CBS_DIP11());
					pages.Add(new CBS_DIP12());

					pages.Add(new CBS_DIP06_2());
					pages.Add(new CBS_DIP07_2());
					pages.Add(new CBS_DIP08_2());
					pages.Add(new CBS_DIP09_Employed_2());
					pages.Add(new CBS_DIP09_FTC_2());
					pages.Add(new CBS_DIP09_SelfEmployed_2());
					pages.Add(new CBS_DIP09_2ndEmployed_2());
					pages.Add(new CBS_DIP09_2ndFTC_2());
					pages.Add(new CBS_DIP09_2ndSelfEmployed_2());
					pages.Add(new CBS_DIP10_2());
					pages.Add(new CBS_DIP11_2());
					pages.Add(new CBS_DIP12_2());

					pages.Add(new CBS_DIP06_3());
					pages.Add(new CBS_DIP07_3());
					pages.Add(new CBS_DIP08_3());
					pages.Add(new CBS_DIP09_Employed_3());
					pages.Add(new CBS_DIP09_FTC_3());
					pages.Add(new CBS_DIP09_SelfEmployed_3());
					pages.Add(new CBS_DIP09_2ndEmployed_3());
					pages.Add(new CBS_DIP09_2ndFTC_3());
					pages.Add(new CBS_DIP09_2ndSelfEmployed_3());
					pages.Add(new CBS_DIP10_3());
					pages.Add(new CBS_DIP11_3());
					pages.Add(new CBS_DIP12_3());

					pages.Add(new CBS_DIP06_4());
					pages.Add(new CBS_DIP07_4());
					pages.Add(new CBS_DIP08_4());
					pages.Add(new CBS_DIP09_Employed_4());
					pages.Add(new CBS_DIP09_FTC_4());
					pages.Add(new CBS_DIP09_SelfEmployed_4());
					pages.Add(new CBS_DIP09_2ndEmployed_4());
					pages.Add(new CBS_DIP09_2ndFTC_4());
					pages.Add(new CBS_DIP09_2ndSelfEmployed_4());
					pages.Add(new CBS_DIP10_4());
					pages.Add(new CBS_DIP11_4());
					pages.Add(new CBS_DIP12_4());

					pages.Add(new CBS_DIP13());
					pages.Add(new CBS_DIP14());
					pages.Add(new CBS_PBD01());
					pages.Add(new CBS_PBD02());
					pages.Add(new CBS_PBD04());
					pages.Add(new CBS_DIP15());
					pages.Add(new CBS_DIPAPPSUM());
					break;
			}
			return pages;
		}
	}
}
