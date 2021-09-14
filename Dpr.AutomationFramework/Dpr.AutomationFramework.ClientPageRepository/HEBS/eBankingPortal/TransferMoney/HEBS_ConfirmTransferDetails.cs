using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.TransferMoney
{
    public class HEBS_ConfirmTransferDetails : ConfirmTransferDetails
    {
        public HEBS_ConfirmTransferDetails()
        {
            pageLoadedElement = fromAccount;
            correspondingDataClass = new HEBS_ConfirmTransferDetailsData().GetType();
            textName = "EBanking Confirm Transfer Details";
        }
    }

    public class HEBS_ConfirmTransferDetailsData : ConfirmTransferDetailsData
    {
    }
}
