﻿using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositClose : GenericWizardClose
    {
        public AdHocDepositClose()
        {
            correspondingDataClass = new AdHocDepositCloseData().GetType();
            textName = "Ad Hoc Deposit Close";
        }
    }

    public class AdHocDepositCloseData : GenericWizardCloseData
    {
    }
}
