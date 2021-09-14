namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class Section
    {
        public Element conditions { get; }

        public bool conditionsMet { get; set; }

        public Section(Element conditions)
        {
            this.conditions = conditions;
            this.conditionsMet = false;
        }

        public void SetSectionConditionMetStatus(bool status)
        {
            this.conditionsMet = status;
        }
    }

    public class SectionEnd
    {
    }
}
