using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP05ThirdSig : EAP05SecondSig
    {
        public EAP05ThirdSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP05ThirdSigData().GetType();
            textName = "Signatory Information 3rd Signatory";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("EAP05", "numberOfSignatories", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP05", "numberOfSignatories", "4"))));
        }


    }

    public class EAP05ThirdSigData : EAP05SecondSigData
    {
        public new string mobilePhoneNumber { get; set; } = "07740000002";

        public new string emailAddress { get; set; } = "test2@test.test";

        public new string confirmEmailAddress { get; set; } = "test2@test.test";

    }

}
