using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.ResumeCustomerStatus
{
    public class ResumeCustomerStatusP1 : AppBasePage
    {
        public ResumeCustomerStatusP1()
        {
            pageLoadedElement = proofOfPendingJudgementRequiredYesChbox;
            correspondingDataClass = new ResumeCustomerStatusP1Data().GetType();
            textName = "Resume Customer Status Page 1";
        }
        #region 'Proof of Pending Judgement' Section
        public Element proofOfPendingJudgementRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element proofOfPendingJudgementSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[0]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Income Expenditure' Section
        public Element incomeExpenditureRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element incomeExpenditureSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[1]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region '2 months bank statemenets' Section
        public Element twoMonthBankStatementsRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element twoMonthBankStatementsSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[2]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Death Certificate' Section
        public Element deathCertificateRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element deathCertificateRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element deathCertificateCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element deathCertificateCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element deathCertificateCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element deathCertificateSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element deathCertificateSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element deathCertificateSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[3]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'ADHOC' Section
        public Element adhocRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element adhocRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element adhocCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element adhocCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element adhocCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element adhocSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element adhocSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element adhocSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[4]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Letter of Authority from DMC' Section
        public Element letterOfAuthorityRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element letterOfAuthorityRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element letterOfAuthorityCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element letterOfAuthorityCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element letterOfAuthorityCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element letterOfAuthoritySatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element letterOfAuthoritySatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element letterOfAuthoritySatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[5]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Internal Investigation' Section
        public Element internalInvestigationRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element internalInvestigationRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element internalInvestigationCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element internalInvestigationCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element internalInvestigationCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element internalInvestigationSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element internalInvestigationSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element internalInvestigationSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[6]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Notice of Imprisonment' Section
        public Element noticeOfImprisonmentRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element noticeOfImprisonmentSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[7]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Notice of JSA' Section
        public Element noticeofJsaRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element noticeofJsaRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element noticeofJsaCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element noticeofJsaCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element noticeofJsaCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element noticeofJsaSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element noticeofJsaSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element noticeofJsaSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[8]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Repayment Request' Section
        public Element repaymentRequestRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element repaymentRequestRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element repaymentRequestCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element repaymentRequestCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element repaymentRequestCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element repaymentRequestSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element repaymentRequestSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element repaymentRequestSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[9]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Copy of P45' Section
        public Element copyOfP45RequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element copyOfP45RequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element copyOfP45CompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element copyOfP45CompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element copyOfP45CompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element copyOfP45SatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element copyOfP45SatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element copyOfP45SatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[10]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Letter of Termination/Redundancy' Section
        public Element letterofTerminationRedundancyRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancyRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancyCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancyCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancyCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancySatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancySatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element letterofTerminationRedundancySatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[11]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Bankruptcy Order' Section
        public Element bankruptcyOrderRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element bankruptcyOrderSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[12]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Court Order' Section
        public Element courtOrderRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element courtOrderRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element courtOrderCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element courtOrderCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element courtOrderCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element courtOrderSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element courtOrderSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element courtOrderSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[13]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Appointment Documentation' Section
        public Element appointmentDocumentationRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element appointmentDocumentationSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[14]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Hospital Letter' Section
        public Element hospitalLetterRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element hospitalLetterRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element hospitalLetterCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element hospitalLetterCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element hospitalLetterCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element hospitalLetterSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element hospitalLetterSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element hospitalLetterSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[15]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Doctor Certificate' Section
        public Element doctorCertificateRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element doctorCertificateRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element doctorCertificateCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element doctorCertificateCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element doctorCertificateCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element doctorCertificateSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element doctorCertificateSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element doctorCertificateSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[16]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'New address received?' Seciton
        public Element newAddressReceivedRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element newAddressReceivedSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[17]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Proof of residency provided?' Section
        public Element proofOfResidencyProvidedRequiredYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element proofOfResidencyProvidedSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[18]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion

        #region 'Security checks completed?' Section
        public Element securityChecksCompletedRequiredYesChbox => new Element(FindElement(new LocatorList()
    .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
    .Add("chkRequiredYes", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedRequiredNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkRequiredNo", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedCompletedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkCompletedYes", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedCompletedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNo", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedCompletedNAChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkCompletedNA", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedSatisfiedYesChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryYes", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedSatisfiedNoChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryNo", Defs.boLocatorAutomationId)));
        public Element securityChecksCompletedSatisfiedUKChbox => new Element(FindElement(new LocatorList()
            .Add("GenericChecklistControlLine[19]", Defs.boLocatorAutomationId)
            .Add("chkSatisfactoryUnk", Defs.boLocatorAutomationId)));
        #endregion
        public Element remarksBox => new Element(FindElement("txtRemarks", Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ResumeCustomerStatusP1Data : PageData
    {
        public string proofOfPendingJudgementCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string proofOfPendingJudgementSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string incomeExpenditureCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string incomeExpenditureSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string twoMonthBankStatementsCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string twoMonthBankStatementsSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string deathCertificateCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string deathCertificateSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string adhocCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string adhocSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string letterOfAuthorityCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string letterOfAuthoritySatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string internalInvestigationCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string internalInvestigationSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string noticeOfImprisonmentCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string noticeOfImprisonmentSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string noticeofJsaCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string noticeofJsaSatisfiedYesChbox { get; set; } = Defs.checkBoxSelected;
        public string repaymentRequestCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string repaymentRequestSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string copyOfP45CompletedYes { get; set; } = Defs.checkBoxSelected;
        public string copyOfP45SatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string letterofTerminationRedundancyCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string letterofTerminationRedundancySatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string bankruptcyOrderCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string bankruptcyOrderSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string courtOrderCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string courtOrderSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string appointmentDocumentationCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string appointmentDocumentationSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string hospitalLetterCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string hospitalLetterSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string doctorCertificateCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string doctorCertificateSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string newAddressReceivedCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string newAddressReceivedSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string proofOfResidencyProvidedCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string proofOfResidencyProvidedSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string securityChecksCompletedCompletedYes { get; set; } = Defs.checkBoxSelected;
        public string securityChecksCompletedSatisfiedYes { get; set; } = Defs.checkBoxSelected;
        public string remarks { get; set; } = "TestRemarks";
    }
}
