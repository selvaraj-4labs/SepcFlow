using System.Collections.Generic;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public static class ImplicitTimerTracker
    {
        static List<string> implicitTimerSessions = new List<string>();

        public static void AddToSession(string scenarioId)
        {
            lock(implicitTimerSessions)
            {
                implicitTimerSessions.Add(scenarioId);
            }
        }

        public static void RemoveFromSession(string scenarioId)
        {
            lock (implicitTimerSessions)
            {
                implicitTimerSessions.Remove(scenarioId);
            }
        }

        public static bool IsScenarioUsingImplicitTimer(string scenarioId)
        {
            lock (implicitTimerSessions)
            {
                return implicitTimerSessions.Contains(scenarioId);
            }
        }
    }
}
