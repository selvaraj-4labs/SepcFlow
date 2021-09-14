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
    class ApplicantLoanTypePagePBR : WebBasePage
    {
        public ApplicantLoanTypePagePBR()
        {
            pageLoadedElement = applicantTypeLookup;
            correspondingDataClass = new ApplicantLoanTypeDataPBR().GetType();

        }

        #region Applicant Type section locators

        public Element applicantTypeLookup => new Element(FindElement("ddlApplicantType"));
        public Element loanTypeLookup => new Element(FindElement("txtLoanType"));

        public Element highNetWorthCustomersRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HighNetWorth", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HighNetWorth", "rbl_1")));


        public Element professionalCustomersRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("MortgageProfessional", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("MortgageProfessional", "rbl_1")));

        public Element howWasSaleMadeLookup => new Element(FindElement("ddlModeofSale", "Details"));



        #endregion

        #region Application Suitability section locators

        public Element clientMeetResiLendingCriteriaRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoLendingCriteria", "rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoLendingCriteria", "rbl_1")));
        //.SetValidationCompletePageResetRequired(true);

        //public Element propertyMeetResiSecurityCriteriaRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement("rdoPropertyCriteria", "rbl_0"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement("rdoPropertyCriteria", "rbl_1")))
        //    .SetValidationCompletePageResetRequired(true);

        #endregion


        //Element to look for to verify screen has loaded

        public Element nextBtn => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true);
        //.SetIsPageContinueButtonFlag(true);

    }



    public class ApplicantLoanTypeDataPBR : PageData
    {
        public string applicantType { get; set; } = "Individual";
        public string loanType { get; set; } = "Residential";

        public string highNetWorthCustomers { get; set; } = Defs.radioButtonNo;
        public string professionalCustomers { get; set; } = Defs.radioButtonNo;

        public string howWasSaleMade { get; set; } = "Face-to-Face";
        public string clientMeetResiLendingCriteria { get; set; } = Defs.radioButtonYes;
        //public string propertyMeetResiSecurityCriteria { get; set; } = Defs.radioButtonYes;




        /*public ApplicantLoanTypeData()
        {
            
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                objectProps.Add(prop.Name,prop.GetValue(this).ToString());
            }
        }*/

    }
}

/*
data.getFor<ApplicantLoanTypeData>(this.class).applicantTypeLookup

data.getFor(LoginDetailsPage).password
.*/

    

