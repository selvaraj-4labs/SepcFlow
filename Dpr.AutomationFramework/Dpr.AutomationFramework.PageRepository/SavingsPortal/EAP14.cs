using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP14 : WebBasePage
    {

        public EAP14()
        {
            pageLoadedElement = pleaseWaitText;
            correspondingDataClass = new EAP14Data().GetType();
            textName = "Decision Loading Page";
            // Check below
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual))
                .Add(new Condition("ProductSelection", "productType", "ChildIsa", Defs.conditionTypeNotEqual))));
        }

        #region Locators


        public Element pleaseWaitText => new Element(FindElement("This may take a few moments", attributeType: Defs.locatorText)).SetCompletePageFlag(false);

        public WaitFor waitForDecisionPage => new WaitFor(pleaseWaitText, 120)
           .AddWaitElement(new DecisionPage().applicationReferenceBox.locator);




        #endregion
    }
    public class EAP14Data : PageData
    {

    }
}
