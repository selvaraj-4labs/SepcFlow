using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.UpdateApplicantConsentsWizard
{
    public class UpdateApplicantConsentsP2 : BOWizardBasePage
    {
        public UpdateApplicantConsentsP2()
        {
            pageLoadedElement = addConsentBtn;
            correspondingDataClass = new UpdateApplicantConsentsP2Data().GetType();
            textName = "Update Applicant Consents Page 2";
        }

        #region Consent [AllowPhoneSolicitation] Section
        //public Element phoneConsentType => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown")
        //    .Add(Defs.boLocatorName, "Allow Phone Solicitation")))
        //    .SetCompletePageFlag(false);

        //public Element phoneConsentProvided => new Element(new RadioButton()
        //    .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Phone"),
        //        "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //        "/Group/RadioButton[@Name =\"Yes\"]"))
        //    .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
        //        .Add(Defs.boLocatorName, "Phone"),
        //        "/List[@Name=\"Yes\"][@AutomationId=\"updateConsentProvidedRadiobutton\"]" +
        //        "/Group/RadioButton[@Name =\"No\"]")));

        //public Element phoneConsentProvidedByLookup => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown")));

        //public Element phoneUpdateConstentNotesBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentNotes")));

        //public Element phoneConsentSourceBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentSource")))
        //    .SetCompletePageFlag(false);

        //public Element phoneConstentCreateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate")))
        //    .SetCompletePageFlag(false);

        //public Element phoneConsentUpdateDateBox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate")))
        //    .SetCompletePageFlag(false);

        //public Element phoneDeleteChbox => new Element(FindElement(new LocatorList()
        //    .Add(Defs.boLocatorName, "Phone")
        //    .Add(Defs.boLocatorAutomationId, "chkDelete"), 
        //    "/CheckBox"))
        //    .SetCompletePageFlag(false);

        public Element phoneConsentType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown"),
            "/Edit"))
            .SetCompletePageFlag(false);

        public Element phoneConsentProvided => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "/RadioButon[@Name=\"No\"][1]")));

        public Element phoneConsentProvidedBy => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown"),
            "[1]/Edit"));

        public Element phoneNotesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentNotes"),
            "[1]/Edit"));

        public Element phoneConsentSource => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentSource"),
            "[1]/Edit"))
            .SetCompletePageFlag(false);

        public Element phoneConsentCreateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate"),
            "[1]/Edit"))
            .SetCompletePageFlag(false);

        public Element phoneConsentUpdateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate"),
            "[1]/Edit"))
            .SetCompletePageFlag(false);

        public Element phoneDelete => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkDelete"),
            "[1]"))
            .SetCompletePageFlag(false);
        #endregion


        #region Consent [AllowDirectMailSolicitation] Section
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
        public Element directMailConsentType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown"),
            "[2]/Edit"))
            .SetCompletePageFlag(false);

        public Element directMailConsentProvided => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[2]/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[2]/RadioButon[@Name=\"No\"]")));

        public Element directMailConsentProvidedBy => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown"),
            "[2]/Edit"));

        public Element directMailNotesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentNotes"),
            "[2]/Edit"));

        public Element directMailConsentSource => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentSource"),
            "[2]/Edit"))
            .SetCompletePageFlag(false);

        public Element directMailConsentCreateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate"),
            "[2]/Edit"))
            .SetCompletePageFlag(false);

        public Element directMailConsentUpdateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate"),
            "[2]/Edit"))
            .SetCompletePageFlag(false);

        public Element directMailDelete => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkDelete"),
            "[2]"))
            .SetCompletePageFlag(false);
        #endregion


        #region Consent [AllowSMSSolicitation] Section


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
        public Element smsConsentType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown"),
            "[3]/Edit"))
            .SetCompletePageFlag(false);

        public Element smsConsentProvided => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[3]/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[3]/RadioButon[@Name=\"No\"]")));

        public Element smsConsentProvidedBy => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown"),
            "[3]/Edit"));

        public Element smsNotesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentNotes"),
            "[3]/Edit"));

        public Element smsConsentSource => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentSource"),
            "[3]/Edit"))
            .SetCompletePageFlag(false);

        public Element smsConsentCreateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate"),
            "[3]/Edit"))
            .SetCompletePageFlag(false);

        public Element smsConsentUpdateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate"),
            "[3]/Edit"))
            .SetCompletePageFlag(false);

        public Element smsDelete => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkDelete"),
            "[3]"))
            .SetCompletePageFlag(false);

        #endregion


        #region Consent [AllowEmailSolicitation] Section
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
        public Element emailConsentType => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentTypeDropdown"),
            "[4]/Edit"))
            .SetCompletePageFlag(false);

        public Element emailConsentProvided => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[4]/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "updateConsentProvidedRadiobutton"),
                "[4]/RadioButon[@Name=\"No\"]")));

        public Element emailConsentProvidedBy => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentProvidedByDropdown"),
            "[4]/Edit"));

        public Element emailNotesBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentNotes"),
            "[4]/Edit"));

        public Element emailConsentSource => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentSource"),
            "[4]/Edit"))
            .SetCompletePageFlag(false);

        public Element emailConsentCreateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentCreateDate"),
            "[4]/Edit"))
            .SetCompletePageFlag(false);

        public Element emailConsentUpdateDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "updateConsentUpdateDate"),
            "[4]/Edit"))
            .SetCompletePageFlag(false);

        public Element emailDelete => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkDelete"),
            "[4]"))
            .SetCompletePageFlag(false);

        #endregion


        #region Add / Remove Consent Buttons Section


        public Element addConsentBtn => new Element(FindElement("butAdd", attributeType: Defs.boLocatorAutomationId))
                .SetIsButtonFlag(true)
                .SetCompletePageFlag(false);


        public Element removeConsentBtn => new Element(FindElement("butRemove", attributeType: Defs.boLocatorAutomationId))
                .SetIsButtonFlag(true)
                .SetCompletePageFlag(false);


        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);


        #endregion


    }

    public class UpdateApplicantConsentsP2Data : PageData
    {


        #region Consent [AllowPhoneSolicitation] Data Section
        public string phoneConsentProvided { get; set; } = null;
        public string phoneConsentProvidedBy { get; set; } = null;
        public string phoneNotesBox { get; set; } = "Automation";
        #endregion


        #region Consent [AllowDirectMailSolicitation] Data Section
        public string directMailConsentProvided { get; set; } = null;
        public string directMailConsentProvidedBy { get; set; } = null;
        #endregion


        #region Consent [AllowSMSSolicitation] Data Section
        public string smsConsentProvided { get; set; } =  null;
        public string smsConsentProvidedBy { get; set; } = null;
        #endregion


        #region Consent [AllowEmailSolicitation] Data Section
        public string emailConsentProvided { get; set; } = null;
        public string emailConsentProvidedBy { get; set; } = null;
        #endregion
    }
}
