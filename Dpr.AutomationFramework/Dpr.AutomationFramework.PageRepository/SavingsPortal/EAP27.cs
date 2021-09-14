using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP27 : WebBasePage
    {
        private readonly TestContext _testContext;

        public EAP27(TestContext testContext)
        {
            _testContext = testContext;

            pageLoadedElement = twoFactorAuthenticationRbtn;
            correspondingDataClass = new EAP27Data().GetType();
            textName = "2 Factor Authentication";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition("EAP12", "dedupe", "false"))
            .Add(new Condition("EAP04", "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
        }

        #region Locators

        public Element twoFactorAuthenticationRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("SMS", FindElement("rdoVerificationMethods", "_0"))
            .AddRadioButtonElement("Email", FindElement("rdoVerificationMethods", "_1")));

        public Element requestCodeBtn => new Element(FindElement("btnRequestCodeButton")).SetIsButtonFlag(true);

        public Element pleaseEnterYourVerificationCode => new Element(FindElement("txtVerificationCode"));

        public Element verifyCodeBtn => new Element(FindElement("btnVerifyCode"), new ConditionList()
            .Add(new Condition(className, "pleaseEnterYourVerificationCode", null, Defs.conditionTypeNotEqual))).SetIsButtonFlag(true);

        public Element verificationFailureMessage => new Element(FindElement("There was a problem verifying your authentication", attributeType: Defs.locatorText))
            .SetCompletePageFlag(false);

        public Element pleaseWait => new Element(FindElement("This may take a few moments", attributeType: Defs.locatorText))
            .SetCompletePageFlag(false);

        public Element verificationSuccessIndicator => new EAP15().pageLoadedElement.SetCompletePageFlag(false);

        #endregion

        public override void CompletePage(IWebDriver driver, Data data, bool continueToNextPageFlag = true, bool logAndOutputInput = false)
        {
            base.CompletePage(driver, data, continueToNextPageFlag, logAndOutputInput);
            if (this.pageCondition == null || 
                AreElementConditionsMet(this.pageCondition.conditions, data) == true)
            {
                if (data.GetFor(className).pleaseEnterYourVerificationCode == null)
                {
                    int startIndexOfCode;
                    int codeLength = 6;
                    List<string> messageContentList;
                    MailtrapRetriever mtr = new MailtrapRetriever();
                    mtr.SetMailBoxAccessDetails(_testContext.Properties["mailTrapInboxId"].ToString(), _testContext.Properties["apiToken"].ToString());
                    string twoFaCode;
                    bool twoFaCompletedSuccessfully = false;
                    DateTime startTime = DateTime.Now;
                    int maxTryForMs = 30000;
                    List<string> previousEmails = new List<string>();
                    do
                    {
                        do
                        {
                            Thread.Sleep(100);
                            if (data.GetFor("ProductSelection").productType.ToLower() != "corporate")
                            {
                                messageContentList = mtr.GetMailsContentSearchByDestinationAddressAndTitle(
                                    data.GetFor("EAP04").emailAddress,
                                    "Ref CUS1010",
                                    receivedAfter: startTime.AddMinutes(-1));
                            }
                            else
                            {
                                messageContentList = mtr.GetMailsContentSearchByDestinationAddressAndTitle(
                                    data.GetFor("EAP05").emailAddress,
                                    "Ref CUS1010", 
                                    receivedAfter: startTime.AddMinutes(-1));
                            }
                        } while (messageContentList.Count == 0 || (previousEmails.Count>0 && messageContentList[0] == previousEmails[0]));

                        foreach (string htmlSource in messageContentList)
                        {
                            startIndexOfCode = htmlSource.IndexOf("Your authentication code is: ") + 29;
                            twoFaCode = htmlSource.Substring(startIndexOfCode, codeLength);
                            if (logAndOutputInput) Console.Write("\r\n'pleaseEnterYourVerificationCode'...");
                            CompleteElement(twoFaCode, pleaseEnterYourVerificationCode.locator);
                            if (logAndOutputInput) Console.Write("\r\n'verifyCodeBtn'...clicking");
                            ClickElement(verifyCodeBtn.locator);
                            
                            while (GetNumberOfElements(pleaseWait.locator) > 0)
                            { 
                                Thread.Sleep(100); 
                            }
                            ExplicitWait(verificationFailureMessage.locator, verificationSuccessIndicator.locator);
                            
                            if (IsElementDisplayed(verificationSuccessIndicator))
                            {
                                twoFaCompletedSuccessfully = true;
                                break;
                            }
                            //else
                            //{
                            //Lines below are used for debugging 2FA issue
                            //new ScreenCapture().Capture(driver, data.GetFor("SaveAndRestore").firstName + data.GetFor("SaveAndRestore").lastName);
                            //new TestEnder().FailEnd(Defs.failNonAssert, "Valid two factor authentication code not received!"/*, driver*/);
                            //}
                        }
                        if (twoFaCompletedSuccessfully == false && messageContentList.Count > 0)
                        {
                            if (logAndOutputInput) Console.Write("\r\n'requestCodeBtn'...clicking");
                            ClickElement(requestCodeBtn.locator);
                            while (GetNumberOfElements(pleaseWait.locator) > 0)
                            { Thread.Sleep(200); }
                        }
                        previousEmails = messageContentList;
                    } while (twoFaCompletedSuccessfully == false && DateTime.Now.Subtract(startTime).TotalMilliseconds < maxTryForMs);
                    if (twoFaCompletedSuccessfully == false)
                    {
                        new TestEnder().FailEnd(
                            Defs.failNonAssert,
                            "Valid two factor authentication code not received!",
                            driver,
                            _testContext);
                    }
                }
            }
        }
    }

    public class EAP27Data : PageData
    {
        public string twoFactorAuthentication { get; set; } = "Email"; // Code by Email.

        public string pleaseEnterYourVerificationCode { get; set; } = null;

    }
}
