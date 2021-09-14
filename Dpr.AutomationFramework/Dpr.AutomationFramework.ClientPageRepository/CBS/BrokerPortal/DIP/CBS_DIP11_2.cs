using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP11_2 : CBS_DIP11
    {
        public CBS_DIP11_2()
        {
            pageLoadedElement = applicantHaveMortgageOrSecuredLoansRbtn;
            correspondingDataClass = new CBS_DIP11_2Data().GetType();
            textName = "CBS Applicant 2 Credit Commitments Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP11_2Data : CBS_DIP11Data
    {
    }
}
