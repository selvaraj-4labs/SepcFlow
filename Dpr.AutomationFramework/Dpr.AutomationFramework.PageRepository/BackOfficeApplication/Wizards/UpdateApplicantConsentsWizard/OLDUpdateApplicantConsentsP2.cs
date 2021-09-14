using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.UpdateApplicantConsentsWizard
{
    public class UpdateApplicantConsentsP22 : BOWizardBasePage
    {
        public UpdateApplicantConsentsP22()
        {
            pageLoadedElement = addConsentBtn;
            correspondingDataClass = new UpdateApplicantConsentsP2Data2().GetType();
            textName = "Update Applicant Consents Page 2";
        }

        #region Consent 


        public Element consentTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown"), "/ComboBox"));
            


        public Element consentProvidedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "updateConsentProvidedRadiobutton"), "/Group/RadioButton[@Name =\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorName, "updateConsentProvidedRadiobutton"), "/Group/RadioButton[@Name =\"No\"]"))
            );


        public Element consentProvidedByLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown"), "/ComboBox"
            ));


        public Element updateConstentNotesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentNotes"), "/Edit"
            ));


       


        #endregion


        //#region Consent [AllowDirectMailSolicitation]


        //public Element directMailConsentTypeLookup => new Element(FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Direct Mail")
        //        .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown")
        //        .Add(Defs.boLocatorName, "Allow Direct Mail Solicitation")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element directMailConsentProvidedRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "DirectMail"),    "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"Yes\"]"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "DirectMail"),    "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"No\"]"))
        //    );


        //public Element directMailConsentProvidedBy => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown")
        //    ));


        //public Element directMailUpdateConstentNotes => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentNotes")
        //    ));


        //public Element directMailConsentSourceBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentSource")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element directMailConstentCreateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element directMailConsentUpdateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element directMailDeleteChbox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "DirectMail")
        //    .Add(Defs.boLocatorAutomationId, "chkDelete"), "/CheckBox"))
        //    .SetCompletePageFlag(false);

        //#endregion


        //#region Consent [AllowSMSSolicitation]


        //public Element smsConsentTypeLookup => new Element(FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "SMS")
        //        .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown")
        //        .Add(Defs.boLocatorName, "Allow SMS Solicitation")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element smsConsentProvidedRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "SMS"), "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"Yes\"]"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "SMS"), "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"No\"]"))
        //    );


        //public Element smsConsentProvidedBy => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown")
        //    ));


        //public Element smsUpdateConstentNotes => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentNotes")
        //    ));


        //public Element smsConsentSourceBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentSource")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element smsConstentCreateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element smsConsentUpdateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element smsDeleteChbox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "SMS")
        //    .Add(Defs.boLocatorAutomationId, "chkDelete"), "/CheckBox"))
        //    .SetCompletePageFlag(false);


        //#endregion


        //#region Consent [AllowEmailSolicitation]


        //public Element emailConsentTypeLookup => new Element(FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Email")
        //        .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown")
        //        .Add(Defs.boLocatorName, "Allow Email Solicitation")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element emailConsentProvidedRbtn => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Email"), "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"Yes\"]"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Email"), "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //                                                    "/Group/RadioButton[@Name =\"No\"]"))
        //    );


        //public Element emailConsentProvidedBy => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown")
        //    ));


        //public Element emailUpdateConstentNotes => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentNotes")
        //    ));


        //public Element emailConsentSourceBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentSource")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element emailConstentCreateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element emailConsentUpdateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate")
        //    ))
        //    .SetCompletePageFlag(false);


        //public Element emailDeleteChbox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Email")
        //    .Add(Defs.boLocatorAutomationId, "chkDelete"), "/CheckBox"))
        //    .SetCompletePageFlag(false);


        //#endregion


        #region Add / Remove Consent Buttons


        public Element addConsentBtn => new Element(FindElement("butAdd",attributeType: Defs.boLocatorAutomationId))
                .SetIsButtonFlag(true)
                .SetCompletePageFlag(false);


        public Element removeConsentBtn => new Element(FindElement("butRemove", attributeType: Defs.boLocatorAutomationId))
                .SetIsButtonFlag(true)
                .SetCompletePageFlag(false);


        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);


        #endregion


    }

    public class UpdateApplicantConsentsP2Data2 : PageData
    {


        #region Consent
        public string consentTypeLookup { get; set; } = null;

        public string consentProvided { get; set; } = Defs.radioButtonYes;

        public string updateConstentNotes { get; set; } = null;

        public string consentProvidedBy { get; set; } = "Premium Bank";


        #endregion


        //#region Consent [AllowDirectMailSolicitation]


        //public string directMailConsentProvided { get; set; } = null;


        //public string directMailConsentProvidedBy { get; set; } = "Premium Bank";


        //#endregion


        //#region Consent [AllowSMSSolicitation]


        //public string smsConsentProvided { get; set; } = Defs.radioButtonYes;


        //public string smsConsentProvidedBy { get; set; } = "Premium Bank";


        //#endregion


        //#region Consent [AllowEmailSolicitation]


        //public string emailConsentProvided { get; set; } = Defs.radioButtonYes;


        //public string emailConsentProvidedBy { get; set; } = "Premium Bank";


        //#endregion


    }
}
