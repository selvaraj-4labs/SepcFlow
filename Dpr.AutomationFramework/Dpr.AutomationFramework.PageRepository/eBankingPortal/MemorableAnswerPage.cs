using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class MemorableAnswerPage : WebBasePage
    {
        public MemorableAnswerPage()
        {
            pageLoadedElement = logon;
            correspondingDataClass = new MemorableAnswerPageData().GetType();
            textName = "Memorable Answer Verification Page";
        }

        public Element firstCharLookup => new Element(FindElement("cboChar1TextControl"));


        public Element secondCharLookup => new Element(FindElement("cboChar2TextControl"));


        public Element thirdCharLookup => new Element(FindElement("cboChar3TextControl"));

        public Element logon => new Element(new ButtonGroup()
            .AddButtonElement("logon", FindElement("cmdAuthenticate")));
        // public Element logonBtn => new Element(FindElement("cmdAuthenticate")).SetIsButtonFlag(true);

        public Element forgottenYourMemorableAnswer => new Element(new ButtonGroup()
            .AddButtonElement("ForgottenYourMemorableAnswer", FindElement("ForgotMemorableWord", tag: "a")));
        
        //public Element forgottenYourMemorableAnswer => new Element(FindElement("ForgotMemorableWord", tag: "a"))
        //    .SetCompletePageFlag(false)
        //    .SetIsButtonFlag(true);
       

    }


    public class MemorableAnswerPageData : PageData
    {
        public string firstChar { get; set; } = "a";

        public string secondChar { get; set; } = "a";

        public string thirdChar { get; set; } = "a";

        public string logon { get; set; } = "logon";

        public string forgottenYourMemorableAnswer { get; set; } = null;
    }
}
