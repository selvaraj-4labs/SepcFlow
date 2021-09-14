using System.Collections.Generic;
using System.Threading;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class AppAutomationQueue
    {
        private  Queue<string> journeyQueue = new Queue<string>();
        private  Dictionary<string, string> drivers = new Dictionary<string, string>();
        object journeyWaiting_lock = new object();
        bool journeyWaiting = false;

        public int waitPollTime = 750;

        //This is to be run at start of automation. Sets up drivers and sets max.
        public AppAutomationQueue AddDriver(string url)
        {
            lock (drivers)
            {
                drivers.Add(url, null);
            }

            return this;
        }

        //Wait for available driver and return url.
        public string WaitForAvailableDriver(string scenarioId)
        {
            lock (journeyQueue)
            {
                journeyQueue.Enqueue(
                    Thread.CurrentThread.ManagedThreadId.ToString());
            }
            do
            {
                Thread.Sleep(waitPollTime);
                lock (journeyQueue)
                {
                    lock (journeyWaiting_lock)
                    {
                        if (journeyQueue.Peek() == Thread.CurrentThread.ManagedThreadId.ToString() && 
                            !journeyWaiting)
                        {
                            journeyWaiting = true;
                            goto FrontOfQueueCode;
                        }
                    }
                }
            } while (true != false);

        FrontOfQueueCode:

            do
            {
                Thread.Sleep(waitPollTime);
                lock (drivers)
                {
                    foreach (KeyValuePair<string, string> item in drivers)
                    {
                        if (item.Value == null)
                        {
                            lock (journeyQueue)
                            {
                                journeyQueue.Dequeue();
                            }
                            drivers[item.Key] = Thread.CurrentThread.ManagedThreadId.ToString();
                            lock (journeyWaiting_lock)
                            {
                                    journeyWaiting = false;
                            }
                            return item.Key;
                        }
                    }
                }
            }
            while (true != false);
        }

        public void NotifyEndOfScenario(string scenarioId)
        {
            lock (drivers)
            {
                foreach (KeyValuePair<string, string> item in drivers)
                {
                    if (item.Value == Thread.CurrentThread.ManagedThreadId.ToString())
                    {
                        drivers[item.Key] = null;
                        break;
                    }
                }
            }
        }
    }
}

