using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class ImplicitTimer
    {
        private int timeoutInSeconds = 45;
        private BasePage page;
        private MethodInfo methodToExectue;
        private List<Object> parameters;
        private int pollingIntervalInMs;


        public ImplicitTimer(   
            BasePage page,
            string methodToExecute,
            string methodReturnType,
            List<string> parameterTypes,
            List<Object> parameters,
            int pollingIntervalInMs = 75)
        {
            int count;
            bool paramterMatch;
            MethodInfo requiredMethod = null;

            this.pollingIntervalInMs = pollingIntervalInMs;
            this.page = page;
            this.parameters = parameters;

            foreach(MethodInfo method in page.GetType().GetMethods())
            {
                if (method.Name == methodToExecute)
                {
                    paramterMatch = true;
                    if (method.ReturnType.Name.ToString().ToLower() != methodReturnType.ToLower())
                    {
                        paramterMatch = false;
                    }
                    else
                    {
                        count = 0;
                        foreach(ParameterInfo paramterInfo in method.GetParameters())
                        {
                            if(paramterInfo.ParameterType.Name.ToString() != parameterTypes.ElementAt(count).ToString())
                            {
                                paramterMatch = false;
                            }
                            count++;
                        }
                    }

                    if (paramterMatch == true)
                    {
                        requiredMethod = method;
                        break;
                    }
                }
            }
            if (requiredMethod == null)
            {
                new TestEnder().FailEnd(Defs.failNonAssert, "ImplicitTimer - " +
                    "Unable to find the method '" + methodToExecute + "' on page '" +
                    page.GetType().Name + "'.");
            }

            this.methodToExectue = requiredMethod;
        }

        public object Go()
        {
            string sessionId = ((AppBasePage)page).driver.SessionId.ToString();
            ImplicitTimerTracker.AddToSession(sessionId);
            double timer = 0;
            object returnData = null;
            Exception exception = new Exception();
            DateTime startTime = DateTime.Now;
            bool methodSuccessfullyCompleted = false;
            
            do
            {
                try
                {
                    returnData = methodToExectue.Invoke(page, parameters.ToArray());
                    methodSuccessfullyCompleted = true;
                }
                catch (Exception e)
                {
                    exception = e;
                    timer = (DateTime.Now - startTime).TotalMilliseconds;
                }
            } while (timer < (timeoutInSeconds * 1000) && 
                    methodSuccessfullyCompleted == false);

            ImplicitTimerTracker.RemoveFromSession(sessionId);
            if (!methodSuccessfullyCompleted)
            {
                string testError = "TEST ERROR";
                string testFail = "TEST FAIL";
                string failType = Defs.failNonAssert;
                int index = exception.InnerException.Message.IndexOf(testError);
                int lengthToStart = testError.Length;
                if (index == -1)
                {
                    index = exception.InnerException.Message.IndexOf(testFail);
                    lengthToStart = testFail.Length;
                    failType = Defs.failAssert;
                }
                string failMessage = exception.InnerException.Message.Substring(index + lengthToStart);
                new TestEnder().FailEnd(failType, failMessage, ((AppBasePage)page).driver);
            }

            return returnData;
        }
    }
}
