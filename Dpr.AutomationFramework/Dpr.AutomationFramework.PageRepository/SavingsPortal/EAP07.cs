using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP07 : WebBasePage
    {
        public EAP07()
        {
            pageLoadedElement = indiviualOrCompanyLookup;
            correspondingDataClass = new EAP07Data().GetType();
            textName = "Shareholder 1 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "1")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "4"))));
        }

        #region Details

        public Element indiviualOrCompanyLookup => new Element(FindElement("IsCompanyApplicantInput"));

        public Section individualSelectionSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "indiviualOrCompany", "Individual", Defs.conditionTypeEqual))
            ));

        public Element titleLookup => new Element(FindElement("cboTitle"));

        public Element firstNameBox => new Element(FindElement("txtFirstName"));

        public Element middleNameBox => new Element(FindElement("txtMiddleName"));

        public Element lastNameBox => new Element(FindElement("txtSurname"));

        public Element dateOfBirthBox => new Element(FindElement("txtDateOfBirth"));

        public SectionEnd individualSelectionSectionEnd => new SectionEnd();


        public Section companySelectionSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "indiviualOrCompany", "Company", Defs.conditionTypeEqual))
            ));

        public Element fullBusinessNameBox => new Element(FindElement("CompanyNameInput"));

        public Element registrationNumberBox => new Element(FindElement("CompanyNumberInput"));

        public SectionEnd companySelectionSectionEnd => new SectionEnd();

        #endregion

        #region Current Address

        public Element postcodeBox => new Element(FindElement("SearchPostCode"));

        public Element buildingNumberNameBox => new Element(FindElement("SearchAddressLine"));

        public Element findAddressBtn => new Element(FindElement("SearchButton"))
            .SetIsButtonFlag(true);

        public WaitFor waitForAddressSearch => new WaitFor(findAddressBtn)
            .AddWaitElement(addressLbl.locator);

         public Element addressLbl => new Element(FindElement("GetFullAddress"))
            .SetCompletePageFlag(false);

        #endregion

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true);

    }

    public class EAP07Data : PageData
    {
        public string indiviualOrCompany { get; set; } = "Individual";
        public string uniqueIdentifier { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public EAP07Data()
        {
            uniqueIdentifier = UniqueStringGenerator();
            firstName = "testFName-" + uniqueIdentifier;
            lastName = "testLName-" + uniqueIdentifier;
        }

        public string title { get; set; } = "Mr";

        public string middleName { get; set; } = "testMName";

        public string dateOfBirth { get; set; } = "09/12/1999";


        public string fullBusinessName { get; set; } = "TestShareholderCompany";

        public string registrationNumber { get; set; } = "0123456";

        public string postcode { get; set; } = "cm1 4uw";

        public string buildingNumberName { get; set; } = "12";

    }

}
