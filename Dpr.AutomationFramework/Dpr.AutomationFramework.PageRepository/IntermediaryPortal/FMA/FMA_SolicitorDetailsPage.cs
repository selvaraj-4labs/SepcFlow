using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_SolicitorDetailsPage : WebBasePage
    {
        public FMA_SolicitorDetailsPage()
        {
            pageLoadedElement = solicitorCompanyName;
            correspondingDataClass = new FMA_SolicitorDetailsPageData().GetType();
            textName = "FMA Solicitor Details Page";
        }
        public Element solicitorCompanyName => new Element(FindElement("SolicitorCompanyName"));
        public Element postcode => new Element(FindElement("PostCode"));
        public Element findSolicitor => new Element(FindElement("ctl06_Search"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element solicitorSearchTable => new Element(new ButtonGroup()
            .AddButtonElement("Row 1", FindElement("SolicitorsGridSelect", "_0"))
            .AddButtonElement("Row 2", FindElement("SolicitorsGridSelect", "_1"))
            .AddButtonElement("Row 3", FindElement("SolicitorsGridSelect", "_2"))
            .AddButtonElement("Row 4", FindElement("SolicitorsGridSelect", "_3"))
            .AddButtonElement("Row 5", FindElement("SolicitorsGridSelect", "_4")));

        public Section solicitorSelectedSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "solicitorSearchTable", null, Defs.conditionTypeNotEqual))));

        public Element solicitorContactName => new Element(FindElement("txtSolicitorContactName"));
        public Element firmName => new Element(FindElement("txtFirmName"));
        public Element telephoneNumber => new Element(FindElement("txtTelephone"));
        public Element faxNumber => new Element(FindElement("txtFax"));
        public Element emailAddress => new Element(FindElement("txtEmail"));
        public Element dxNumber => new Element(FindElement("txtDXNumber"));
        public Element solicitorAddress => new Element(FindElement("txtSolicitorAddress"));

        public SectionEnd solicitorSelectedSectionEnd => new SectionEnd();

        public Element next => new Element(FindElement("_Next"))
            .SetIsButtonFlag(true);
    }

    public class FMA_SolicitorDetailsPageData : PageData
    {
        public string solicitorCompanyName { get; set; } = null;
        public string postcode { get; set; } = null;
        public string solicitorSearchTable { get; set; } = "Row 1";

        public string solicitorContactName { get; set; } = null;
        public string firmName { get; set; } = null;
        public string telephoneNumber { get; set; } = null;
        public string faxNumber { get; set; } = null;
        public string emailAddress { get; set; } = null;
        public string dxNumber { get; set; } = null;
        public string solicitorAddress { get; set; } = null;
    }
}
