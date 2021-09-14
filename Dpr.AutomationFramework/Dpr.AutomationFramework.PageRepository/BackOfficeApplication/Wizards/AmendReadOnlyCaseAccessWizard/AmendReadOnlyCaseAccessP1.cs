using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendReadOnlyCaseAccessWizard
{
    public class AmendReadOnlyCaseAccessP1 : BOWizardBasePage
    {
        // Only one wizard page?
        public AmendReadOnlyCaseAccessP1()
        {
            pageLoadedElement = change;
            correspondingDataClass = new AmendReadOnlyCaseAccessP1Data().GetType();
            textName = "Amend Read Only Case Access Page 1";
            windowTitle = "Amend Read-Only Case Access";
        }
        public Element makeApplicationReadOnly => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkAppIsReadOnly")));
        public Element enableDifferentLockStages => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbEnableMenus")));

        #region 'Do you want to enable menus of different lock stages?' = 'True' Section
        public Section enableDifferentLockStagesSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "enableDifferentLockStages", Defs.checkBoxSelected))));

        public Element preFMASubmit => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbPreFma")));

        public Element preOffer => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbPreOffer")));

        public Element postOffer => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbPostOffer")));

        public Element preCompletion => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbPreCompletion")));

        public SectionEnd enableDifferentLockStagesSectionEnd => new SectionEnd();
        #endregion

        public Element change => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendReadOnlyCaseAccessP1Data : PageData
    {
        public string makeApplicationReadOnly { get; set; } = Defs.checkBoxNotSelected;
        public string enableDifferentLockStages { get; set; } = Defs.checkBoxNotSelected;

        #region 'Do you want to enable menus of different lock stages?' = 'True' Data Section 
        public string preFMASubmit { get; set; } = Defs.checkBoxNotSelected;
        public string preOffer { get; set; } = Defs.checkBoxNotSelected;
        public string postOffer { get; set; } = Defs.checkBoxNotSelected;
        public string preCompletion { get; set; } = Defs.checkBoxNotSelected;
        #endregion
    }
}
