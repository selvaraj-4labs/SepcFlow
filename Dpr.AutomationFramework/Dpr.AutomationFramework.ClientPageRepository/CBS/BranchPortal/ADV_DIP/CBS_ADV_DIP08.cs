using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP08 : CBS_DIP08
    {
        public CBS_ADV_DIP08()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new CBS_ADV_DIP08Data().GetType();
            textName = "CBS Advised Applicant 1 Employment Initialisation Page";
        }
    }

    public class CBS_ADV_DIP08Data : CBS_DIP08Data
    {
    }
}
