using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_ProductSelectionPage : WebBasePage
    {
        public FMA_ProductSelectionPage()
        {
            pageLoadedElement = selectFirstProduct;
            correspondingDataClass = new FMA_ProductSelectionPageData().GetType();
            textName = "FMA Product Selection Page";
        }
        public Element selectFirstProduct => new Element(new RadioButton()
            .AddRadioButtonElement("1", FindElement("ctl02_ProductsGridSelect_0")));

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class FMA_ProductSelectionPageData : PageData
    {
        // Does not select any, uses the product selected in DIP.
        public string selectFirstProduct { get; set; } = null;
    }
}
