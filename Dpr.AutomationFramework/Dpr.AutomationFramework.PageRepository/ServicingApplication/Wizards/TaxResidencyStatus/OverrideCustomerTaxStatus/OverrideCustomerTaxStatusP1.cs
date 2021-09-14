using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.OverrideCustomerTaxStatus
{
    public class OverrideCustomerTaxStatusP1 : AppBasePage
    {
        public OverrideCustomerTaxStatusP1()
        {
            pageLoadedElement = customer;
            correspondingDataClass = new OverrideCustomerTaxStatusP1Data().GetType();
            textName = "Override Customer Tax Status Page 1";
        }
        public Element customer => new Element(FindElement("txtCustomer", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        public Element taxStatus => new Element(FindElement("txtTaxStatus", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);

        #region Request Details Section

        public Element date => new Element(FindElement("dtDate", attributeType: Defs.boLocatorAutomationId)).SetCompletePageFlag(false);


        public Element requestResource => new Element(FindElement("cboRequestResource", attributeType: Defs.boLocatorAutomationId));

        public Element reason => new Element(FindElement("cboReason", attributeType: Defs.boLocatorAutomationId));

        public Element effectiveDate => new Element(FindElement("dtEffectiveDate", attributeType: Defs.boLocatorAutomationId));

        public Element capitaliseOutstandingInterest => new Element(FindElement("chkInterestPosted", attributeType: Defs.boLocatorAutomationId));

        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class OverrideCustomerTaxStatusP1Data : PageData
    {

        public string requestResource { get; set; } = "Customer";
        public string capitaliseOutstandingInterest { get; set; } = null;

        public string reason { get; set; } = "Income below tax threshold (R85)";

        public string effectiveDate { get; set; } = null;

        public string remarks { get; set; } = "TestRemarks";
    }
}
