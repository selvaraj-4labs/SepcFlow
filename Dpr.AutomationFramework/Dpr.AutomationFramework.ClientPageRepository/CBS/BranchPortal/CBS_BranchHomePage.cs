using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal
{
    public class CBS_BranchHomePage : WebBasePage
    {
        public CBS_BranchHomePage()
        {
            pageLoadedElement = branchHomeOption;
            correspondingDataClass = new CBS_BranchHomePageData().GetType();
            textName = "CBS Branch Home Page";
        }

        public Element branchHomeOption => new Element(new ButtonGroup()
            .AddButtonElement("Home", FindElement("=Home", attributeType: Defs.locatorTitle, tag: "a"))
            .AddButtonElement("Customer Search", FindElement("=Customer search", attributeType: Defs.locatorTitle, tag: "a"))
            .AddButtonElement("Literature", FindElement("=Literature", attributeType: Defs.locatorTitle, tag: "a"))
            .AddButtonElement("Case search", FindElement("=Case search", attributeType: Defs.locatorTitle, tag: "a")));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_BranchHomePageData : PageData
    {
        public string branchHomeOption { get; set; } = "Customer search";
    }
}
