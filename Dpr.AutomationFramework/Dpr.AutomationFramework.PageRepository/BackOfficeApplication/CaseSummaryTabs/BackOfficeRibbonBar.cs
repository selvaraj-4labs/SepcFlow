using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.CaseSummaryTabs
{
    public class BackOfficeRibbonBar : AppBasePage
    {
        public BackOfficeRibbonBar()
        {
            pageLoadedElement = savingsTabBtn;
            correspondingDataClass = new BackOfficeRibbonBarData().GetType();
            textName = "Back Office Ribbon Selection Bar";
        }

        // Update these once a Savings case has gone through on the tevtestapp01 portal.
        #region Old Savings BO tabs
        public Element caseStatusLbl => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=lblHeaderStatusValue")))
            .SetCompletePageFlag(false);

        public Element savingsTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Savings")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element individualsTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Individuals")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element incomeTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Income")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element productTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Product")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element decisionTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Decision")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element checklistTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Checklist")))
            .SetCompletePageFlag(false);

        public Element diaryTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Diary")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element notesTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Notes")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element documentsTabBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Documents")))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);

        public Element wizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "Wizard"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);
        #endregion

        #region Combined Solution Tab List

        public Element summaryTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Summary")));

        public Element firstChargeTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailsPage")
            .Add(Defs.boLocatorName, "First Charge")));

        // Individuals tab in old section, bring down.

        public Element securitiesTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Securities")));

        public Element loanTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Loan")));

        public Element factFindTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Fact Find")));

        public Element incomeTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Income")));

        public Element commitmentsTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Commitments")));

        public Element adverseTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Adverse")));

        public Element insuranceTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Insurance")));

        // Decisions tab in old section, bring down.

        public Element feesTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Fees")));

        // Products tab in old section, bring down.

        // Checklists tab in old section, bring down.

        // Diary tab in old section, bring down.

        // Documents tab in old section. bring down.

        public Element completionsTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "caseDetailTabs")
            .Add(Defs.boLocatorName, "Completions")));
        #endregion

        // Update these once a Savings case has gone through on the tevtestapp01 portal.
        #region Wizards in wizard list OLD

        public Element amendapplicantswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Applicants Details"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);







        public Element updateapplicantconsentswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Update Application Consents"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);





        public Element amendnominatedaccountdetailswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Nominated Account Deails"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        #endregion

        #region Combined Solution Wizard List

        public Element rulesoverridewizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Rules Override"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendapplicantdetailswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Applicants Details"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendexpenditurewizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Expenditure"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendotherpartieswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Other Parties"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendloandetailswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Loan Details"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element incomeverificationwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Income Verification"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element instructvaluationwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Instruct Valuation"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element valuationreceiptwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Valuation Receipt"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element setamendretentionamountwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Set/Amend Retention Amount"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element declinecancelapplicationwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Decline/Cancel Application"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendcommitmentswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Commitments"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendapplicantexpenditurewizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Applicant Expenditure"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendaccountsettingswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Account Settings"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendsecuritywizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Security"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element issueofferwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Issue Offer"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amenddirectdebitdetailswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Direct Debit Details"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element updateapplicationconsentswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Update Application Consents"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendthirdpartywizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Third Party"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendsolicitordetailswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Solicitors Details"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendoccupantswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Occuupants"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element extendofferwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Extend Offer"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element processcotwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Process COT"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element completecasewizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Complete Case"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element delaycompletionwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Delay Completion"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element decisionintegritywizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Decision Integrity"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element runbusinessruleswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Run Business Rules"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element overridebureauwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Override Bureau"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element amendreadonlycaseaccesswizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Amend Read-Only Case Access"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element anonymiseapplicantwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Anonymise Applicant"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);

        public Element generatedataoutputdocumentwizard => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Generate Data Output Document"), tag: "MenuItem"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);
        #endregion

        public Element closeTab => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=TabCloseButton"), tag: "Button"))
            .SetCompletePageFlag(false)
            .SetIsButtonFlag(true);


    }

    public class BackOfficeRibbonBarData : PageData
    {
    }
}
