using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut
{
    public class ISATransferOutP2 : AppBasePage
    {
        public ISATransferOutP2()
        {
            pageLoadedElement = overrideToProceed;
            correspondingDataClass = new ISATransferOutP2Data().GetType();
            textName = "ISA Transfer Out Page 2";
        }

        #region 'Penalties and Bonuses Review' Section
        public Element overrideToProceed => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cbProductOverride")));
        #endregion

        public Element remarks=> new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class ISATransferOutP2Data : PageData
    {
        public string overrideToProceed { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "Test Remarks";
    }
}
