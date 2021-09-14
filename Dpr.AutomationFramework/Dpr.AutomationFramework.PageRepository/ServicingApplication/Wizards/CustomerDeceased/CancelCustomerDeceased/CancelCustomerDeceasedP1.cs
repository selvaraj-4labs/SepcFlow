using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CancelCustomerDeceased
{
    public class CancelCustomerDeceasedP1 : AppBasePage
    {
        public CancelCustomerDeceasedP1()
        {
            pageLoadedElement = customerNumber;
            correspondingDataClass = new CancelCustomerDeceasedP1Data().GetType();
            textName = "Cancel Customer Deceased Page 1";
        }


        public Element customerNumber => new Element(FindElement("=txtCustomerNumber", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element customerName => new Element(FindElement("=txtCustomerName", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element inCareHome => new Element(FindElement("=chkInCareHome", attributeType: Defs.boLocatorAutomationId, tag: "CheckBox"))
            .SetCompletePageFlag(false);

        public Element date => new Element(FindElement("=dtInCareHomeDate", attributeType: Defs.boLocatorAutomationId, tag: "Edit"))
            .SetCompletePageFlag(false);

        public Element deceasedNotificationDate => new Element(FindElement("=dtDeceasedNotificationDate", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"))
            .SetCompletePageFlag(false);

        public Element cancelCustomerDeceased => new Element(FindElement("=chkCancelCustomerDeceased", attributeType: Defs.boLocatorAutomationId, tag: "CheckBox"));

        public Element reason => new Element(FindElement("=ceReason", attributeType: Defs.boLocatorAutomationId, tag: "ComboBox"));

        public Element remarksBox => new Element(FindElement("=txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("=pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CancelCustomerDeceasedP1Data : PageData
    {
   
        public string cancelCustomerDeceased { get; set; } = Defs.checkBoxSelected;
        public string reason { get; set; } = "Updated in Error";

        public string remarks { get; set; } = "TestRemarks";
    }
}
