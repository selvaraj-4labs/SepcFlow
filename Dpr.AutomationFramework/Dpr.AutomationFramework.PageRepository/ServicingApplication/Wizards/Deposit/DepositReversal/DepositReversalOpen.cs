using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal
{
    public class DepositReversalOpen : GenericWizardOpen
    {
        public DepositReversalOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new DepositReveralOpenData().GetType();
            textName = "Deposit Reversal Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickDepositReversal => processActions.depositReversal;
    }

    public class DepositReveralOpenData : GenericWizardOpenData
    {
    }
}
