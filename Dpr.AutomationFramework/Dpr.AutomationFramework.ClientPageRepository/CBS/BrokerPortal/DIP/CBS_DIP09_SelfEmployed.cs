using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_SelfEmployed : WebBasePage
    {
        public CBS_DIP09_SelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_SelfEmployedData().GetType();
            textName = "CBS Applicant 1 Primary Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP08", "employmentStatus", "Self Employed"))));
        }

        #region 'Self-employed details' Section
        public Element fullTime => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("EmplymentStatus_0", tag: "input"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("EmplymentStatus_1", tag: "input")));

        public Element ownershipType => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_CompanyType", tag: "select"));
        public Element dateCommencedTrading => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_DateCommencedTrading", "!CustVal", tag: "input"));
        public Element percentageOfBusinessOwned => new Element(FindElement("ctl00_pnlApplicantPanel_ctl00_PercentageOFBusinessOwned", tag: "input"),
            new ConditionList()
            .Add(new Condition(className, "ownershipType", "Limited Company")));
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
        public Element yearOneDividends => new Element(FindElement("ctl00_SelfEmployedYear1DividendsDistributionAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearOneDrawings => new Element(FindElement("ctl00_SelfEmployedYear1DirectorLoansAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearOneRetainedEarnings => new Element(FindElement("ctl00_SelfEmployedYear1RetainedEarningsAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearOneEnding => new Element(FindElement("ctl00_SelfEmployedYear1YearEnding", tag: "input"));
        #endregion

        #region 'Year 2' Subsection
        public Element yearTwoEarnings => new Element(FindElement("ctl00_SelfEmployedYear2BasicIncomeAmount", tag: "input"));
        public Element yearTwoDividends => new Element(FindElement("ctl00_SelfEmployedYear2DividendsDistributionAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearTwoDrawings => new Element(FindElement("ctl00_SelfEmployedYear2DirectorLoansAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearTwoRetainedEarnings => new Element(FindElement("ctl00_SelfEmployedYear2RetainedEarningsAmount", tag: "input"),
            new ConditionList()
                .Add(new Condition(className, "ownershipType", "Sole Trader", Defs.conditionTypeNotEqual)));
        public Element yearTwoEnding => new Element(FindElement("ctl00_SelfEmployedYear2YearEnding", tag: "input"));
        #endregion

        #endregion

        public Element next => new Element(FindElement("Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);
    }

    public class CBS_DIP09_SelfEmployedData : PageData
    {
        #region 'Self-employed details' Data Section
        public string fullTime { get; set; } = Defs.radioButtonYes;
        public string ownershipType { get; set; } = "Limited Company";
        public string dateCommencedTrading { get; set; } = "01/2010";

        public string percentageOfBusinessOwned { get; set; } = "100";
        public string noOfPartners { get; set; } = "3";

        public string incomeDerivedFromBTL { get; set; } = Defs.radioButtonNo;
        public string occupation { get; set; } = "TestOccupation";
        #endregion

        #region 'Self employed income' Section

        #region 'Year 1' Subsection
        public string yearOneEarnings { get; set; } = "65000";
        public string yearOneDividends { get; set; } = "0";
        public string yearOneDrawings { get; set; } = "0";
        public string yearOneRetainedEarnings { get; set; } = "0";
        public string yearOneEnding { get; set; } = "01/2019";
        #endregion

        #region 'Year 2' Subsection
        public string yearTwoEarnings { get; set; } = "75000";
        public string yearTwoDividends { get; set; } = "0";
        public string yearTwoDrawings { get; set; } = "0";
        public string yearTwoRetainedEarnings { get; set; } = "0";
        public string yearTwoEnding { get; set; } = "01/2020";
        #endregion

        #endregion
    }
}
