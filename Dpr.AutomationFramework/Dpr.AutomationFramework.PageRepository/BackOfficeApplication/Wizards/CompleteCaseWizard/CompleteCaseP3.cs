using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.CompleteCaseWizard
{
    public class CompleteCaseP3 : BOWizardBasePage
    {
        public CompleteCaseP3()
        {

            pageLoadedElement = confirmBusinessRulesProcessingLbl;
            correspondingDataClass = new CompleteCaseP2Data().GetType();
            textName = "Complete Case Page 3";

        }

        public Element confirmBusinessRulesProcessingLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Confirm Business Rules Processing")
            .Add(Defs.boLocatorAutomationId, "lblTitle")))
            .SetCompletePageFlag(false);


        public Element primaryAccountExistsInServicing => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "ultraOptionSet"), "/Group/RadioButton[@Name='No']"))
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "ultraOptionSet"), "/Group/RadioButton[@Name='Yes']"))
            );


        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CompleteCaseP3Data : PageData
    {
        public string primaryAccountExistsInServicing { get; set; } = null;
    }

}
