using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_DecisionResultPage : WebBasePage
    {
        public FMA_DecisionResultPage()
        {
            pageLoadedElement = viewAlternativeProducts;
            correspondingDataClass = new FMA_DecisionResultPageData().GetType();
            textName = "FMA Decision Result Page";
        }

        public Element viewAlternativeProducts => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ViewAlternativeProducts_btn", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ViewAlternativeProducts_btn", "rbl_1")));

        // TODO: When 'ProductSelctionPage' is completed, update the following section with the code.
        public Section viewAlternativeProductsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "viewAlternativeProducts", Defs.radioButtonYes))));

        public SectionEnd viewAlternativeProductsSectionEnd => new SectionEnd();

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_DecisionResultPageData : PageData
    {
        public string viewAlternativeProducts { get; set; } = Defs.radioButtonNo;
    }
}
