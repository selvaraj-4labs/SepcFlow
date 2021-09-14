using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP09 : WebBasePage
    {
        public EAP09()
        {
            pageLoadedElement = sortCode1Box;
            correspondingDataClass = new EAP09Data().GetType();
            textName = "Nominated Account";
        }

        public Element sortCode1Box => new Element(FindElement("txtSortCode1"));

        public Element sortCode2Box => new Element(FindElement("txtSortCode2"));

        public Element sortCode3Box => new Element(FindElement("txtSortCode3"));

        public Element accountNumberBox => new Element(FindElement("txtAccountNo"));

        public Element accountNameBox => new Element(FindElement("txtAccountHolder"));

        public Element validateButton => new Element(FindElement("btnValidate")).SetIsButtonFlag(true);

        public Element bankAddressText => new Element(FindElement("txtBankAddress"));

        public Element applicantAssociatedWithBankAccount => new Element(FindElement("ApplicantAssociatedWithAccount"),
            new ConditionList()
            .Add(new Condition("ProductSelection", "productType", "Corp", Defs.conditionTypeNotEqual))
            .Add(new Condition("EAP04", "singleJointAccount", "Joint")));

        public Element interestTargetAccountLookup => new Element(FindElement("paymentTargetControl"));

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);

    }

    public class EAP09Data : PageData
    {
        // Old Bank Account Details: 070116-02971797
        public string sortCode1 { get; set; } = "99";

        public string sortCode2 { get; set; } = "99";

        public string sortCode3 { get; set; } = "99";

        public string accountNumber { get; set; } = "99999999";

        public string accountName { get; set; } = "Test Account";

        public string applicantAssociatedWithBankAccount { get; set; } = "Both";

        public string interestTargetAccount { get; set; } = "This account being applied for";
    }
}
