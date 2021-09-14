using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ExtendOfferWizard
{
    public class ExtendOfferP1 : BOWizardBasePage
    {
        public ExtendOfferP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ExtendOfferP1Data().GetType();
            textName = "Extend Offer Page 1";
            windowTitle = "Offer Extension";
        }
        #region 'Extend Offer Expiry Date' Section
        public Element currentOfferExpiryDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraDateTimeEditor"),
            "[1]"));
            
        public Element proposedofferExpiryDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraDateTimeEditor"),
            "[2]"));
        #endregion

        #region 'Valuation Expiry Date' Section
        #region 'Primary Security' Subsection
        public Element securityAddress => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "tbSecurityAddress")));

        public Element valuationExpiry => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "gbPrimarySecurity"),
            "/Edit[starts-with(@ClassName,\"WindowsForms10\")]" +
            "/Edit[@AutomationId=\"[Editor\"]"));
        #endregion
        #endregion

        public Element next => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ExtendOfferP1Data : PageData
    {
        public string _tomorrowsDate;
        public ExtendOfferP1Data()
        {
            // 16/06/2020: Uncomment this when the valuation Expiry box becomes editable.
            //_tomorrowsDate = DateTime.Today.ToString("dd/MM/yyyy");
        }

        public string valuationExpiry
        {
            get
            {
                if(_tomorrowsDate == null)
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
                        + _tomorrowsDate.Replace("/", "");
                }
            }
            set
            {
                _tomorrowsDate = value;
            }
        }
    }
}
