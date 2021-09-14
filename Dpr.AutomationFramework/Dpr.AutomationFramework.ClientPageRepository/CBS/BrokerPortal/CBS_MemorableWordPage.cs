using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal
{
    public class CBS_MemorableWordPage : MemorableWordPage
    {
        public CBS_MemorableWordPage()
        {
            pageLoadedElement = firstCharacter;
            correspondingDataClass = new CBS_MemorableWordPageData().GetType();
            textName = "CBS Mortgages Login Page";
        }
    }

    public class CBS_MemorableWordPageData : MemorableWordPageData
    {
        public new string firstCharacter { get; set; } = "a";
        public new string secondCharacter { get; set; } = "a";
        public new string thirdCharacter { get; set; } = "a";
    }
}
