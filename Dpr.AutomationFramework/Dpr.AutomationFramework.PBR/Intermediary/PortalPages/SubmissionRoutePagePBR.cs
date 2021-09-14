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
    class SubmissionRoutePagePBR : WebBasePage
    {
        public SubmissionRoutePagePBR()
        {
            pageLoadedElement = submissionRouteDetailsHeading;
            correspondingDataClass = new SubmissionRouteData().GetType();
            //javascriptPageNavigator = @"javascript:__doPostBack('ctl00$MC$Menu1','bSubmissionRouteSimple')";
        }

        #region Locators

        public Element submissionRouteDetailsHeading => new Element(FindElement(new LocatorList().Add(Defs.locatorText, "Submission Route Details")))
            .SetCompletePageFlag(false);

        public Element typeOfSaleRbtn => new Element(
            new RadioButton()
            .AddRadioButtonElement("Advised", FindElement("LevelOfAdvice", "rbl_0"))
            .AddRadioButtonElement("Execution Only", FindElement("LevelOfAdvice", "rbl_1")));
        //new ConditionList()
        //.Add(new Condition("ApplicantLoanTypePage", "loanType", "Residential")));

        public Element adviceRejectedRbtn => new Element(
            new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoIsAdviceRejected", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoIsAdviceRejected", "rbl_1")));
            //new ConditionList()
            //.Add(new Condition("ApplicantLoanTypePage", "loanType", "Residential"))
            //.Add(new Condition(className, "typeOfSale", "Advised")));

        public Element applicationSubmittedViaMCOrDistRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("IsMortgageClubApplication", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("IsMortgageClubApplication", "rbl_1")));


        public Element mortgageClubLookup => new Element(FindElement("_MortgageClub"), new ConditionList()
            .Add(new Condition(className, "applicationSubmittedViaMCOrDist", Defs.radioButtonYes)));

        public Element lenderAllowSomeoneToHelpMortgageRbtn => new Element(new RadioButton()
           .AddRadioButtonElement(Defs.radioButtonYes, FindElement("qffLenderAllowedSomeoneToHelp", "rbl_0"))
           .AddRadioButtonElement(Defs.radioButtonNo, FindElement("qffLenderAllowedSomeoneToHelp", "rbl_1")));


        #endregion
        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

    }


    public class SubmissionRouteData : PageData
    {
        public string typeOfSale { get; set; } = "Advised";
        public string adviceRejected { get; set; } = Defs.radioButtonNo;
        public string applicationSubmittedViaMCOrDist { get; set; } = Defs.radioButtonNo;
        public string mortgageClub { get; set; } = "Mortgage Club";
        public string lenderAllowSomeoneToHelpMortgage { get; set; } = Defs.radioButtonNo;
    }
}

