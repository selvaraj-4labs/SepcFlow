using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableApplicants.HEBS_ApplicantTypeList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.HEBS.AvailableApplicants
{
    public class HEBS_ApplicantTypeRepository
    {
        public List<List<string>> GetApplicantType(string applicantName)
        {
            List<List<string>> updatedValues = new List<List<string>>();
            ApplicantTypes applicantType;
            HEBS_ApplicantTypeRepository applicantRepo = new HEBS_ApplicantTypeRepository();

            bool tryParse = Enum.TryParse(applicantName, out applicantType);
            if (tryParse == false)
                new TestEnder().FailEnd(
                    Defs.failNonAssert, 
                    "The applicant type '" + applicantName + 
                    "' does not exist. Please ensure the " +
                    "provided applicant type is correct.");

            updatedValues = applicantRepo.ApplicantTypeRepo(applicantType, updatedValues);
            return updatedValues;
        }

        public List<List<string>> ApplicantTypeRepo(ApplicantTypes applicantType, List<List<string>> updatedValues)
        {
            switch (applicantType)
            {
                // Changing the place of birth to Turin, Italy.
                case ApplicantTypes.Foreign:
                    updatedValues.Add(new List<string> { "HEBS_EAP04", "countryOfBirth", "Italy" });
                    updatedValues.Add(new List<string> { "HEBS_EAP04", "placeOfBirth", "Turin" });

                    break;

                // Changning DOB of applicant to 16 years ago.
                case ApplicantTypes.Child:
                    DateTime birthday = DateTime.Now.AddYears(-16).AddDays(-1).Date;
                    string year = birthday.Year.ToString();
                    string month = birthday.Month.ToString();
                    if (month.Length == 1) month = "0" + month;
                    string day = birthday.Day.ToString();
                    if (day.Length == 1) day = "0" + day;
                    updatedValues.Add(new List<string> { "HEBS_EAP04", "dateOfBirth", day + "/" + month + "/" + year });

                    break;
            }
            return updatedValues;
        }
    }
}
