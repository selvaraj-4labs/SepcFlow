using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP05 : CompanyDetailsPage
    {
        public CBS_DIP05()
        {
            pageLoadedElement = limitedCompanyName;
            correspondingDataClass = new CBS_DIP05Data().GetType();
            textName = "CBS Company Details Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("CBS_DIP02", "applicantType", "Limited Company"))));
        }
    }

    public class CBS_DIP05Data : CompanyDetailsPageData
    {
        public new string primarySicCode { set; get; } = "68100 Buying and selling of own real estate";
        public new string dateOfRegistration { set; get; } = null;
    }
}
