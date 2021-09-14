using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP02 : CBS_DIP02
    {
        public CBS_ADV_DIP02()
        {
            pageLoadedElement = applicantType;
            correspondingDataClass = new CBS_ADV_DIP02Data().GetType();
            textName = "CBS Advised Applicant And Loan Type Page";
        }
    }

    public class CBS_ADV_DIP02Data : CBS_DIP02Data
    {
    }
}
