using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus
{
    public class SetConfirmCustomerStatusP2 : AppBasePage
    {
        public SetConfirmCustomerStatusP2()
        {
            pageLoadedElement = proofOfPendingJudgementRequiredRbtn;
            correspondingDataClass = new SetConfirmCustomerStatusP2Data().GetType();
            textName = "Set / Confirm Customer Status Page 2";
        }


        #region Click scroll bar

        public Element scrollDown1 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown2 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown3 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown4 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown5 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown6 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown7 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown8 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);

        public Element scrollDown9 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown10 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown11 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown12 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown13 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown14 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown15 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown16 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown17 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown18 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);

        public Element scrollDown19 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown20 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown21 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown22 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown23 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown24 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown25 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown26 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown27 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown28 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);

        public Element scrollDown29 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);
        public Element scrollDown30 => new Element(By.Id("DownButton")).SetIsButtonFlag(true);

        #endregion

        #region 'Proof of Pending Judgement' Section
        public Element proofOfPendingJudgementRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element proofOfPendingJudgementCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element proofOfPendingJudgementSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][1]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Income Expenditure' Section
        public Element incomeExpenditureRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element incomeExpenditureCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element incomeExpenditureSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][2]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region '2 months bank statemenets' Section
        public Element twoMonthBankStatementsRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element twoMonthBankStatementsCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element twoMonthBankStatementsSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][3]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Death Certificate' Section
        public Element deathCertificateRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element deathCertificateCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element deathCertificateSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][4]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'ADHOC' Section
        public Element adhocRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element adhocCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element adhocSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][5]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Letter of Authority from DMC' Section
        public Element letterOfAuthorityRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element letterOfAuthorityCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element letterOfAuthoritySatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][6]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Internal Investigation' Section
        public Element internalInvestigationRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element internalInvestigationCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element internalInvestigationSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][7]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Notice of Imprisonment' Section
        public Element noticeOfImprisonmentRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element noticeOfImprisonmentCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element noticeOfImprisonmentSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][8]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Notice of JSA' Section
        public Element noticeOfJsaRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element noticeOfJsaCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element noticeOfJsaSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][9]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Repayment Request' Section
        public Element repaymentRequestRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element repaymentRequestCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element repaymentRequestSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][10]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion




        #region 'Copy of P45' Section
        public Element copyOfP45RequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element copyOfP45CompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkRequiredYes\"]")));
        public Element copyOfP45SatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][11]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Letter of Termination / Redundancy' Section
        public Element letterofTerminationRedundancyRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element letterofTerminationRedundancyCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element letterofTerminationRedundancySatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][12]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Bankruptcy Order' Section
        public Element bankruptcyOrderRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element bankruptcyOrderCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element bankruptcyOrderSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][13]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Court Order' Section
        public Element courtOrderRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element courtOrderCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element courtOrderSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][14]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Appointment Documentation' Section
        public Element appointmentDocumentationRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element appointmentDocumentationCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element appointmentDocumentationSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][15]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Hospital Letter' Section
        public Element hospitalLetterRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element hospitalLetterCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element hospitalLetterSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][16]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Doctor Certificate' Section
        public Element doctorCertificateRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element doctorCertificateCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element doctorCertificateSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][17]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'New address received?' Seciton
        public Element newAddressReceivedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element newAddressReceivedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element newAddressReceivedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][18]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Proof of residency provided?' Section
        public Element proofOfResidencyProvidedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element proofOfResidencyProvidedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element proofOfResidencyProvidedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][19]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        #region 'Security checks completed?' Section
        public Element securityChecksCompletedRequiredRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkRequiredYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkRequiredNo\"]")));
        public Element securityChecksCompletedCompletedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkCompletedYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkCompletedNo\"]"))
            .AddRadioButtonElement("NA", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkCompletedNA\"]")));
        public Element securityChecksCompletedSatisfiedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkSatisfactoryYes\"]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkSatisfactoryNo\"]"))
            .AddRadioButtonElement("UK", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "=pnlCheckListItems"), "/Pane[@AutomationId=\"GenericChecklistControlLine\"][20]/CheckBox[@AutomationId=\"chkSatisfactoryUnk\"]")));
        #endregion

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class SetConfirmCustomerStatusP2Data : PageData
    {
        #region 'Proof of Pending Judgement' Section
        public string proofOfPendingJudgementRequired { get; set; } = "No";
        public string proofOfPendingJudgementCompleted { get; set; } = null;
        public string proofOfPendingJudgementSatisfied { get; set; } = null;
        #endregion

        #region 'Income Expenditure' Section
        public string incomeExpenditureRequired { get; set; } = "No";
        public string incomeExpenditureCompleted { get; set; } = null;
        public string incomeExpenditureSatisfied { get; set; } = null;
        #endregion



        #region 'Two Months Bank Statements' Section
        public string twoMonthBankStatementsRequired { get; set; } = "No";
        public string twoMonthBankStatementsCompleted { get; set; } = null;
        public string twoMonthBankStatementsSatisfied { get; set; } = null;
        #endregion

        #region 'Death Certificate Required' Section
        public string deathCertificateRequired { get; set; } = "No";
        public string deathCertificateCompleted { get; set; } = null;
        public string deathCertificateSatisfied { get; set; } = null;
        #endregion

        #region 'ADHOC' Section
        public string adhocRequired { get; set; } = "No";
        public string adhocCompleted { get; set; } = null;
        public string adhocSatisfied { get; set; } = null;
        #endregion

        #region 'Letter of Authority from DMC' Section
        public string letterOfAuthorityRequired { get; set; } = "No";
        public string letterOfAuthorityCompleted { get; set; } = null;
        public string letterOfAuthoritySatisfied { get; set; } = null;
        #endregion

        #region 'Internal Investigation' Section
        public string internalInvestigationRequired { get; set; } = "No";
        public string internalInvestigationCompleted { get; set; } = null;
        public string internalInvestigationSatisfied { get; set; } = null;
        #endregion

        #region 'Notice of Imprisonment' Section
        public string noticeOfImprisonmentRequired { get; set; } = "No";
        public string noticeOfImprisonmentCompleted { get; set; } = null;
        public string noticeOfImprisonmentSatisfied { get; set; } = null;
        #endregion

        #region 'Notice of JSA' Section
        public string noticeOfJsaRequired { get; set; } = "No";
        public string noticeOfJsaCompleted { get; set; } = null;
        public string noticeOfJsaSatisfied { get; set; } = null;
        #endregion

        #region 'Repayment Request' Section
        public string repaymentRequestRequired { get; set; } = "No";
        public string repaymentRequestCompleted { get; set; } = null;
        public string repaymentRequestSatisfied { get; set; } = null;
        #endregion

        #region 'Copy of P45' Section
        public string copyOfP45Required { get; set; } = "No";
        public string copyOfP45Completed { get; set; } = null;
        public string copyOfP45Satisfied { get; set; } = null;
        #endregion

        #region 'Letter of Termination / Redundancy' Section
        public string letterofTerminationRedundancyRequired { get; set; } = "No";
        public string letterofTerminationRedundancyCompleted { get; set; } = null;
        public string letterofTerminationRedundancySatisfied { get; set; } = null;
        #endregion

        #region 'Bankruptcy Order' Section
        public string bankruptcyOrderRequired { get; set; } = "No";
        public string bankruptcyOrderCompleted { get; set; } = null;
        public string bankruptcyOrderSatisfied { get; set; } = null;
        #endregion

        #region 'Court Order' Section
        public string courtOrderRequired { get; set; } = "No";
        public string courtOrderCompleted { get; set; } = null;
        public string courtOrderSatisfied { get; set; } = null;
        #endregion

        #region 'Appointment Documentation' Section
        public string appointmentDocumentationRequired { get; set; } = "No";
        public string appointmentDocumentationCompleted { get; set; } = null;
        public string appointmentDocumentationSatisfied { get; set; } = null;
        #endregion

        #region 'Hospital Letter' Section
        public string hospitalLetterRequired { get; set; } = "No";
        public string hospitalLetterCompleted { get; set; } = null;
        public string hospitalLetterSatisfied { get; set; } = null;
        #endregion

        #region 'Doctor Certificate' Section
        public string doctorCertificateRequired { get; set; } = "No";
        public string doctorCertificateCompleted { get; set; } = null;
        public string doctorCertificateSatisfied { get; set; } = null;
        #endregion

        #region 'New address received?' Seciton
        public string newAddressReceivedRequired { get; set; } = "No";
        public string newAddressReceivedCompleted { get; set; } = null;
        public string newAddressReceivedSatisfied { get; set; } = null;
        #endregion

        #region 'Proof of residency provided?' Section
        public string proofOfResidencyProvidedRequired { get; set; } = "No";
        public string proofOfResidencyProvidedCompleted { get; set; } = null;
        public string proofOfResidencyProvidedSatisfied { get; set; } = null;
        #endregion

        #region 'Security checks completed?' Section
        public string securityChecksCompletedRequired { get; set; } = "No";
        public string securityChecksCompletedCompleted { get; set; } = null;
        public string securityChecksCompletedSatisfied { get; set; } = null;
        #endregion

        public string remarks { get; set; } = "TestRemarks";
    }
}
