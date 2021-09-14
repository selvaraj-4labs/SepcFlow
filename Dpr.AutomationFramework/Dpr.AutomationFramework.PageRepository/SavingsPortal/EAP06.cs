using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP06 : WebBasePage
    {
        public EAP06()
        {
            pageLoadedElement = signatoryShareholding_1Rbtn;
            correspondingDataClass = new EAP06Data().GetType();
            textName = "Signatory Shareholders";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("ProductSelection", "productType", "Corporate"))
                    .Add(new Condition("EAP03", "businessType", "Limited Company"))));
        }

        public Element signatoryShareholding_1Rbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item0")
                .Add(Defs.locatorId, "_rbl_0")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item0")
                .Add(Defs.locatorId, "_rbl_1"))),
            new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "1")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "2")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4")));

        public Element signatoryShareholding_2Rbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item1")
                .Add(Defs.locatorId, "_rbl_0")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item1")
                .Add(Defs.locatorId, "_rbl_1"))),
            new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "2")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4")));

        public Element signatoryShareholding_3Rbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item2")
                .Add(Defs.locatorId, "_rbl_0")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item2")
                .Add(Defs.locatorId, "_rbl_1"))),
            new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4")));

        public Element signatoryShareholding_4Rbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item3")
                .Add(Defs.locatorId, "_rbl_0")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.locatorId, "IncludeApplicantInRoleControl_btn")
                .Add(Defs.locatorId, "item3")
                .Add(Defs.locatorId, "_rbl_1"))),
            new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4")));

        public Element numberOfOtherApplicantsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("0", FindElement("NumberOfOtherApplicants", "_0"))
            .AddRadioButtonElement("1", FindElement("NumberOfOtherApplicants", "_1"))
            .AddRadioButtonElement("2", FindElement("NumberOfOtherApplicants", "_2"))
            .AddRadioButtonElement("3", FindElement("NumberOfOtherApplicants", "_3"))
            .AddRadioButtonElement("4", FindElement("NumberOfOtherApplicants", "_4")),
            new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "1"))
                .Add(new Condition("EAP06", "signatoryShareholding_1", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "2"))
                .Add(new Condition("EAP06", "signatoryShareholding_1", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3"))
                .Add(new Condition("EAP06", "signatoryShareholding_1", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4"))
                .Add(new Condition("EAP06", "signatoryShareholding_1", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "2"))
                .Add(new Condition("EAP06", "signatoryShareholding_2", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3"))
                .Add(new Condition("EAP06", "signatoryShareholding_2", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4"))
                .Add(new Condition("EAP06", "signatoryShareholding_2", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "3"))
                .Add(new Condition("EAP06", "signatoryShareholding_3", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4"))
                .Add(new Condition("EAP06", "signatoryShareholding_3", Defs.radioButtonNo)))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("EAP05", "numberOfSignatories", "4"))
                .Add(new Condition("EAP06", "signatoryShareholding_4", Defs.radioButtonNo)));

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);
    }

    public class EAP06Data : PageData
    {
        public string signatoryShareholding_1 { get; set; } = Defs.radioButtonNo;
        public string signatoryShareholding_2 { get; set; } = Defs.radioButtonNo;
        public string signatoryShareholding_3 { get; set; } = Defs.radioButtonNo;
        public string signatoryShareholding_4 { get; set; } = Defs.radioButtonNo;
        public string numberOfOtherApplicants { get; set; } = "0";

    }
}
