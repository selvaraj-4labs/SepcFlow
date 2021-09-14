using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP03 : WebBasePage
    {
        public CBS_ADV_DIP03()
        {
            pageLoadedElement = branch;
            correspondingDataClass = new CBS_ADV_DIP03Data().GetType();
            textName = "CBS Advised Submission Route Details Page";
        }

        #region 'Adviser Details' Section
        public Element branch => new Element(FindElement("ctl00_ctl00_Details", tag: "select"));
        public Element adviser => new Element(FindElement("ctl00_ctl01_Details", tag: "select"));
        #endregion

        #region 'Submission Route Details' Section
        public Element whatKindOfSale => new Element(new RadioButton()
            .AddRadioButtonElement("Advised", FindElement("ctl02_LevelOfAdvice_btn_rbl_0"))
            .AddRadioButtonElement("Execution Only", FindElement("ctl02_LevelOfAdvice_btn_rbl_1")));

        #region 'Advised' Section
        public Section advisedSaleSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "whatKindOfSale", "Advised"))));
        public Element advisedGenerateIDD => new Element(FindElement("ctl00_GenerateIddBtn"))
            .SetIsButtonFlag(true);
        public Element advisedIddGenerationMessage => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MainCnt_ucSubmissionRoute_AdvisedIDDGenerator_ctl00_DynamicIddPanel1"),
            "/a"));
        public WaitFor advisedWaitForIDD => new WaitFor(null)
            .AddWaitElement(advisedIddGenerationMessage.locator);
        public SectionEnd advisedSaleSectionEnd => new SectionEnd();
        #endregion

        #region 'Execution Only' Section
        public Section executionOnlySaleSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "whatKindOfSale", "Execution Only"))));
        public Element executionOnlyDeclaration => new Element(FindElement("chkAcceptExecutionOnlyDeclaration"));
        public Element executionOnlyGenerateIDD => new Element(FindElement("ExecutionOnlyIDDGenerator_ctl00_GenerateIddBtn"))
            .SetIsButtonFlag(true);
        public Element executionOnlyIddGenerationMessage => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "MainCnt_ucSubmissionRoute_ExecutionOnlyIDDGenerator_ctl00_DynamicIddPanel1"),
            "/a"));
        public WaitFor executionOnlyWaitForIDD => new WaitFor(null)
            .AddWaitElement(executionOnlyIddGenerationMessage.locator);
        public SectionEnd executionOnlySaleSectionEnd => new SectionEnd();
        #endregion
        #endregion

        public Element iddExplanation => new Element(FindElement("ctl05_chkAcceptDeclaration"));

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_ADV_DIP03Data : PageData
    {
        #region 'Adviser Details' Data Section
        public string branch { get; set; } = "Central Cambridge";
        public string adviser { get; set; } = "Admin User";
        #endregion

        #region 'Submission Route Details' Data Section
        public string whatKindOfSale { get; set; } = "Advised";
        
        #region 'Advised' Section
        public string advisedGenerateIDD { get; set; } = Defs.checkBoxSelected;
        #endregion

        #region 'Execution Only' Data Section
        public string executionOnlyDeclaration { get; set; } = Defs.checkBoxSelected;
        #endregion

        public string iddExplanation { get; set; } = Defs.checkBoxSelected;
        #endregion

    }
}
