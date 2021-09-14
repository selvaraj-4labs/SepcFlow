using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer
{
    public class InternalTransferP1 : AppBasePage
    {
        public InternalTransferP1()
        {
            pageLoadedElement = transferType;
            correspondingDataClass = new InternalTransferP1Data().GetType();
            textName = "Internal Transfer Page 1";
        }


        public Element transferType => new Element(new RadioButton()
            .AddRadioButtonElement("Transfer funds between internal accounts", FindElement("=rbInternalAccount", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton"))
            .AddRadioButtonElement("Account", FindElement("=rbLoanAccount", attributeType: Defs.boLocatorAutomationId, tag: "RadioButton")));


        public Section transferFundsBetwenInternalAccountsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "transferType", "Transfer funds between internal accounts"))));

        public Element accountFrom => new Element(FindElement("=txtAccountFrom", attributeType: Defs.boLocatorAutomationId, tag: "Edit"))
            .SetCompletePageFlag(false);

        public Element accountTo => new Element(FindElement("=cmbAccountsTo", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"));

        public SectionEnd transferFundsBetwenInternalAccountsSectionEnd => new SectionEnd();


        public Section accountSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "transferType", "Account"))));

        public Element account => new Element(FindElement("=txtLoanAccount", attributeType: Defs.boLocatorAutomationId, tag: "Edit"));

        public Element check => new Element(FindElement("=btnCheck", attributeType: Defs.boLocatorAutomationId, tag: "Button"))
            .SetIsButtonFlag(true);

        public SectionEnd accountSectionEnd => new SectionEnd();

        public Element transferAmount => new Element(FindElement("=txtTransferAmount", attributeType: Defs.boLocatorAutomationId, tag: "Edit"));

        public Element effectiveDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=dtEffectiveDate"),"/ComboBox/Edit", "ComboBox")); 

        public Element remarks => new Element(FindElement("=txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element next => new Element(FindElement("=pnlNextButton", attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }


    public class InternalTransferP1Data : PageData
    {
        public string transferType { set; get; } = "Transfer funds between internal accounts";

        public string accountTo { set; get; } = null;

        public string account { set; get; } = null;

        public string transferAmount { set; get; } = "10";

        private string _effectiveDate = null;
        public string effectiveDate
        {
            get
            {
                if (_effectiveDate == null) return null;
                else
                    return Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace
                      + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + Keys.Backspace + _effectiveDate.Replace("/", "");
            }
            set { _effectiveDate = value; }
        }

        public string remarks { set; get; } = "Test";
    }
}
