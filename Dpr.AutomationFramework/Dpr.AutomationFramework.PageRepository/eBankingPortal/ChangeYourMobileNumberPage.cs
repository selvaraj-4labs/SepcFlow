using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class ChangeYourMobileNumberPage : WebBasePage
    {
        public ChangeYourMobileNumberPage()
        {
            pageLoadedElement = currentMobileNumber;
            correspondingDataClass = new ChangeYourMobileNumberPageData().GetType();
            textName = "EBanking Your Contact Details";
        }
        public Element currentMobileNumber => new Element(FindElement("=container", 
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[1]/div[2]"))
            .SetCompletePageFlag(false);

        public Element newMobileNumber => new Element(FindElement("NewMobileNo"));


        public Element confirmNewMobile => new Element(FindElement("ConfirmMobileNo"));


        public Element submit => new Element(FindElement("Submit", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true);
    }

    public class ChangeYourMobileNumberPageData : PageData
    {
        public string newMobileNumber { set; get; } = "07786998877";

        public string confirmNewMobile { set; get; } = "07786998877";

    }
}
