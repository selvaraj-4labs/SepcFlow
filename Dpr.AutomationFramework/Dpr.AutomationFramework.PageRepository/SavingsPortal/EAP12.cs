using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP12 : WebBasePage
    {
        public EAP12()
        {
            pageLoadedElement = enterPasswordBox;
            correspondingDataClass = new EAP12Data().GetType();
            textName = "Registration";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition("EAP12", "dedupe", "false"))
            .Add(new Condition("EAP04", "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
            //.Add(new Condition("ProductSelection", "productType", "Child", Defs.conditionTypeNotEqual))
            //.Add(new Condition("ProductSelection", "productType", "ChildIsa", Defs.conditionTypeNotEqual))));
        }
        #region Locators
        public Element enterPasswordBox => new Element(FindElement("PasswordInput"));
        public Element retypePasswordBox => new Element(FindElement("PasswordConfirmInput"));
        public Element passwordHintBox => new Element(FindElement("SecurityQuestionHintInput"));
        public Element memorableQuestionBox => new Element(FindElement("SecurityQuestionInput"));
        public Element memorableAnswerBox => new Element(FindElement("SecurityAnswerInput"));

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);
        #endregion
    }

    public class EAP12Data : PageData
    {
        public string enterPassword { get; set; } = "Password1";
        public string retypePassword { get; set; } = "Password1";
        public string passwordHint { get; set; } = "PasswordOne";
        public string memorableQuestion { get; set; } = "Memorable";
        public string memorableAnswer { get; set; } = "aaaaaaaa";
        public string dedupe { get; set; } = "false";
    }
}
