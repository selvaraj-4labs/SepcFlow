using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSearch
{
    public class CaseSearchTab : AppBasePage
    {
        // Used in some of the Xpaths.
        // Required after 05/02/2020.
        public string caseId;

        public CaseSearchTab()
        {
            pageLoadedElement = caseIdSearchBox;
            correspondingDataClass = new MainPageData().GetType();
            textName = "Case Search Tab";
            caseId = "";
        }

        public Element caseIdSearchBox => new Element(FindElement("teSDCaseId", attributeType: Defs.boLocatorAutomationId));

        public Element brokerNameBox => new Element(FindElement("teSDBrokerName", attributeType: Defs.boLocatorAutomationId));

        public Element brokerRefBox => new Element(FindElement("teSDBrokerRef", attributeType: Defs.boLocatorAutomationId));

        public Element receiptDataRbtn =>   new Element(new RadioButton()    
            .AddRadioButtonElement("Today", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "Today")))
            .AddRadioButtonElement("7 Days", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "7 Days")))
            .AddRadioButtonElement("28 Days", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "28 Days")))
            .AddRadioButtonElement("3 Months", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "3 Months")))
            .AddRadioButtonElement("3 Months", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "3 Months")))
            .AddRadioButtonElement("12 Months", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "12 Months")))
            .AddRadioButtonElement("All", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osSDReceiptDate")
                    .Add(Defs.boLocatorName, "All"))));

        public Element appSurnameBox => new Element(FindElement("teSDAppSurname", attributeType: Defs.boLocatorAutomationId));

        public Element appForenameBox => new Element(FindElement("teSDAppForename", attributeType: Defs.boLocatorAutomationId));

        public Element appDOBBox => new Element(FindElement("  /  /    ", attributeType: Defs.boLocatorName));

        public Element addressBox => new Element(FindElement("teSDAddress", attributeType: Defs.boLocatorAutomationId));

        public Element postcodeBox => new Element(FindElement("tePostcode", attributeType: Defs.boLocatorAutomationId));

        public Element tradingNameBox => new Element(FindElement("teCompanyName", attributeType: Defs.boLocatorAutomationId));

        public Element lenderLookup => new Element(FindElement("ceSDLender", attributeType: Defs.boLocatorAutomationId));

        public Element productCodeBox => new Element(FindElement("teSDProductCode", attributeType: Defs.boLocatorAutomationId));

        public Element variantCodeBox => new Element(FindElement("teSDVariantCode", attributeType: Defs.boLocatorAutomationId));

        public Element teamLookup => new Element(FindElement("ceSDTeam", attributeType: Defs.boLocatorAutomationId));

        public Element accountCategoryLookup => new Element(FindElement("ceAcctCategory", attributeType: Defs.boLocatorAutomationId));

        public Element lastTenCasesRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osLast10Casesworkedon")
                    .Add(Defs.boLocatorName, "Yes")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osLast10Casesworkedon")
                    .Add(Defs.boLocatorName, "No"))));

        public Element caseStatusLookup => new Element(FindElement("ceSDCaseStatus", attributeType: Defs.boLocatorAutomationId));

        public Element caseSubmittedRbtn => new Element(new RadioButton()            
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(
                new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osCaseSubmitted")
                .Add(Defs.boLocatorName, "Yes")))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osCaseSubmitted")
                    .Add(Defs.boLocatorName, "No")))
            .AddRadioButtonElement("All", FindElement(
                new LocatorList()
                    .Add(Defs.boLocatorAutomationId, "osCaseSubmitted")
                    .Add(Defs.boLocatorName, "All"))));

        public Element userLookup => new Element(FindElement("ceSDUser", attributeType: Defs.boLocatorAutomationId));

        public Element clearBtn => new Element(FindElement("btnSDClear", attributeType: Defs.boLocatorAutomationId));

        public Element searchBtn => new Element(FindElement("btnSDSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

        public Element firstRowBoxID => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"),
            "/DataItem[@Name=\"" + caseId + "\"]" +
            "/Edit[@Name=\"ID\"]"))
            .SetCompletePageFlag(false);

        public Element firstRowBoxStatus => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGrid"),
            "/Custom[@Name =\"ArrayList row 1\"]" +
            "/DataItem[@Name=\"Status\"]"))
            .SetCompletePageFlag(false);
    }

    public class MainPageData : PageData
    {
    }
}
