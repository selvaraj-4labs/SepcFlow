using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    /// <summary>
    /// Abstract definition of input elements
    /// </summary>
    public class Element
    {
        #region Paramter Definition / 'Element' Constructor
        public RadioButton radioButton { get; set; }
        public ButtonGroup buttonGroup { get; set; }
        public By locator { get; set; }
        public List<ConditionList> condListList { get;set; }
        public bool validationCompletePageResetRequired { get; set; } = false;
        public By buttonPressRequiredIfRepeater;
        private bool isButton { get; set; } = false;
        private bool isPageContinueButton { get; set; } = false;
        public bool completePageElement { get; set; } = true;
        public string validationType { get; set; } = Defs.validationTypeStandard;

        //Constructor for non radiobutton non repeater controls. Repeater button using By
        public Element(By locator, ConditionList condList, By buttonPressRequiredIfRepeater=null)
        {
            this.condListList = new List<ConditionList>();
            this.locator = locator;
            this.condListList.Add(condList);
            this.radioButton = null;
            this.buttonPressRequiredIfRepeater = buttonPressRequiredIfRepeater;
            this.buttonGroup = null;
        }

        //Constructor for radio button non repeater controls. Repeater button using By
        public Element(RadioButton radioButton, ConditionList condList, By buttonPressRequiredIfRepeater=null)
        {
            this.condListList = new List<ConditionList>();
            this.locator = null;
            this.condListList.Add(condList);
            this.radioButton = radioButton;
            this.buttonPressRequiredIfRepeater = buttonPressRequiredIfRepeater;
            this.buttonGroup = null;
        }

        //Constructor for non radiobutton non repeater controls. Repeater button using Element
        //uses this constructor if the repeater button is supplied else this remails null
        public Element(By locator, ConditionList condList, Element buttonPressRequiredIfRepeater)   
        {
            this.condListList = new List<ConditionList>();
            this.locator = locator;
            this.condListList.Add(condList);
            this.radioButton = null;
            this.buttonPressRequiredIfRepeater = buttonPressRequiredIfRepeater.locator;
            this.buttonGroup = null;
        }

        //Constructor for radio button non repeater controls. Repeater button using Element
        public Element(RadioButton radioButton, ConditionList condList, Element buttonPressRequiredIfRepeater)
        {
            this.condListList = new List<ConditionList>();
            this.locator = null;
            this.condListList.Add(condList);
            this.radioButton = radioButton;
            this.buttonPressRequiredIfRepeater = buttonPressRequiredIfRepeater.locator;
            this.buttonGroup = null;
        }

        //Constructor for conditions related to Section class
        public Element(ConditionList condList)
        {
            this.condListList = new List<ConditionList>();
            this.locator = null;
            this.condListList.Add(condList);
            this.radioButton = null;
            this.buttonGroup = null;
        }

        //Constructor for a By locator with no conditions
        public Element(By locator)
        {
            this.condListList = null;
            this.locator = locator;
            this.radioButton = null;
            this.buttonGroup = null;
        }

        //Constructor for a RadioButton locator with no conditions
        public Element(RadioButton rbLocator)
        {
            this.condListList = null;
            this.locator = null;
            this.radioButton = rbLocator;
            this.buttonGroup = null;
        }

        public Element(ButtonGroup buttonGroup, ConditionList condList, By buttonPressRequiredIfRepeater = null)
        {
            this.condListList = new List<ConditionList>();
            this.locator = null;
            this.condListList.Add(condList);
            this.buttonGroup = buttonGroup;
            this.radioButton = null;
            this.buttonPressRequiredIfRepeater = buttonPressRequiredIfRepeater;
        }

        public Element(ButtonGroup buttonGroup)
        {
            this.condListList = null;
            this.locator = null;
            this.radioButton = null;
            this.buttonGroup = buttonGroup;
        }
        #endregion

        #region Public Methods


        public Element SetCompletePageFlag(bool flagValue)
        {
            this.completePageElement = flagValue;
            return this;
        }

        public Element SetIsButtonFlag(bool flagValue)
        {
            this.isButton = flagValue;
            return this;
        }

        public Element SetIsPageContinueButtonFlag(bool flagValue)
        {
            this.isPageContinueButton = flagValue;
            return this;
        }

        public Element SetValidationType(string validationType)
        {
            this.validationType = validationType;
            return this;
        }

        public bool GetIsButton()
        {
            return isButton;
        }

        public bool GetIsPageContinueButton()
        {
            return isPageContinueButton;
        }

        public Element AddNewConditionList(ConditionList condList)
        {
            if (condListList == null) 
            { 
                condListList = new List<ConditionList>(); 
            }
            condListList.Add(condList);
            return this;
        }

        public Element SetValidationCompletePageResetRequired(bool valResetRequired)
        {
            validationCompletePageResetRequired = valResetRequired;
            return this;
        }
        #endregion
    }
    
    /// <summary>
    /// Define 
    /// </summary>
    public class ConditionList
    {
        #region Paramter Definition / 'ConditionList' Constructor
        public List<Condition> condList { get; set; }

        public ConditionList()
        {
            this.condList = new List<Condition>();
        }
        #endregion

        #region Public Methods
        public ConditionList Add(Condition newCondition)
        {
            condList.Add(newCondition);
            return this;
        }

        public ConditionList JoinConditionList(ConditionList conditionListToJoin)
        {
            ConditionList returnList = new ConditionList();
            foreach(Condition c in this.condList)
            {
                returnList.Add(c);
            }
            foreach (Condition c in conditionListToJoin.condList)
            {
                returnList.Add(c);
            }

            return returnList;
        }
        #endregion
    }

    public class Condition
    {
        public string elementClassName { get; set; }
        public string Element { get; set; }
        public string requiredValue { get; set; }

        public By ElementBy {get; set;}

        public string conditionType { get; set; }

        // This constructor is used to check that an item of 
        // data equals or does not equal the required value
        public Condition(
            string elementClassName, 
            string Element, 
            string requiredValue, 
            string conditionType=null)
        {
            this.elementClassName= elementClassName;
            this.Element = Element;
            this.requiredValue = requiredValue;
            this.ElementBy = null;

            if (conditionType == null)
            {
                this.conditionType = Defs.conditionTypeEqual;
            }
            else
            {
                this.conditionType = conditionType;
            }
        }

        // This constructor is used if the condition is 
        // using an Element rather than data.
        public Condition(
            By ElementBy, 
            string requiredValue, 
            string conditionType= null)
        {
            this.elementClassName = null;
            this.ElementBy = ElementBy;
            this.Element = null;
            this.requiredValue = requiredValue;

            if (conditionType == null)
            {
                this.conditionType = Defs.conditionIsElementDisplayed;
            }
            else
            {
                this.conditionType = conditionType;
            }
        }

        // This constructor is used if the condition is checking 
        // if an element is displayed on screen. Takes Element.
        public Condition(
            Element element, 
            string requiredValue, 
            string conditionType = null)
        {
            By locator;
            if (element.radioButton == null)
            {
                locator = element.locator;
            }
            else
            {
                locator = element.radioButton.radioButtonOptions.ElementAt(0).locator;
            }
            this.elementClassName = null;
            this.ElementBy = locator;
            this.Element = null;
            this.requiredValue = requiredValue;
            if (conditionType == null)
            {
                this.conditionType = Defs.conditionIsElementDisplayed;
            }
            else
            {
                this.conditionType = conditionType;
            }
        }
    }
}
