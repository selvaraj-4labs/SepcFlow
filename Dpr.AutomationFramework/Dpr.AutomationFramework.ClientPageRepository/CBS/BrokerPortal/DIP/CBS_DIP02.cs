using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP02 : ApplicantAndLoanTypePage
    {
        public CBS_DIP02()
        {
            pageLoadedElement = applicantType;
            correspondingDataClass = new CBS_DIP02Data().GetType();
            textName = "CBS Applicant And Loan Type Page";
        }
    }

    public class CBS_DIP02Data : ApplicantAndLoanTypePageData
    {
    }
}
