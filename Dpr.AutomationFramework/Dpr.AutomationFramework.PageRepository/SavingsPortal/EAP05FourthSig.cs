using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP05FourthSig : EAP05SecondSig
    {
        public EAP05FourthSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP05FourthSigData().GetType();
            textName = "Signatory Information 4th Signatory";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4"))));
        }
    }

    public class EAP05FourthSigData : EAP05SecondSigData
    {
        public new string mobilePhoneNumber { get; set; } = "07740000003";

        public new string emailAddress { get; set; } = "test3@test.test";

        public new string confirmEmailAddress { get; set; } = "test3@test.test";
    }

}
