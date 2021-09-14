using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class Applicant1PrimaryEmploymentPageSelfEmployed : WebBasePage
    {
        public Applicant1PrimaryEmploymentPageSelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new Applicant1PrimaryEmploymentPageSelfEmployedData().GetType();
            textName = "Applicant 1 Primary Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("Applicant1EmploymentInitialisationPage", "employmentStatus", "Self Employed"))));
        }

        #region 'Self-employed details' Section
        public Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_0", tag:"input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_1", tag: "input")));

        public Element ownershipType => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_CompanyType", tag: "select"));
        public Element dateCommencedTrading => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_DateCommencedTrading", "!CustVal", tag: "input"));
        public Element percentageOfBusinessOwned => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_PercentageOFBusinessOwned", tag: "input"),
            new ConditionList()
            .Add(new Condition(className, "ownershipType", "Limited Company")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "ownershipType", "Sole Trader")));
        public Element noOfPartners => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_NumberOfPartners", tag: "input"),
            new ConditionList()
            .Add(new Condition(className, "ownershipType", "Partnership")))
            .AddNewConditionList(new ConditionList()
            .Add(new Condition(className, "ownershipType", "Limited Liability Partnership")));
        public Element incomeDerivedFromBTL => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("ctl00_rdbIsIncomeFromBTL_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("ctl00_rdbIsIncomeFromBTL_1", tag: "input")));
        public Element occupation => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_Occupation", tag: "input"));
        #endregion

        #region 'Self employed income' Section

        #region 'Year 1' Subsection
        public Element yearOneEarnings => new Element(FindElement("ctl00_SelfEmployedYear1BasicIncomeAmount", tag: "input"));
        // Commented out 23062020, gone back to basic self employed income section.
        //public Element yearOneDividends => new Element(FindElement("ctl00_SelfEmployedYear1DividendsDistributionAmount", tag: "input"));
        //public Element yearOneRetainedEarnings => new Element(FindElement("ctl00_SelfEmployedYear1RetainedEarningsAmount", tag: "input"));
        public Element yearOneEnding => new Element(FindElement("ctl00_SelfEmployedYear1YearEnding", tag: "input"));
        #endregion

        #region 'Year 2' Subsection
        public Element yearTwoEarnings => new Element(FindElement("ctl00_SelfEmployedYear2BasicIncomeAmount", tag: "input"));
        // Commented out 23062020, gone back to basic self employed income section.
        //public Element yearTwoDividends => new Element(FindElement("ctl00_SelfEmployedYear2DividendsDistributionAmount", tag: "input"));
        //public Element yearTwoRetainedEarnings => new Element(FindElement("SelfEmployedYear2RetainedEarningsAmount", tag: "input"));
        public Element yearTwoEnding => new Element(FindElement("ctl00_SelfEmployedYear2YearEnding", tag: "input"));
        #endregion

        #region 'Year 3' Subsection
        public Element yearThreeEarnings => new Element(FindElement("ctl00_SelfEmployedYear3BasicIncomeAmount", tag: "input"));
        // Commented out 23062020, gone back to basic self employed income section.
        //public Element yearThreeDividends => new Element(FindElement("ctl00_SelfEmployedYear3DividendsDistributionAmount", tag: "input"));
        //public Element yearThreeRetainedEarnings => new Element(FindElement("ctl00_SelfEmployedYear3RetainedEarningsAmount", tag: "input"));
        public Element yearThreeEnding => new Element(FindElement("ctl00_SelfEmployedYear3YearEnding", tag: "input"));
        #endregion

        #endregion

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class Applicant1PrimaryEmploymentPageSelfEmployedData : PageData
    {
        public string fullTime { get; set; } = Defs.radioButtonYes;
        public string ownershipType { get; set; } = "Limited Company";
        public string dateCommencedTrading { get; set; } = "01/2010";

        public string percentageOfBusinessOwned { get; set; } = "100";
        public string noOfPartners { get; set; } = "3";

        public string incomeDerivedFromBTL { get; set; } = Defs.radioButtonNo;
        public string occupation { get; set; } = "TestOccupation";

        #region 'Self employed income' Section

        #region 'Year 1' Subsection
        public string yearOneEarnings { get; set; } = "65000";
        //public string yearOneDividends { get; set; } = "0";
        //public string yearOneRetainedEarnings { get; set; } = "0";
        public string yearOneEnding { get; set; } = "01/2012";
        #endregion

        #region 'Year 2' Subsection
        public string yearTwoEarnings { get; set; } = "75000";
        //public string yearTwoDividends { get; set; } = "0";
        //public string yearTwoRetainedEarnings { get; set; } = "0";
        public string yearTwoEnding { get; set; } = "01/2013";
        #endregion

        #region 'Year 3' Subsection
        public string yearThreeEarnings { get; set; } = "85000";
        //public string yearThreeDividends { get; set; } = "0";
        //public string yearThreeRetainedEarnings { get; set; } = "0";
        public string yearThreeEnding { get; set; } = "01/2014";
        #endregion

        #endregion

    }
}
