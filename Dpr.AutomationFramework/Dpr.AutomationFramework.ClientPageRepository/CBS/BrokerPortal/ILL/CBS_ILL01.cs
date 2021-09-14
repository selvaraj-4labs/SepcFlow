using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.ILL
{
    public class CBS_ILL01 : WebBasePage
    {
        public CBS_ILL01()
        {
            pageLoadedElement = applicantType;
            correspondingDataClass = new CBS_ILL01Data().GetType();
            textName = "CBS Applicant & Loan Type";
        }

        public Element applicantType => new Element(FindElement("ddlApplicantType"));
        public Element loanType => new Element(FindElement("txtLoanType"));
        public Element next => new Element(FindElement("Next")).SetIsButtonFlag(true);
    }

    public class CBS_ILL01Data : PageData
    {
        public string applicantType { get; set; } = "Individual";
        public string loanType { get; set; } = "Residential";
    }
}
