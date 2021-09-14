using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.IssueOfferWizard
{
    public class IssueOfferP1 : BOWizardBasePage
    {
        public IssueOfferP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new IssueOfferP1Data().GetType();
            textName = "Issue Offer Page 1";
            windowTitle = "Issue Offer ";
        }

        #region 'Loan Details' Section
        public Element purchasePrice => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "nePurchasePrice"),
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element loanAmount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neLoanAmount"),
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element loanToValue => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neLTV"),
            "/Edit[@AutomationId=\"[Editor\"]"));
        
        public Element maxLoanAmount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceMaxLoanAmount"),
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element initialTermYears => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neInitialYearsOriginal"),
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element initialTermMonths => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neInitialMonthsOriginal"),
            "/Edit[@AutomationId=\"[Editor\"]"));
        #endregion

        #region 'Product 1' Section
        public Element productCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtProductCode"),
            "/Edit[@AutomationId=\"[Editor] Edit Area\"]"));

        public Element repaymentAmount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceRepayment")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));

        public Element interestOnlyAmount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceInterestOnly")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));


        public Element repaymentTermYears => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neRepaymentYears")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));

        public Element repaymentTermMonths => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neRepaymentMonths")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));

        public Element interestOnlyTermYears => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neInterestOnlyYears")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));

        public Element interestOnlyTermMonths => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "neInterestOnlyMonths")
            .Add(Defs.boLocatorAutomationId, "[Editor] Edit Area"), tag: "Edit"));
        #endregion

        #region 'Expiry' Section
        public Element offerExpiryDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId =\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId =\"[Editor\"]"));
        #endregion

        #region 'Issue Offer' Section
        public Element nonBindingOffer => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"][@AutomationId=\"[Editor\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"][@AutomationId=\"[Editor\"]")));
        #endregion

        public Element next => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class IssueOfferP1Data : PageData
    {

        private string _offerExpiryDate = null;

        public string offerExpiryDate
        {
            get
            {
                if (_offerExpiryDate == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + Keys.Backspace
                        + _offerExpiryDate.Replace("/", "");
                }
            }
            set
            {
                _offerExpiryDate = value;
            }
        }

        public string nonBindingOffer { get; set; } = null;
    }
}
