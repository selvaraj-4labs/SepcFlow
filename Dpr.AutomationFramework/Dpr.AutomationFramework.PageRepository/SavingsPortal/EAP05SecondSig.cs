using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP05SecondSig : EAP05
    {
        public EAP05SecondSig()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP05SecondSigData().GetType();
            textName = "Signatory Information 2nd Signatory";
            pageCondition = new PageCondition(new Element(new ConditionList()
                                .Add(new Condition("EAP05", "numberOfSignatories", "2")))
                            .AddNewConditionList(new ConditionList()
                                .Add(new Condition("EAP05", "numberOfSignatories", "3")))
                            .AddNewConditionList(new ConditionList()
                                .Add(new Condition("EAP05", "numberOfSignatories", "4"))));
        }

        public new Element numberOfSignatoriesRbtn => base.numberOfSignatoriesRbtn.SetCompletePageFlag(false);

    }

    public class EAP05SecondSigData : EAP05Data
    {
        public new string title { get; set; } = "Mr";

        public new string firstName { get; set; } = "SignatoryTwo";

        public new string middleName { get; set; } = "TestMName";

        public new string lastName { get; set; } = "Test";

        public new string postcode { get; set; } = "CM1 4UW";

        public new string houseNumber { get; set; } = "3";

        public new string movedToCurrentAddress { get; set; } = "01/2000";

        public new string mobilePhoneNumber { get; set; } = "07740000001";

        public new string emailAddress { get; set; } = "test@test.test";

        public new string confirmEmailAddress { get; set; } = "test@test.test";

    }

}
