using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.ILL
{
    public class CBS_ILL04 : WebBasePage
    {
        public CBS_ILL04()
        {
            pageLoadedElement = numberOfApplicants;
            correspondingDataClass = new CBS_ILL04Data().GetType();
            textName = "CBS Applicant Details";
        }

        public Element numberOfApplicants => new Element(new RadioButton()
            .AddRadioButtonElement("1", FindElement("NumberOfApplicants_0"))
            .AddRadioButtonElement("2", FindElement("NumberOfApplicants_1"))
            .AddRadioButtonElement("3", FindElement("NumberOfApplicants_2"))
            .AddRadioButtonElement("4", FindElement("NumberOfApplicants_3")));

        #region 'Applicant 1' Section
        public Element applicantOneTitle => new Element(FindElement("item0", "Title", tag: "select"));
        public Element applicantOneFirstName => new Element(FindElement("item0", "FirstName"));
        public Element applicantOneSurname => new Element(FindElement("item0", "Surname"));
        #endregion

        #region 'Applicant 2' Section
        public Section applicantTwoSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "numberOfApplicants", "2")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "numberOfApplicants", "3")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "numberOfApplicants", "4"))));
        public Element applicantTwoTitle => new Element(FindElement("item1", "Title", tag: "select"));
        public Element applicantTwoFirstName => new Element(FindElement("item1", "FirstName"));
        public Element applicantTwoSurname => new Element(FindElement("item1", "Surname"));
        public SectionEnd applicantTwoSectionEnd => new SectionEnd();
        #endregion

        #region 'Applicant 3' Section
        public Section applicantThreeSection => new Section(new Element(
            new ConditionList()
                .Add(new Condition(className, "numberOfApplicants", "3")))
            .AddNewConditionList(new ConditionList()
                .Add(new Condition(className, "numberOfApplicants", "4"))));
        public Element applicantThreeTitle => new Element(FindElement("item2", "Title", tag: "select"));
        public Element applicantThreeFirstName => new Element(FindElement("item2", "FirstName"));
        public Element applicantThreeSurname => new Element(FindElement("item2", "Surname"));
        public SectionEnd applicantThreeSectionEnd => new SectionEnd();
        #endregion

        #region 'Applicant 4' Section
        public Section applicantFourSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "numberOfApplicants", "4"))));
        public Element applicantFourTitle => new Element(FindElement("item3", "Title", tag: "select"));
        public Element applicantFourFirstName => new Element(FindElement("item3", "FirstName"));
        public Element applicantFourSurname => new Element(FindElement("item3", "Surname"));

        public SectionEnd applicantFourSectionEnd => new SectionEnd();
        #endregion

        public Element next => new Element(FindElement("Next")).SetIsButtonFlag(true);
    }

    public class CBS_ILL04Data : PageData
    {
        public string numberOfApplicants { get; set; } = "4";

        #region 'Applicant 1' Data Section
        public string applicantOneTitle { get; set; } = "Mr";
        public string applicantOneFirstName { get; set; }
        public string applicantOneSurname { get; set; }
        #endregion

        #region 'Applicant 2' Data Section
        public string applicantTwoTitle { get; set; } = "Mrs";
        public string applicantTwoFirstName { get; set; }
        public string applicantTwoSurname { get; set; }
        #endregion

        #region 'Applicant 3' Data Section
        public string applicantThreeTitle { get; set; } = "Mr";
        public string applicantThreeFirstName { get; set; }
        public string applicantThreeSurname { get; set; }
        #endregion

        #region 'Applicant 4' Data Section
        public string applicantFourTitle { get; set; } = "Mrs";
        public string applicantFourFirstName { get; set; }
        public string applicantFourSurname { get; set; }
        #endregion

        public CBS_ILL04Data()
        {
            #region 'Applicant 1' Data Assignment Section
            applicantOneFirstName = UniqueStringGenerator();
            applicantOneSurname = UniqueStringGenerator();
            #endregion

            #region 'Applicant 2' Data Assignment Section
            applicantTwoFirstName = UniqueStringGenerator();
            applicantTwoSurname = UniqueStringGenerator();
            #endregion

            #region 'Applicant 3' Data Assignment Section
            applicantThreeFirstName = UniqueStringGenerator();
            applicantThreeSurname = UniqueStringGenerator();
            #endregion

            #region 'Applicant 4' Data Assignment Section
            applicantFourFirstName = UniqueStringGenerator();
            applicantFourSurname = UniqueStringGenerator();
            #endregion
        }


    }
}
