using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.CancelRegularDeposit
{
    public class CancelRegularDepositP1 : AppBasePage
    {
        public CancelRegularDepositP1()
        {
            pageLoadedElement = cancelRegularDepositTable;
            correspondingDataClass = new CancelRegularDepositP1Data().GetType();
            textName = "Cancel Regular Deposit Page 1";
        }

        // Cancel Regular Deposit table XPath
        //public Element cancelRegularDepositTable => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "=baseGrid"), "/Table[@AutomationId=\"ultraGrid\"]/Custom[@AutomationId=\"Data Area\"]/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]/DataItem/CheckBox[@Name=\"Select\"]", "MenuItem"))
        //    .SetIsButtonFlag(true);
        public Element cancelRegularDepositTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "Select"), tag: "CheckBox"));



        public Element remarksBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=uteRemarks"), "/Edit"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class CancelRegularDepositP1Data : PageData
    {
        public string cancelRegularDepositTable { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}
