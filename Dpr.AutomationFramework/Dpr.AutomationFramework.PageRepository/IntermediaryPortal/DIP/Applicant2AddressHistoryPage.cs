using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant2AddressHistoryPage : Applicant1AddressHistoryPage
    {
        public Applicant2AddressHistoryPage()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new Applicant2AddressHistoryPageData().GetType();
            textName = "Applicant 2 Address Histroy Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("Applicant1DetailsPage", "numberOfApplicants", "2"))));
        }
    }
    public class Applicant2AddressHistoryPageData : Applicant1AddressHistoryPageData
    {
    }
}
