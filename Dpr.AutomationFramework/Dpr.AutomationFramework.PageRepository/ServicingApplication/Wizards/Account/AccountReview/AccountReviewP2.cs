 using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class AccountReviewP2 : AppBasePage
    {
        public AccountReviewP2()
        {
            pageLoadedElement = requiredRbtn;
            correspondingDataClass = new AccountReviewP2Data().GetType();
            textName = "Account Review Page 2";
        }

        #region 'Review Completed' Section
        public Element requiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkRequiredYes")))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkRequiredNo"))));
        
        public Element completedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkCompletedYes")))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkCompletedNo")))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkCompletedNA"))));
        
        public Element satisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkSatisfactoryYes")))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkSatisfactoryNo")))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "chkSatisfactoryUnk"))));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AccountReviewP2Data : PageData
    {
        public string required { get; set; } = "Yes";
        public string completed { get; set; } = "Yes";
        public string satisfied { get; set; } = "Yes";
        public string remarks { get; set; } = "TestRemarks";
    }
}
