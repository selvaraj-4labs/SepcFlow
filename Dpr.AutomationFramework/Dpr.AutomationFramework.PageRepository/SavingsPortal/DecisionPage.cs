using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{     
    public class DecisionPage : WebBasePage
    {
        public DecisionPage()
        {

            passExpectedMessage = "Your application reference:";

            passDecisionMessageBox = new Element(FindElement("ThankYou_lblAppRef"));

            failExpectedMessage =   "Thank you for your application. We will " +
                                    "contact with you within the next few " +
                                    "to complete any remaining steps to open your account.";

            failDecisionMessageBox = new Element(FindElement(
                                        new LocatorList()
                                            .Add(Defs.locatorId, "thanksSimple"),
                                            "/p"));

            pageLoadedElement = homePageBtn;
            correspondingDataClass = new DecisionPageData().GetType();
            textName = "Decision Page";
        }

        public Element applicationReferenceBox => new Element(FindElement(
                                                    new LocatorList()
                                                    .Add(Defs.locatorId, "ThankYou_divApplicationRef")))
                                                    // Removed line 09/09/2019
                                                    //"/text()[2]"))
                                                    .SetCompletePageFlag(false);


        public Element userIDBox => new Element(FindElement(
                                        new LocatorList()
                                        .Add(Defs.locatorId, "trBankDetailsUserId"),
                                        "/div/div[3]"))
                                        .SetCompletePageFlag(false);


        public Element sortCodeBox => new Element(FindElement(
                                         new LocatorList()
                                         .Add(Defs.locatorId, "trBankDetailsSortCode"),
                                         "/div/div[3]"))
                                         .SetCompletePageFlag(false);
        

        public Element bankAccNumberBox => new Element(FindElement(
                                 new LocatorList()
                                 .Add(Defs.locatorId, "trBankDetailsAccNumber"),
                                 "/div/div[3]"))
                                 .SetCompletePageFlag(false);


        public Element homePageBtn => new Element(FindElement("ThankYou_ReturnHome"))
                                        .SetIsButtonFlag(true)
                                        .SetCompletePageFlag(false);
    }

    public class DecisionPageData : PageData
    {
    }
}
