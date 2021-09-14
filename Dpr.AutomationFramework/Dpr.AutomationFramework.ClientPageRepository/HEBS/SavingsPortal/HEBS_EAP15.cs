using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP15 : EAP15
    {
        public HEBS_EAP15()
        {
            pageLoadedElement = fscsChbox;
            correspondingDataClass = new HEBS_EAP15Data().GetType();
            textName = "Summary";
        }
        public new Element yourAgreement => new Element(FindElement("chkAcceptDeclaration"));
    }

    public class HEBS_EAP15Data : EAP15Data
    {
        public new string yourAgreement { get; set; } = Defs.checkBoxSelected;
    }
}
