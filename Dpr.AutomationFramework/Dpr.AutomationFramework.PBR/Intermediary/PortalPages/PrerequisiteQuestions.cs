
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PBR.Intermediary.PortalPages
{
    class PrerequisiteQuestions : WebBasePage
    {

        public PrerequisiteQuestions()
        {
            pageLoadedElement = PrerequisiteQuestion1;
            //correspondingDataClass = new PrerequisiteQuestionsData().GetType();
            //This is the label for the Accept Declaration radio button, since the radio button itself is behind the label and .Displayed = false
            //pageLoadedElement = new Element(FindElement(new LocatorList()
            //    .Add(Defs.locatorFor, "AcceptDeclaration")));
            correspondingDataClass = new PrerequisiteQuestionsData().GetType();
            javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1','bPrerequisiteQuestions')";
            validateAllRadioButtonCombinations = true;
        }

        #region Locators


        public Element PrerequisiteQuestion1 => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl00"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl00")));

        public Element PrerequisiteQuestion2 => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl01"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl01")));

        public Element PrerequisiteQuestion3 => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl02"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl02")));

        public Element PrerequisiteQuestion4 => new Element(new RadioButton()
             .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl03"))
             .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl03")));

        public Element PrerequisiteQuestion5 => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl04"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl04")));

        public Element PrerequisiteQuestion6 => new Element(new RadioButton()
             .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl05"))
             .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl05")));

        public Element PrerequisiteQuestion7 => new Element(new RadioButton()
             .AddRadioButtonElement(Defs.radioButtonYes, FindElement("Question", "rbl_0", "ctl06"))
             .AddRadioButtonElement(Defs.radioButtonNo, FindElement("Question", "rbl_1", "ctl06")));

        public Element IntermediaryDeclaration => new Element(FindElement("MC_ucPrerequisiteQuestions_ctl18_ctl00_chkAcceptDeclaration"));


        #endregion
        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true);
            //.SetIsPageContinueButtonFlag(true);

    }


    public class PrerequisiteQuestionsData : PageData
    {
       
        public string PrerequisiteQuestion1 { set; get; } = Defs.radioButtonYes;
        public string PrerequisiteQuestion2 { set; get; } = Defs.radioButtonYes;
        public string PrerequisiteQuestion3 { set; get; } = Defs.radioButtonYes;
        public string PrerequisiteQuestion4 { set; get; } = Defs.radioButtonYes;
        public string PrerequisiteQuestion5 { set; get; } = Defs.radioButtonYes;

        public string PrerequisiteQuestion6 { set; get; } = Defs.radioButtonYes;
        public string PrerequisiteQuestion7 { set; get; } = Defs.radioButtonYes;
        public string IntermediaryDeclaration { set; get; } = Defs.checkBoxSelected;
    }
}
