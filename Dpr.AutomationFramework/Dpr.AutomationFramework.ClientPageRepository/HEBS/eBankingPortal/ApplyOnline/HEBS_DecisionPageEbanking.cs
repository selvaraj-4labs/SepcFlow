using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_DecisionPageEbanking : DecisionPageEbanking
    {
        public HEBS_DecisionPageEbanking()
        {
            passExpectedMessage = "Your application reference:";
            passDecisionMessageBox = new Element(FindElement("ThankYou_lblAppRef"));
            failExpectedMessage = "Thank you for your application. We will " +
                                    "contact with you within the next few " +
                                    "to complete any remaining steps to open your account.";
            failDecisionMessageBox = new Element(FindElement(
                                        new LocatorList()
                                            .Add(Defs.locatorId, "thanksSimple"),
                                            "/p"));
            pageLoadedElement = applicationReferenceBox;
            correspondingDataClass = new DecisionPageEbankingData().GetType();
            textName = "Decision Page Ebanking";
        }
    }
}
