namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class PageCondition
    {
        public Element conditions { get; }

        public bool conditionsMet { get; set; }

        public PageCondition(Element conditions)
        {
            this.conditions = conditions;
            this.conditionsMet = false;
        }

        public void SetPageConditionMetStatus(bool status)
        {
            this.conditionsMet = status;
        }
    }
}
