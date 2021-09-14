using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal
{
    public class MemorableWordPage : WebBasePage
    {
        public MemorableWordPage()
        {
            pageLoadedElement = firstCharacter;
            correspondingDataClass = new MemorableWordPageData().GetType();
            textName = "Mortgages Memorable Word Page";
        }
        public Element firstCharacter => new Element(FindElement("MC_cboChar1TextControl"));
        public Element secondCharacter => new Element(FindElement("MC_cboChar2TextControl"));
        public Element thirdCharacter => new Element(FindElement("MC_cboChar3TextControl"));

        public Element logon => new Element(FindElement("MC_cmdAuthenticate")).SetIsButtonFlag(true);
    }

    public class MemorableWordPageData : PageData
    {
        public string firstCharacter { get; set; } = "A";
        public string secondCharacter { get; set; } = "A";
        public string thirdCharacter { get; set; } = "A";
    }
}
