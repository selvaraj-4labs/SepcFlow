using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_DecisionPage : DecisionPage
    {
        public HEBS_DecisionPage()
        {
            passExpectedMessage = "Your application reference:";
            passDecisionMessageBox = new Element(FindElement("ThankYou_lblAppRef"));
            failExpectedMessage = "Thank you for your application. We will " +
                                    "contact with you within the next few " +
                                    "to complete any remaining steps to open your account.";
            failDecisionMessageBox = new Element(FindElement(new LocatorList()
                .Add(Defs.locatorId, "thanksSimple"),
                "/p"));
            pageLoadedElement = homePageBtn;
            correspondingDataClass = new DecisionPageData().GetType();
            textName = "Decision Page";
        }
    }

    public class HEBS_DecisionPageData : DecisionPageData
    {
    }
}
