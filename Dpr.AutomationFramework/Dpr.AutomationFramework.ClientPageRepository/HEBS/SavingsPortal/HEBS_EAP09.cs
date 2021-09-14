using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP09 : EAP09
    {
        public HEBS_EAP09()
        {
            pageLoadedElement = sortCode1Box;
            correspondingDataClass = new HEBS_EAP09Data().GetType();
            textName = "Nominated Account";
        }

        public new  Element applicantAssociatedWithBankAccount => new Element(FindElement("ApplicantAssociatedWithAccount"),
            new ConditionList()
                .Add(new Condition("HEBS_EAP00", "productType", "Corp", Defs.conditionTypeNotEqual))
                .Add(new Condition("HEBS_EAP04", "singleJointAccount", "Joint")));
    }

    public class HEBS_EAP09Data : EAP09Data
    {
        public new string sortCode1 { get; set; } = "07";

        public new string sortCode2 { get; set; } = "01";

        public new string sortCode3 { get; set; } = "16";

        public new string accountNumber { get; set; } = "00136076";
    }
}
