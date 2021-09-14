using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP06 : CBS_DIP06
    {
        public CBS_ADV_DIP06()
        {
            pageLoadedElement = title;
            correspondingDataClass = new CBS_ADV_DIP06Data().GetType();
            textName = "CBS Advised Applicant 1 Details Page";
        }
        public new Element gender => new Element(FindElement("cboGender", tag: "select"),
            new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "termRequirements", "RIO")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition("CBS_ADV_DIP04", "termRequirements", "Both")));

        #region 'Company Association' Section
        public new Section companyAssociationSection => new Section(new Element(new ConditionList()
            .Add(new Condition("CBS_ADV_DIP02", "applicantType", "Limited Company"))));
        public new Element company_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "CboCompany", tag: "select"));
        public new Element roleWithinCompany_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "CboRolewithinBusiness", tag: "select"));
        public new Element percentageShareholding_1 => new Element(FindElement("CompanyAssociationRepeater", "item0", "txtShareholding", tag: "input"));
        public new SectionEnd companyAssociationSectionEnd => new SectionEnd();
        #endregion
    }

    public class CBS_ADV_DIP06Data : CBS_DIP06Data 
    {
        public new string existingCustomer { get; set; } = null;
    }
}
