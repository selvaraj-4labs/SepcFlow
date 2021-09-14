using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class AccountSettingsP2 : AppBasePage
    {
        public AccountSettingsP2()
        {
            pageLoadedElement = paymentMethod;
            correspondingDataClass = new AccountSettingsP2Data().GetType();
            textName = "Account Settings Page 2";
        }

        public Element paymentMethod => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=cePaymentMethod"), tag: "ComboBox"));



        #region If paymentMethod = Saved Account Payee

        //tbc - not req for test
        #endregion


        #region If paymentMethod = BACS or BACS/FPS or Faster Payments Or SWIFT

        //public Section mortgageAndSecuredLoanSection => new Section(new Element(
        //new ConditionList()
        //    .Add(new Condition(className, "paymentMethod", "BACS")))
        //.AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "paymentMethod", "BACS / FPS")))
        //.AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "paymentMethod", "Faster Payments")))
        //.AddNewConditionList(new ConditionList()
        //    .Add(new Condition(className, "paymentMethod", "SWIFT"))));


        //public Element sortCode => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=txtBankDetailsSortCode"), "/Edit"));

        //public Element accountNumber => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=txtBankDetailsAccountNumber"), "/Edit"));

        //public Element accountName => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=txtBankDetailsAccountName"), "/Edit"));

        //public Element verify => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=btnBankDetailsVerify")), new ConditionList()
        //    .Add(new Condition (className, "sortCode", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "accountNumber", null, Defs.conditionTypeNotEqual))
        //    .Add(new Condition(className, "accountName", null, Defs.conditionTypeNotEqual)))
        //    .SetIsButtonFlag(true);

        //public Element accountIban => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=txtAccountIban"), "/Edit"));

        //public Element swiftBic => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=cboBicLookUp"), "/ComboBox"));

        //public Element verifyIban => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=btnVerifyIban")), new ConditionList()
        //    .Add(new Condition(className, "accountIban", null, Defs.conditionTypeNotEqual)))
        //    .SetIsButtonFlag(true);

        //public Element useNewBankAccountDetails => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=chkNewBankAccountDetails"), "/CheckBox[@Name='Use New Bank Account Details']"));

        //public SectionEnd mortgageAndSecuredLoanSectionEnd = new SectionEnd();

        #endregion

        #region If paymentMethod = Cheque
        public Element chequeDetailsPayee => new Element(FindElement(
            new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=txtPayee"), "/Edit"), 
            new ConditionList()
                .Add(new Condition(className, "paymentMethod", "Cheque")));
        
        #endregion

        public Element remarks => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtRemarks"), "/Edit"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);



    }

    public class AccountSettingsP2Data : PageData
    {

        public string paymentMethod { set; get; } = "Cheque";
        public string chequeDetailsPayee { set; get; } = "TestPayee";

        public string sortCode { set; get; } = null;

        public string accountNumber { set; get; } = null;

        public string accountName { set; get; } = null;

        public string accountIban { set; get; } = null;

        public string swiftBic { set; get; } = null;

        public string useNewBankAccountDetails { set; get; } = null;

        public string remarks { set; get; } = null;


    }
}
