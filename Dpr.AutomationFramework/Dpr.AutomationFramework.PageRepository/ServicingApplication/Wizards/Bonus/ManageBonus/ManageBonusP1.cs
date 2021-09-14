using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AddRegularDeposit
{
    public class ManageBonusP1 : AppBasePage
    {
        public ManageBonusP1()
        {
            pageLoadedElement = bonusName;
            correspondingDataClass = new ManageBonusP1Data().GetType();
            textName = "Manage Bonus Page 1";
        }

        public Element bonusName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtBonusName"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element type => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtType"), "/Edit"))
            .SetCompletePageFlag(false);
        
        public Element value => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtValue"), "/Edit"))
            .SetCompletePageFlag(false);
        
        public Element dueDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtDueDate"), "/Edit"))
            .SetCompletePageFlag(false);

        public Element amount => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtAmount"), "/Edit"));
        
        public Element status => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=cboStatus"), tag: "ComboBox"));
        
        public Element autoRedeem => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=chkAutoRedeem"), tag: "CheckBox"));
        
        public Element remarks => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "=txtRemarks"), "/Edit"));

        public Element confirm => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "=Confirm"), tag: "Button"))
            .SetIsButtonFlag(true);



    }

    public class ManageBonusP1Data : PageData
    {

        public string amount { set; get; } = null;

        public string status { set; get; } = "Available";

        public string autoRedeem { set; get; } = null;

        public string remarks { set; get; } = null;


    }
}
