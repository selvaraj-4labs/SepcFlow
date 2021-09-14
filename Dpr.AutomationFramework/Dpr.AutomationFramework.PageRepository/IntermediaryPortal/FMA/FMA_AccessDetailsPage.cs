using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_AccessDetailsPage : WebBasePage
    {
        public FMA_AccessDetailsPage()
        {
            pageLoadedElement = selectValidationType;
            correspondingDataClass = new FMA_AccessDetailsPageData().GetType();
            textName = "FMA Access Details Page";
        }

        #region 'Valuation Type' Section
        public Element selectValidationType => new Element(FindElement("cboValuationType"));
        #endregion

        #region 'Arrangements To Access Property' Section
        public Element contact => new Element(FindElement("cboContactType"));
        public Element contactName => new Element(FindElement("txtContactName"));
        public Element contactTelephoneNumber => new Element(FindElement("txtContactTelephone"));
        public Element contactEmail => new Element(FindElement("txtContactEmail"));
        public Element anyAdditionalInformation => new Element(FindElement("txtAdditionalNotes"));
        #endregion

        #region 'Other Occupants' Section
        public Element anyOtherOccupants => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("radAdditionalOccupiers_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("radAdditionalOccupiers_btn", "_rbl_1")),
            new ConditionList()
                .Add(new Condition("DIP_ApplicationSummaryPage", "_loanType", "Residential")));

        public Section otherOccupantsSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "anyOtherOccupants", Defs.radioButtonYes))));

        // Other Occupants - Occupant 1
        public Element firstName_1 => new Element(FindElement("item0", "txtName"));
        public Element surname_1 => new Element(FindElement("item0", "txtSurname"));
        public Element dateOfBirth_1 => new Element(FindElement("item0", "txtDateOfBirth"));
        public Element relationship_1 => new Element(FindElement("item0", "cboRelationship"));

        // Other Occupants - Occupant 2
        public Element firstName_2 => new Element(FindElement("item1", "txtName"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_2", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element surname_2 => new Element(FindElement("item1", "txtSurname"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_2", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element dateOfBirth_2 => new Element(FindElement("item1", "txtDateOfBirth"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_2", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element relationship_2 => new Element(FindElement("item1", "cboRelationship"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_2", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);

        // Other Occupants - Occupant 3
        public Element firstName_3 => new Element(FindElement("item2", "txtName"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_3", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element surname_3 => new Element(FindElement("item2", "txtSurname"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_3", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element dateOfBirth_3 => new Element(FindElement("item2", "txtDateOfBirth"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_3", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element relationship_3 => new Element(FindElement("item2", "cboRelationship"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_3", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);

        // Other Occupants - Occupant 4
        public Element firstName_4 => new Element(FindElement("item3", "txtName"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_4", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element surname_4 => new Element(FindElement("item3", "txtSurname"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_4", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element dateOfBirth_4 => new Element(FindElement("item3", "txtDateOfBirth"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_4", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);
        public Element relationship_4 => new Element(FindElement("item3", "cboRelationship"),
            new ConditionList()
            .Add(new Condition(className, "otherOccupants_4", null, Defs.conditionTypeNotEqual)),
            addOtherOccupants);

        public Element addOtherOccupants => new Element(FindElement("rptOtherOccupants", "ctl01_btnAdd")).SetCompletePageFlag(false);

        public SectionEnd otherOccupantsSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }
    public class FMA_AccessDetailsPageData : PageData
    {
        public string selectValidationType { get; set; } = "Standard";
        public string contact { get; set; } = "Selling Agent";
        public string contactName { get; set; } = "TestContactName";
        public string contactTelephoneNumber { get; set; } = "01245678999";
        public string contactEmail { get; set; } = "testvaluer@test.com";
        public string anyAdditionalInformation { get; set; } = "TestAdditionalInformation";
        
        public string anyOtherOccupants { get; set; } = Defs.radioButtonNo;

        public string firstName_1 { get; set; } = null;
        public string surname_1 { get; set; } = null;
        public string dateOfBirth_1 { get; set; } = null;
        public string relationship_1 { get; set; } = null;
        
        public string otherOccupants_2 { get; set; } = null;
        public string firstName_2 { get; set; } = null;
        public string surname_2 { get; set; } = null;
        public string dateOfBirth_2 { get; set; } = null;
        public string relationship_2 { get; set; } = null;

        public string otherOccupants_3 { get; set; } = null;
        public string firstName_3 { get; set; } = null;
        public string surname_3 { get; set; } = null;
        public string dateOfBirth_3 { get; set; } = null;
        public string relationship_3 { get; set; } = null;

        public string otherOccupants_4 { get; set; } = null;
        public string firstName_4 { get; set; } = null;
        public string surname_4 { get; set; } = null;
        public string dateOfBirth_4 { get; set; } = null;
        public string relationship_4 { get; set; } = null;
    }
}
