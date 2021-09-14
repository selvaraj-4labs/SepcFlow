using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication
{
    public class AccountSearchCriteriaPage : AppBasePage
    {
        public string caseId;

        public AccountSearchCriteriaPage()
        {
            pageLoadedElement = accountsSearchBtn;
            correspondingDataClass = new AccountSearchCriteriaPageData().GetType();
            textName = "Account Search Criteria";
            caseId = "";
        }

        //public Element accountNumberBox => new Element(FindElement("txtLoanAccountNo", attributeType: Defs.boLocatorAutomationId))
        //    .SetCompletePageFlag(false);


        public Element accountNumberBox => new Element(By.Id("txtLoanAccountNo"))
            .SetCompletePageFlag(false);


        //public Element accountNumberBox => new Element(By.XPath
        //    (//"//Pane[@ClassName=\"#32769\"][@Name=\"Desktop 1\"]" +
        //    //"/Window[@Name=\"Account Servicing - Customer Locate\"][@AutomationId=\"MdiHost\"]" +
        //    "//Pane[starts-with(@ClassName,\"WindowsForms10\")]" +
        //    "/Window[@Name=\"Customer Locate\"][@AutomationId=\"SolutionBoundWindowForm\"]" +
        //    "/Pane[starts-with(@AutomationId,\"Searcher\")]" +
        //    "/Pane[@AutomationId=\"searchCriteriaPanel\"]" +
        //    "/Group[@Name=\"Account Search Criteria\"][@AutomationId=\"gbAccountSearchCriteria\"]" +
        //    "/Edit[@AutomationId=\"txtLoanAccountNo\"]"
        //    )).SetCompletePageFlag(false);

        public Element originationReferenceNumberBox => new Element(FindElement("txtOriginationRefNo ", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element securityTownCityBox => new Element(FindElement("gbAccountSearchCriteria", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element securityPostalCode => new Element(FindElement("txtPostalCodeSecurity", attributeType: Defs.boLocatorAutomationId))
            .SetCompletePageFlag(false);

        public Element accountsClearBtn => new Element(FindElement("btnClearAccountCriteria", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true)
                        .SetCompletePageFlag(false);

        public Element accountsSearchBtn => new Element(FindElement("btnSearchByAccountCriteria", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true)
                        .SetCompletePageFlag(false);

        //public Element accountsGridFirstRow => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "\"accountDetailsGrid"), "/Table[@AutomationId=ultraGrid']/Custom[@Name='List`1 row 1']"))
        //                .SetCompletePageFlag(false);
        //public Element accountsGridFirstRow => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"),
        //    "/DataItem[@Name=\"" + caseId + "\"]" +
        //    "/Edit[@Name=\"Account No\"]"))
        //    .SetCompletePageFlag(true);


        public Element accountsGridFirstRow => new Element(By.XPath(
                "//Pane[starts-with(@ClassName,\"WindowsForms10\")]" +
                "/Window[@Name=\"Customer Locate\"][@AutomationId=\"SolutionBoundWindowForm\"]" +
                "/Pane[starts-with(@AutomationId,\"Searcher\")]" +
                "/Group[@Name=\"Accounts\"][@AutomationId=\"accountDetailsGroupBox\"]" +
                "/Pane[@AutomationId=\"accountDetailsGrid\"]" +
                "/Custom[@AutomationId=\"ultraGrid\"]" +
                "/Custom[@AutomationId=\"Data Area\"]" +
                "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]" +
                "/DataItem[@Name=\"" + caseId + "\"]" +
                "/Edit[@Name=\"Account No\"]" +
                "/Edit"))
            .SetCompletePageFlag(false);


        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element customerNumberBox => new Element(FindElement("txtCustomerNo", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element dateOfBirthBox => new Element(FindElement("dtDOB", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element phoneNumberBox => new Element(FindElement("txtPhoneNo", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element businessNameBox => new Element(FindElement("txtBusinessName", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element niNumberBox => new Element(FindElement("txtNINo", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element postalCodeBox => new Element(FindElement("txtPostalCode", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element townCityBox => new Element(FindElement("txtTownCity", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element idDocumentNumber => new Element(FindElement("txtIDDocumentNo", attributeType: Defs.boLocatorAutomationId))
                        .SetCompletePageFlag(false);

        public Element partyClearBtn => new Element(FindElement("btnClearPartyCriteria", attributeType: Defs.boLocatorAutomationId))
                                    .SetIsButtonFlag(true)
                                    .SetCompletePageFlag(false);

        public Element partySearchBtn => new Element(FindElement("btnSearchByPartyCriteria", attributeType: Defs.boLocatorAutomationId))
                                    .SetIsButtonFlag(true);
    }

    public class AccountSearchCriteriaPageData : PageData
    {
    }

}
