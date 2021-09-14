using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP01 : WebBasePage
    {

        public EAP01()
        {
            pageLoadedElement = acceptDeclarationChbox;
            correspondingDataClass = new EAP01Data().GetType();
            textName = "Entry Page Retail";
        }

        #region Locators


        public Element acceptDeclarationChbox => new Element(FindElement("chkAcceptDeclaration"));


        public Element next => new Element(FindElement("_Next")).SetIsButtonFlag(true);


        #endregion
    }
    public class EAP01Data : PageData
    {
        public string acceptDeclaration { get; set; } = Defs.checkBoxSelected;
    }
}
