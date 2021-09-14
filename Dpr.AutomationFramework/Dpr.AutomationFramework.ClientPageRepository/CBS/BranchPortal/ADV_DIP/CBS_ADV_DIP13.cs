using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP13 : CBS_DIP13
    {
        public CBS_ADV_DIP13()
        {
            pageLoadedElement = numbeOfNonApplicantAdultDependents;
            correspondingDataClass = new CBS_ADV_DIP13Data().GetType();
            textName = "CBS Advised Household Expenditure Page";
            //pageCondition = new PageCondition(new Element(new ConditionList()
            //        .Add(new Condition("CBS_ADV_DIP02", "loanType", "Residential"))));
        }
    }

    public class CBS_ADV_DIP13Data : CBS_DIP13Data 
    {
    }
}
