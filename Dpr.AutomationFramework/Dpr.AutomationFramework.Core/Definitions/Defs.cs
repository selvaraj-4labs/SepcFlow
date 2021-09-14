namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions
{
    public static class Defs
    {
        #region Element values

        public const string radioButtonNo = "no";
        public const string radioButtonYes = "yes";
        public const string checkBoxNotSelected = "false";
        public const string checkBoxSelected = "true";

        #endregion

        #region Element types

        public const string controlTypeRadioBtn = "rbtn";
        public const string controlTypeLookupList = "lookup";
        public const string controlTypeCheckbox = "chbox";
        public const string controlTypeTextBox = "tbox";
        public const string controlTypeBtn = "btn";
        public const string contolTypeLbl = "lbl";

        #endregion

        #region Condition type

        public const string conditionTypeNotEqual = "notequals";
        public const string conditionTypeEqual = "equals";
        public const string conditionTypeCompareYearDifferenceMmYyyy = "compareyeardifferencemmyyyy";
        public const string  conditionTypeCompareYearDifferenceDdMmYyyy = "compareyeardifferenceddmmyyyy";
        public const string conditionIsElementDisplayed = "isElementDisplayed";
        public const string elementDisplayed = "true";
        public const string elementNotDisplayed = "false";

        #endregion

        #region Xpath attribute types [Portal]

        public const string locatorId = "id";
        public const string locatorName = "name";
        public const string locatorHref = "href";
        public const string locatorValue = "value";
        public const string locatorText = "text()";
        public const string locatorTitle = "title";
        public const string locatorType = "type";
        public const string locatorFor = "for";
        public const string locatorClass = "class";

        #endregion

        #region Xpath attribute types [App]

        public const string boLocatorId = "Id";
        public const string boLocatorName = "Name";
        public const string boLocatorHref = "Href";
        public const string boLocatorValue = "Value";
        public const string boLocatorText = "Text()";
        public const string boLocatorTitle = "Title";
        public const string boLocatorType = "Type";
        public const string boLocatorFor = "For";
        public const string boLocatorAutomationId = "AutomationId";
        public const string boLocatorClass = "ClassName";

        #endregion

        #region Validation Types

        public const string validationTypeStandard = "standard";
        public const string validationTypeSymbol = "symbol";
        public const string validationTypeDdMmYyyy = "ddmmyyyy";
        public const string validationTypeMmYyyy = "mmyyyy";
        public const string validationTypeNumberOfMonths = "numberofmonths";
        public const string validationTypeNumberOfYears = "numberofyears";
        public const string validationTypeYyyy = "yyyy";
        public const string validationTypeNiNumber = "niNumber";
        public const string validationTypeSourceOfDeposit = "sourceofdeposit";
        public const string validationTypeLoanBreakdown = "loanbreakdown";
        public const string validationTypeInterestOnlyAmount = "ioamount";
        public const string validationTypeRepaymentStrategy = "repaymentstrategy";
        public const string validationTypeNotRequired = "notrequired";
        public const string validationTypeAddress = "address";
        public const string validationTypeCalculativeRepeater = "calculativerepeater";

        #endregion

        #region Multi threading validation status

        public const string validationStatusStarted = "started";
        public const string validationStatusCompleted = "completed";

        #endregion

        #region AppJourney application types
        public const string appJourneyApplicationBackoffice = "backoffice";
        public const string appJourneyApplicationServicing= "servicing";

        #endregion

        #region FailTypes
        public const string failNonAssert = "!assert";
        public const string failAssert = "assert";
        //internal static string cancelThisWithdrawal;

        #endregion
    }
}
