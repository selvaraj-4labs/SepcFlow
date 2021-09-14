using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ProcessCOTWizard
{
    public class ProcessCOTP1 : BOWizardBasePage
    {
        public ProcessCOTP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ProcessCOTP1Data().GetType();
            textName = "Process COT Page 1";
            windowTitle = "Process COT /Change Approved";
        }

        #region Non Editable Values
        public Element applicationNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[1]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element applicant1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "Applicant1"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element netToBorrower => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprCurrencyEditableField"),
            "[1]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[starts-with(@AutomationId,\"dprCurrencyEditor\")]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element mortgageAccountAmount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprCurrencyEditableField"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[starts-with(@AutomationId,\"dprCurrencyEditor\")]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element purchasePrice => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprCurrencyEditableField"),
            "[3]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[starts-with(@AutomationId,\"dprCurrencyEditor\")]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element solicitorsActing => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element tenureType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "TenureType"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element previousCompletionDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[1]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element sortCode => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "SortCode"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element accountNumber => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "AccountNumber"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));
        #endregion

        #region Editable Values
        public Element legalOwnershipDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[2]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element fundsReleaseDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[3]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element completion => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[4]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraDateTimeEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber1 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "TitleNameteControl"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber2 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "TitleName2teControl"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element titleNumber3 => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "TitleName3teControl"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element dateOfLenderInsturctionOffer => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[5]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element nameOfAuthorisedSignatory => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprTextEditableField"),
            "[3]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element qualificationOfAuthorisedSignatory => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ProcessCotSignatoryQualification"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element dateOfSignature => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprDateTimeEditableField"),
            "[6]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element priceStatedInTransfer => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "DprCurrencyEditableField"),
            "[4]/Pane[@AutomationId=\"rightPanel\"]" +
            "/Edit[@AutomationId=\"ultraTextEditor\"]" +
            "/Edit[@AutomationId=\"[Editor\"]"));

        public Element isTheCOTSigned => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"][@AutomationId=\"[Editor\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"][@AutomationId=\"[Editor\"]")));

        public Element haveAnyAmendmentsBeenMade => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"][@AutomationId=\"[Editor\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"][@AutomationId=\"[Editor\"]")));
        #endregion

        public Element next => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    // TODO: Complete the default data.
    // Legal Ownership Date and Funds Released Date = Tomorrow. 
    public class ProcessCOTP1Data : PageData
    {
        private string _tomorrowsDate;
        private string _todaysDate;

        public ProcessCOTP1Data()
        {
            _tomorrowsDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
            _todaysDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
        }

        public string legalOwnershipDate
        {
            get
            {
                if (_tomorrowsDate == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _tomorrowsDate.Replace("/", "");
                }
            }
            set
            {
                _tomorrowsDate = value;
            }
        }
        public string fundsReleaseDate
        {
            get
            {
                if (_tomorrowsDate == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _tomorrowsDate.Replace("/", "");
                }
            }
            set
            {
                _tomorrowsDate = value;
            }
        }
        public string completion
        {
            get
            {
                if (_tomorrowsDate == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _tomorrowsDate.Replace("/", "");
                }
            }
            set
            {
                _tomorrowsDate = value;
            }
        }
        public string titleNumber1 { get; set; } = "1";
        public string titleNumber2 { get; set; } = "1";
        public string titleNumber3 { get; set; } = "1";
        public string dateOfLenderInsturctionOffer
        {
            get
            {
                if (_todaysDate == null)
                {
                    return null;
                }
                else
                {
                    return Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _todaysDate.Replace("/", "");
                }
            }
            set
            {
                _todaysDate = value;
            }
        }
        public string nameOfAuthorisedSignatory { get; set; } = "Test";
        public string qualificationOfAuthorisedSignatory { get; set; } = "Signatory";
        public string priceStatedInTransfer { get; set; } = "200000";
        public string isTheCOTSigned { get; set; } = Defs.radioButtonYes;
        public string haveAnyAmendmentsBeenMade { get; set; } = Defs.radioButtonNo;
    }
}
