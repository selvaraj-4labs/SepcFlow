using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Report;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP27 : EAP27
    {
        private readonly TestContext _testContext;

        public HEBS_EAP27(TestContext testContext) : base(testContext)
        {
            _testContext = testContext;

            pageLoadedElement = twoFactorAuthenticationRbtn;
            correspondingDataClass = new HEBS_EAP27Data().GetType();
            textName = "2 Factor Authentication";
            pageCondition = new PageCondition(new Element(new ConditionList()
            .Add(new Condition("HEBS_EAP12", "dedupe", "false"))
            .Add(new Condition("HEBS_EAP04", "dateOfBirth", ">=16", Defs.conditionTypeCompareYearDifferenceDdMmYyyy))));
        }

        public override void CompletePage(IWebDriver driver, Data data, bool continueToNextPageFlag = true, bool logAndOutputInput = false)
        {
            VanillaCompletePage(driver, data, continueToNextPageFlag, logAndOutputInput);
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
                            if (data.GetFor("HEBS_EAP00").productType.ToLower() != "corporate")
                            {
                                messageContentList = mtr.GetMailsContentSearchByDestinationAddressAndTitle(
                                    data.GetFor("HEBS_EAP04").emailAddress,
                                    "Ref CUS1010",
                                    receivedAfter: startTime.AddMinutes(-1));
                            }
                            else
                            {
                                messageContentList = mtr.GetMailsContentSearchByDestinationAddressAndTitle(
                                    data.GetFor("HEBS_EAP05").emailAddress,
                                    "Ref CUS1010",
                                    receivedAfter: startTime.AddMinutes(-1));
                            }
                        } while (messageContentList.Count == 0 || (previousEmails.Count > 0 && messageContentList[0] == previousEmails[0]));

                        foreach (string htmlSource in messageContentList)
                        {
                            startIndexOfCode = htmlSource.IndexOf("Your authentication code is: ") + 29;
                            twoFaCode = htmlSource.Substring(startIndexOfCode, codeLength);

                            if (logAndOutputInput)
                            {
                                Console.Write("\r\n'pleaseEnterYourVerificationCode'...");
                            }
                            CompleteElement(twoFaCode, pleaseEnterYourVerificationCode.locator);
                            if (logAndOutputInput)
                            {
                                Console.Write("\r\n'verifyCodeBtn'...clicking");
                            }
                                
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
                            if (logAndOutputInput)
                            {
                                Console.Write("\r\n'requestCodeBtn'...clicking");
                            }
                            ClickElement(requestCodeBtn.locator);
                            while (GetNumberOfElements(pleaseWait.locator) > 0)
                            { Thread.Sleep(200); }
                        }
                        previousEmails = messageContentList;
                    } while (twoFaCompletedSuccessfully == false && DateTime.Now.Subtract(startTime).TotalMilliseconds < maxTryForMs);
                    if (twoFaCompletedSuccessfully == false)
                    {
                        new TestEnder().FailEnd(Defs.failNonAssert, "Valid two factor authentication code not received!", driver, _testContext);
                    }           
                }
            }
        }

        private void VanillaCompletePage(IWebDriver driver, Data data, bool continueToNextPageFlag = true, bool logAndOutputInput = false)
        {
            this.logAndOutputInput = logAndOutputInput;
            this.driver = driver;
            if (this.pageCondition == null ||
                AreElementConditionsMet(this.pageCondition.conditions, data) == true)
            {
                if (logAndOutputInput)
                {
                    ReportGenerator.AddNotes(
                        Thread.CurrentThread.ManagedThreadId.ToString(),
                        "\r\n<br><b>" + className + "</b>");
                }
                WaitForNextScreen(pageLoadedElement);
                List<Section> sectionTracker = new List<Section>();
                Section currentSection;
                string requiredValue;
                Element currentElement;

                foreach (PropertyInfo prop in this.GetType().GetProperties())
                {
                    string propType = null;
                    currentElement = null;

                    if (prop.PropertyType.Name == "Element")
                    {
                        currentElement = (Element)prop.GetValue(this);
                        if (logAndOutputInput)
                        {
                            //Console.Write("\r\n'{0}'...", prop.Name);
                            ReportGenerator.AddNotes(
                                Thread.CurrentThread.ManagedThreadId.ToString(),
                                "\r\n'" + prop.Name + "'...");
                            if (!currentElement.completePageElement)
                            {
                                //Console.Write("not completing because this is not part of the typical page logic");
                                ReportGenerator.AddNotes(
                                    Thread.CurrentThread.ManagedThreadId.ToString(),
                                    "not completing because this is not part of the typical page logic");
                            }
                        }
                    }
                    if (prop.PropertyType.Name == "Section" ||
                        prop.PropertyType.Name == "SectionEnd" ||
                        prop.PropertyType.Name == "WaitFor" ||
                        (currentElement != null && currentElement.completePageElement == true))
                    {
                        requiredValue = null;

                        if (!prop.Name.Contains("Btn") &&
                            prop.PropertyType.Name != "WaitFor" &&
                            prop.PropertyType.Name != "Section" &&
                            prop.PropertyType.Name != "SectionEnd")
                        {
                            MethodInfo dataGetForCall = data.GetType().GetMethod("GetFor");
                            dynamic dataGetForCallReturn = dataGetForCall.Invoke(
                                data,
                                new object[] { className });
                            requiredValue = dataGetForCallReturn.GetType()
                                .GetMethod("GetValueOf")
                                .Invoke(dataGetForCallReturn,
                                new object[]
                                {
                                prop.Name
                                    .Replace("Lookup", "")
                                    .Replace("Rbtn", "")
                                    .Replace("Chbox", "")
                                    .Replace("Box", "")
                                });
                        }
                        propType = prop.PropertyType.Name;

                        if (prop.PropertyType.Name == "SectionEnd")
                        {
                            sectionTracker.RemoveAt(sectionTracker.Count - 1);
                        }

                        else if (prop.PropertyType.Name == "Section")
                        {
                            currentSection = (Section)prop.GetValue(this);
                            currentSection.SetSectionConditionMetStatus(
                                AreElementConditionsMet(currentSection.conditions, data));
                            sectionTracker.Add(currentSection);
                        }

                        else if (sectionTracker.Count == 0 || AreAllSectionConditionsMet(sectionTracker) == true)
                        {

                            switch (propType)
                            {
                                case "RadioButton":
                                    CompleteElement(requiredValue, (RadioButton)prop.GetValue(this));
                                    break;

                                case "By":
                                    if (!prop.Name.Contains("Btn"))
                                    {
                                        CompleteElement(requiredValue, (By)prop.GetValue(this));
                                    }

                                    else
                                    {
                                        ClickElement((By)prop.GetValue(this));
                                    }
                                    break;

                                case "WaitFor":
                                    CompleteElement((WaitFor)prop.GetValue(this), data);
                                    break;

                                case "Element":

                                    if (currentElement.GetIsButton() == true)
                                    {
                                        if (continueToNextPageFlag == true ||
                                            (continueToNextPageFlag == false && currentElement.GetIsPageContinueButton() == false))
                                        {
                                            ClickElement(currentElement, data);
                                        }
                                    }

                                    else
                                    {
                                        CompleteElement(requiredValue, currentElement, data);
                                    }
                                    break;

                                default:
                                    Console.WriteLine("PropertyType incorrect");
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }

    public class HEBS_EAP27Data : EAP27Data
    {
    }
}
