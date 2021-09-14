using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class FeesAndFeaturesPage : WebBasePage
    {
        private readonly TestContext _testContext;
        
        public FeesAndFeaturesPage(TestContext testContext)
        {
            _testContext = testContext;
            pageLoadedElement = intermediaryFees;
            correspondingDataClass = new FeesAndFeaturesPageData().GetType();
            textName = "Fees And Features Page";
        }

        #region 'Lender Fees' Section

        #region Fee Name Section
        // May not be all used.
        public Element lenderFeeName_1 => new Element(FindElement("FeesRepeater_item0_Td1"));
        public Element lenderFeeName_2 => new Element(FindElement("FeesRepeater_item1_Td1"));
        public Element lenderFeeName_3 => new Element(FindElement("FeesRepeater_item2_Td1"));
        public Element lenderFeeName_4 => new Element(FindElement("FeesRepeater_item3_Td1"));
        public Element lenderFeeName_5 => new Element(FindElement("FeesRepeater_item4_Td1"));
        public Element lenderFeeName_6 => new Element(FindElement("FeesRepeater_item5_Td1"));
        public Element lenderFeeName_7 => new Element(FindElement("FeesRepeater_item6_Td1"));
        public Element lenderFeeName_8 => new Element(FindElement("FeesRepeater_item7_Td1"));
        public Element lenderFeeName_9 => new Element(FindElement("FeesRepeater_item8_Td1"));
        public Element lenderFeeName_10 => new Element(FindElement("FeesRepeater_item9_Td1"));
        #endregion

        #region Fee Button Section
        // May not be all used.

        //public Element lenderFee_1Add => new Element(FindElement("item0", "_FeeCategory_0"));
        //public Element lenderFee_1Deduct => new Element(FindElement("item0", "_FeeCategory_1"));
        public Element lenderFee_1 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item0", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item0", "_FeeCategory_1")));

        //public Element lenderFee_2Add => new Element(FindElement("item1", "_FeeCategory_0"));
        //public Element lenderFee_2Deduct => new Element(FindElement("item1", "_FeeCategory_1"));
        public Element lenderFee_2 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item1", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item1", "_FeeCategory_1")));

        //public Element lenderFee_3Add => new Element(FindElement("item2", "_FeeCategory_0"));
        //public Element lenderFee_3Deduct => new Element(FindElement("item2", "_FeeCategory_1"));
        public Element lenderFee_3 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item2", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item2", "_FeeCategory_1")));

        //public Element lenderFee_4Add => new Element(FindElement("item3", "_FeeCategory_0"));
        //public Element lenderFee_4Deduct => new Element(FindElement("item3", "_FeeCategory_1"));
        public Element lenderFee_4 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item3", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item3", "_FeeCategory_1")));

        //public Element lenderFee_5Add => new Element(FindElement("item4", "_FeeCategory_0"));
        //public Element lenderFee_5Deduct => new Element(FindElement("item4", "_FeeCategory_1"));
        public Element lenderFee_5 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item4", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item4", "_FeeCategory_1")));

        //public Element lenderFee_6Add => new Element(FindElement("item5", "_FeeCategory_0"));
        //public Element lenderFee_6Deduct => new Element(FindElement("item5", "_FeeCategory_1"));
        public Element lenderFee_6 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item5", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item5", "_FeeCategory_1")));

        //public Element lenderFee_7Add => new Element(FindElement("item6", "_FeeCategory_0"));
        //public Element lenderFee_7Deduct => new Element(FindElement("item6", "_FeeCategory_1"));
        public Element lenderFee_7 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item6", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item6", "_FeeCategory_1")));

        //public Element lenderFee_8Add => new Element(FindElement("item7", "_FeeCategory_0"));
        //public Element lenderFee_8Deduct => new Element(FindElement("item7", "_FeeCategory_1"));
        public Element lenderFee_8 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item7", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item7", "_FeeCategory_1")));

        //public Element lenderFee_9Add => new Element(FindElement("item8", "_FeeCategory_0"));
        //public Element lenderFee_9Deduct => new Element(FindElement("item8", "_FeeCategory_1"));
        public Element lenderFee_9 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item8", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item8", "_FeeCategory_1")));

        //public Element lenderFee_10Add => new Element(FindElement("item9", "_FeeCategory_0"));
        //public Element lenderFee_10Deduct => new Element(FindElement("item9", "_FeeCategory_1"));
        public Element lenderFee_10 => new Element(new RadioButton()
            .AddRadioButtonElement("Add", FindElement("item9", "_FeeCategory_0"))
            .AddRadioButtonElement("Deduct", FindElement("item9", "_FeeCategory_1")));
        #endregion

        #endregion

        #region 'Intermediary Fees' Section
        public Element intermediaryFees => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement("HasIntermediaryFees_btn", "_rbl_0"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement("HasIntermediaryFees_btn", "_rbl_1")));

        public Section addIntermediaryFeesSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "intermediaryFees", Defs.radioButtonYes))));

        #region Intermediary Fee Repeater Subsection
        // Intermediary Fees - Fee 1
        public Element feeDescription_1 => new Element(FindElement("item0", "cboFeeDescription"));
        public Element amount_1 => new Element(FindElement("item0", "FeeAmount"));
        public Element whenPayable_1 => new Element(FindElement("item0", "FeeWhenPayable"));
        public Element refundableAmount_1 => new Element(FindElement("item0", "FeeRefundableAmount"));

        // Intermediary Fees - Fee 2
        public Element feeDescription_2 => new Element(FindElement("item1", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_2 => new Element(FindElement("item1", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_2 => new Element(FindElement("item1", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_2 => new Element(FindElement("item1", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_2", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        // Intermediary Fees - Fee 3
        public Element feeDescription_3 => new Element(FindElement("item2", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_3 => new Element(FindElement("item2", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_3 => new Element(FindElement("item2", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_3 => new Element(FindElement("item2", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_3", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        // Intermediary Fees - Fee 4
        public Element feeDescription_4 => new Element(FindElement("item3", "cboFeeDescription"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element amount_4 => new Element(FindElement("item3", "FeeAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element whenPayable_4 => new Element(FindElement("item3", "FeeWhenPayable"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);
        public Element refundableAmount_4 => new Element(FindElement("item3", "FeeRefundableAmount"),
            new ConditionList()
            .Add(new Condition(className, "intermediaryFee_4", null, Defs.conditionTypeNotEqual)),
            addIntermediaryFees);

        public Element addIntermediaryFees => new Element(FindElement("IntermediaryFees", "ctl01_btnAdd")).SetCompletePageFlag(false);
        #endregion
        public SectionEnd addIntermediaryFeesSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true)
            .SetIsPageContinueButtonFlag(true);

        // Retrieve the number of fees that are displayed
        private int GetNumberOfFees()
        {
            Dictionary<Element, bool> feeList = new Dictionary<Element, bool>()
            {
                { lenderFee_1, false },
                { lenderFee_2, false },
                { lenderFee_3, false },
                { lenderFee_4, false },
                { lenderFee_5, false },
                { lenderFee_6, false },
                { lenderFee_7, false },
                { lenderFee_8, false },
                { lenderFee_9, false },
                { lenderFee_10, false }
            };

            int numberOfFees = 0;
            bool isFeeDisplayed;

            // Update the boolean values in the dict depending on 
            // whenther the element is displayed.
            foreach (Element fee in feeList.Keys.ToList())
            {
                isFeeDisplayed = IsElementDisplayed(fee.radioButton.radioButtonOptions.ElementAt(0).locator, true);
                feeList[fee] = isFeeDisplayed;
            }

            numberOfFees = feeList.Where(fee => fee.Value == true).Count();
            return numberOfFees;
        }

        // Retrieve the name of the fees that have 
        // been updated to 'Deduct' by the user
        private List<string> GetNumberOfUpdates(PageData _pageData)
        {
            List<string> numberOfUpdates = new List<string>();
            
            for (int i = 0; i < 10; i++)
            {
                string checkFeeUpdate = _pageData.GetValueOf(
                    "_feeName_" + (i + 1).ToString());
                
                if (checkFeeUpdate != null)
                {
                    numberOfUpdates.Add(checkFeeUpdate);
                }
            }
            return numberOfUpdates;
        }

        private void CompleteUpdatedFees(int _numberOfAvailableFees, List<string> _nameOfFeesUpdated)
        {
            // If fee name == lenderFeeName_X && lenderFeeName_X.ElementAt(0) != null
            // THEN CompleteElement(Deduct)
            // Else CompleteElement(Add)

            Element[,] lenderFeeArray = new Element[,]
            {
                { lenderFeeName_1, lenderFee_1},
                { lenderFeeName_2, lenderFee_2},
                { lenderFeeName_3, lenderFee_3},
                { lenderFeeName_4, lenderFee_4},
                { lenderFeeName_5, lenderFee_5},
                { lenderFeeName_6, lenderFee_6},
                { lenderFeeName_7, lenderFee_7},
                { lenderFeeName_8, lenderFee_8},
                { lenderFeeName_9, lenderFee_8},
                { lenderFeeName_10, lenderFee_10}
            };

            // For every fee in the table, complete it.
            for (int i = 0; i < _numberOfAvailableFees; i++)
            {
                if (_nameOfFeesUpdated.Count() > 0)
                {
                    if (GetTextFromElement(lenderFeeArray[i, 0].locator) == _nameOfFeesUpdated[i])
                    {
                        CompleteElement(" ", lenderFeeArray[i, 1].radioButton.radioButtonOptions.ElementAt(1).locator);
                    }
                }
                else
                {
                    CompleteElement(" ", lenderFeeArray[i, 1].radioButton.radioButtonOptions.ElementAt(0).locator);
                }
            }
        }

        public override void CompletePage(
            IWebDriver driver,
            Data data,
            bool continueToNextPageFlag = true,
            bool logAndOutputInput = false)
        
        {
            this.logAndOutputInput = logAndOutputInput;
            this.driver = driver;
            WaitForNextScreen(pageLoadedElement);

            PageData pageData = data.GetFor(className);

            int numberOfAvailableFees = GetNumberOfFees();
            List<string> nameOfFeesUpdated = GetNumberOfUpdates(pageData);

            // If the number of changes is greater than the 
            // number of fees avaiable, there's a problem!
            if (nameOfFeesUpdated.Count() > numberOfAvailableFees)
            {
                new TestEnder().FailEnd(
                    Defs.failNonAssert,
                    "Page: '" + className + "'. The number of fees changed " +
                    "is greater than the number of fees displayed. " +
                    "Please review the fees and/or screenshot.",
                    driver,
                    _testContext);
            }

            CompleteUpdatedFees(numberOfAvailableFees, nameOfFeesUpdated);
            ClickElement(next, data);
        }
    }


    public class FeesAndFeaturesPageData : PageData
    {

        // Can't send a list using 'ChangeJourneyData' .:
        // individual values need to be sent.
        #region User Defined Fees 
        // The names of the fees that will be set to deduct.
        public string _feeName_1 { get; set; } = null;
        public string _feeName_2 { get; set; } = null;
        public string _feeName_3 { get; set; } = null;
        public string _feeName_4 { get; set; } = null;
        public string _feeName_5 { get; set; } = null;
        public string _feeName_6 { get; set; } = null;
        public string _feeName_7 { get; set; } = null;
        public string _feeName_8 { get; set; } = null;
        public string _feeName_9 { get; set; } = null;
        public string _feeName_10 { get; set; } = null;
        #endregion

        //public string applicationFee { get; set; } = "Deduct";
        //public string bacsTransferFee { get; set; } = "Deduct";


        #region 'Intermediary Fees' Section
        public string intermediaryFees { get; set; } = Defs.radioButtonNo;

        public string feeDescription_1 { get; set; } = null;
        public string amount_1 { get; set; } = null;
        public string whenPayable_1 { get; set; } = null;
        public string refundableAmount_1 { get; set; } = null;

        public string intermediaryFee_2 { get; set; } = null;
        public string feeDescription_2 { get; set; } = null;
        public string amount_2 { get; set; } = null;
        public string whenPayable_2 { get; set; } = null;
        public string refundableAmount_2 { get; set; } = null;

        public string intermediaryFee_3 { get; set; } = null;
        public string feeDescription_3 { get; set; } = null;
        public string amount_3 { get; set; } = null;
        public string whenPayable_3 { get; set; } = null;
        public string refundableAmount_3 { get; set; } = null;

        public string intermediaryFee_4 { get; set; } = null;
        public string feeDescription_4 { get; set; } = null;
        public string amount_4 { get; set; } = null;
        public string whenPayable_4 { get; set; } = null;
        public string refundableAmount_4 { get; set; } = null;
        #endregion

    }
}