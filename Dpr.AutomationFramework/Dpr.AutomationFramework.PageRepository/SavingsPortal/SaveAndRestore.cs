using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class SaveAndRestore : WebBasePage
    {
        public SaveAndRestore()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new SaveAndRestoreData().GetType();
            textName = "Save And Restore Page";
        }


        #region Your Details Section

        public Element titleLookup => new Element(FindElement("cboTitle"));

        public Element firstNameBox => new Element(FindElement("txtFirstName"));

        public Element lastNameBox => new Element(FindElement("txtSurname"));

        public Element dateOfBirthBox => new Element(FindElement("txtDateOfBirth"));

        public Element postcodeBox => new Element(FindElement("Postcode"));

        public Element emailAddressBox => new Element(FindElement("txtEmailAddress"));

        #endregion


        public Element nextBtn => new Element(FindElement("_Next")).SetIsButtonFlag(true);


    }

    public class SaveAndRestoreData : PageData
    {


        public string uniqueIdentifier { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }



        public SaveAndRestoreData()
        {
            uniqueIdentifier = UniqueStringGenerator();
            firstName  = UniqueStringGenerator();
            lastName =  UniqueStringGenerator();
        }

        public string title { get; set; } = "Mr";

        public string dateOfBirth { get; set; } = "09/12/1999";

        public string postcode { get; set; } = "CM16JN";

        public string emailAddress { get; set; } = "nathan.welch@dpr.co.uk";
    }
}
