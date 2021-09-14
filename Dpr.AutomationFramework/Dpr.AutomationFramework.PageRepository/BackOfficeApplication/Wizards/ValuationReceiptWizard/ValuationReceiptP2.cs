using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ValuationReceiptWizard
{
    public class ValuationReceiptP2 : BOWizardBasePage
    {
        public ValuationReceiptP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new ValuationReceiptP2Data().GetType();
            textName = "Valuation Receipt Page 2";
            windowTitle = "Valuation Receipt (Quest)";
        }

        #region 'Standard Valuation' Section
        public Section standardValuationSection => new Section(new Element(new ConditionList()
            .Add(new Condition("ValuationReceiptP1", "typeOfValuation", "Standard Valuation"))));

        #region 'Residential Mortgage Valuation Report' Section
        public Element applicationNumber => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[1]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));

        public Element applicants => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "DprOptionEditableField"),
                "[2]/Pane[@AutomationId=\"rightPanel\"]" +
                "/ComboBox[@AutomationId=\"ultraOptionSet\"]" +
                "/RadioButton[@Name=\"No\"]")));
        #endregion

        #region 'Property' Section
        public Element propertyType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "PropertyType"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/ComboBox[@AutomationId=\"ultraComboEditor\"]" +
            "/Edit"));

        public Element propertyIfOtherDetails => new Element(FindElement(
            new LocatorList()
                .Add(Defs.boLocatorAutomationId, "TypeOtherDetails"),
                "/Pane[@AutomationId=\"rightPanel\"]" +
                "/Edit[@AutomationId=\"ultraTextEditor\"]" +
                "/Edit"),
            new ConditionList()
            .Add(new Condition(className, "propertyType", "Other")));
        #endregion

        #region 'New Build Properties' Section

        #endregion
        public SectionEnd standardValuationSectionEnd => new SectionEnd();
        #endregion

        #region 'Re-inspection' Section
        public Section reInspectionSection => new Section(new Element(new ConditionList()
            .Add(new Condition("ValuationReceiptP1", "typeOfValuation", "Re-inspection"))));

        public SectionEnd reInspectionSectionEnd => new SectionEnd();
        #endregion

        #region 'Re-Type with Photos' Section
        public Section reTypeWithPhotosSection => new Section(new Element(new ConditionList()
            .Add(new Condition("ValuationReceiptP1", "typeOfValuation", "Re-Type with Photos"))));

        public SectionEnd reTypeWithPhotosSectionEnd => new SectionEnd();
        #endregion

        #region 'AVM' Section
        public Section avmSection => new Section(new Element(new ConditionList()
            .Add(new Condition("ValuationReceiptP1", "typeOfValuation", "AVM"))));

        public SectionEnd avmSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class ValuationReceiptP2Data : PageData
    {
        #region 'Standard Valuation' Section
        #region 'Residential Mortgage Valuation Report' Section
        public string applicationNumber { get; set; } = Defs.radioButtonYes;
        public string applicants { get; set; } = Defs.radioButtonYes;
        #endregion

        #region 'Property' Section

        #endregion

        #region 'New Build Properties' Section

        #endregion
        #endregion
    }
}
