using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.AddNewNote;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Notes.RespondToNote
{
    public class RespondToNoteP1 : NewNoteP1
    {
        public RespondToNoteP1()
        {
            pageLoadedElement = type;
            correspondingDataClass = new RespondToNoteP1Data().GetType();
            textName = "Respond To Note Page 1";
        }

    }

    public class RespondToNoteP1Data : NewNoteP1Data
    {
        public RespondToNoteP1Data()
        {
            type = null;
            warningType = null;
            title = null;
            customer = null;
            action = null;
            noteVisibileToCustomer = null;
            riskProfile = null;
            additionalInfo = "TestReply";
        }
        
    }
}
