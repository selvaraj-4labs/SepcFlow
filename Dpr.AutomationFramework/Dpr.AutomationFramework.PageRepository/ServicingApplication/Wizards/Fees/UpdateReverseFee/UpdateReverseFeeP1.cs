using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.UpdateReverseFee
{
    public class UpdateReverseFeeP1 : AppBasePage
    {
        public UpdateReverseFeeP1()
        {
            pageLoadedElement = firstFeeBox;
            correspondingDataClass = new UpdateReverseFeeP1Data().GetType();
            textName = "Update Reverse Fee Page 1";
        }

        //Is not a button be requires to be clicked every journey.
        public Element firstFeeBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "feeListWaiveGrid"),
            "/Group[@Name=\"Fee List\"][@AutomationId=\"gbSearchDetail\"]/MenuItem[@AutomationId=\"dgSearchDetail\"]/Table[@AutomationId=\"ultraGrid\"]/Custom[@Name=\"List`1 row 1\"]/DataItem[@Name=\"Category\"]"))   
            .SetIsButtonFlag(true);
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class UpdateReverseFeeP1Data : PageData
    {

        public string remarks { set; get; } = null;
    }
}
