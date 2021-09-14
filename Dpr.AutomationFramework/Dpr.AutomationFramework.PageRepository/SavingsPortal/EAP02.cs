using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP02 : WebBasePage
    {
        public EAP02()
        {
            pageLoadedElement = acceptISADeclarationChbox;
            correspondingDataClass = new EAP02Data().GetType();
            textName = "ISA Declaration Page";
            pageCondition = new PageCondition(new Element(new ConditionList()
                        .Add(new Condition("ProductSelection", "productType", "ISA")))
                .AddNewConditionList(new ConditionList()
                        .Add(new Condition("ProductSelection", "productType", "ChildIsa"))));
        }

        public Element acceptISADeclarationChbox => new Element(FindElement("chkAcceptDeclaration"));

        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);

    }

    public class EAP02Data : PageData
    {
        public string acceptISADeclaration { get; set; } = Defs.checkBoxSelected;
    }
}
