using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.CeaseThirdParty
{
    public class CeaseThirdPartyP1 : AppBasePage
    {
        public CeaseThirdPartyP1()
        {
            pageLoadedElement = activeThirdPartiesTableFirstRow;
            correspondingDataClass = new CeaseThirdPartyP1Data().GetType();
            textName = "Cease Third party Page 1";
        }

        // Need to enter the ThirdPartyNumber as 'Value'.

        #region 'Active Third Parties' Section
        public Element activeThirdPartiesTableFirstRow => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ultraGrid"),
            "/Custom[@AutomationId=\"Data Area\"]" +
            "/Tree[@AutomationId=\"ColScrollRegion: 0, RowScrollRegion: 0\"]" +
            "/DataItem[@Name=\"Representative\"]" +
            "/Edit[@Name=\"Third Party Type\"]"))
            .SetIsButtonFlag(true);
        #endregion

        #region 'Third Party - Cease' Section
        public Element thirdPartyNo=> new Element(FindElement("txtThirdPartyNo", attributeType: Defs.boLocatorAutomationId));
        public Element name => new Element(FindElement("txtName", attributeType: Defs.boLocatorAutomationId));
        public Element ceased=> new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "chkCeasedView")));
        public Element ceasedDate => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "txtCeasedDate"),
            "/Edit"));
        public Element ceaseReason=> new Element(FindElement("txtCeasedReason", attributeType: Defs.boLocatorAutomationId));
        public Element thirdPartyType=> new Element(FindElement("txtPartyType", attributeType: Defs.boLocatorAutomationId));
        #endregion
        public Element updateceasedDate=> new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtCeasedDate"),
            "/Edit"));
        public Element ceaseReasonLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboCeaseReason"),
            "/Edit"));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CeaseThirdPartyP1Data : PageData
    {
        private string _ceasedDate = null;
        private string _updateceasedDate = null;

        public string thirdPartyNo { get; set; } = null;
        public string name { get; set; } = null;
        public string ceased { get; set; } = null;
        public string ceasedDate
        {
            get
            {
                if (_ceasedDate == null)
                {
                    return null;
                }
                else
                {
                    return
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _ceasedDate.Replace("/", "");
                }
            }
            set
            {
                _ceasedDate = value;
            }
        }
        public string ceaseReason { get; set; } = "Clients Request";
        public string thirdPartyType { get; set; } = null;
        public string updateceasedDate
        {
            get
            {
                if (_updateceasedDate == null)
                {
                    return null;
                }
                else
                {
                    return
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _updateceasedDate.Replace("/", "");
                }
            }
            set
            {
                _updateceasedDate = value;
            }
        }
    }

}
