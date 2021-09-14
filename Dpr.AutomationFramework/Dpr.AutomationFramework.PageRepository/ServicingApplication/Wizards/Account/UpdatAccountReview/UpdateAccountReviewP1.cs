 using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.UpdateAccountReview
{
    public class UpdateAccountReviewP1 : AccountReviewP2
    {
        public UpdateAccountReviewP1()
        {
            correspondingDataClass = new UpdateAccountReviewP1Data().GetType();
            textName = "Update Account Review Page 1";
        }
        public new Element requiredRbtn => base.requiredRbtn;
        public new Element completedRbtn => base.completedRbtn;
        public new Element satisfiedRbtn => base.satisfiedRbtn;
        public new Element remarksBox => base.remarksBox;
        public new Element confirmBtn => new Element(FindElement("=Next", attributeType: Defs.boLocatorName)).SetIsButtonFlag(true);
    }

    public class UpdateAccountReviewP1Data : AccountReviewP2Data
    {

    }
}
