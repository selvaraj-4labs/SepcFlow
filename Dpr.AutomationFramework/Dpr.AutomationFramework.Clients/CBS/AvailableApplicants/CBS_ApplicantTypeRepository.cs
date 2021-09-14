using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using System;
using System.Collections.Generic;
using static Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableApplicants.CBS_ApplicantTypeList;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Clients.CBS.AvailableApplicants
{
    public class CBS_ApplicantTypeRepository
    {
        public List<List<string>> GetApplicantType(string applicantName)
        {
            List<List<string>> updatedValues = new List<List<string>>();
            ApplicantTypes applicantType;
            CBS_ApplicantTypeRepository applicantRepo = new CBS_ApplicantTypeRepository();

            bool tryParse = Enum.TryParse(applicantName.ToLower().Replace(" ", ""), out applicantType);
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
                case ApplicantTypes.esis1:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "rightToBuy", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "discountedPurchasePrice", "200000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "200000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "0" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS1##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Employed" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });


                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis2:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "firstTimeBuyers", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sharedOwnership", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "housingAssociation", "Accent Group Ltd" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "326000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "percentageBeingPurchased", "25" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "rentalServiceCharges", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "30000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "20000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS2##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_2", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_2", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_3", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_3", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_4", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_4", "ownershipType", "Sole Trader" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB259FL" });

                    //updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "Shared Ownership 2 Yr Fixed 19122019" });
                    break;

                case ApplicantTypes.esis3:
                    updatedValues.Add(new List<string> { "CBS_DIP03", "applicationSubmittedViaMortgageClub", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "mortgageClub", "Cambridge Select Legal & General Mortgage Club" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "equitySchemeProvider", "Churchill College" });
                    // NOTE
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "326000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "226000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "equityPercentage", "60" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "equityPercentage", "60" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "termYears", "30" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "50000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentStrategy_1", "Sale of Security Property" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS3##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP07", "nameOrNumber", "81" });
                    updatedValues.Add(new List<string> { "CBS_DIP07", "postcode", "CB250EQ" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Fixed Term Contract" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis4:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "firstTimeBuyers", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "rightToBuy", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "400000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "discountedPurchasePrice", "250000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "250000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "termYears", "25" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "0" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentStrategy_1", "Sale of Security Property" });


                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS4##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Retired" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "applicantFoundProperty", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "5 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis5:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "326000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "226000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS5##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndEmployed", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_2", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndEmployed_2", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_3", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndEmployed_3", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_4", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndEmployed_4", "fullTime", Defs.radioButtonNo });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "17" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB215EH" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis6:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "termYears", "25" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "50000" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "326000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "0" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS6##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    // TODO: Send Email to CBS regarding 'Standard Variable Rate' products not being available.
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis7:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP03", "applicationSubmittedViaMortgageClub", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "mortgageClub", "Cambridge Select Legal & General Mortgage Club" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "325000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "450000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "125000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAllocationAmount_1", "325000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS7##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed", "zeroHoursContract", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_2", "zeroHoursContract", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_3", "zeroHoursContract", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_4", "zeroHoursContract", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    // TODO: Send Email to CBS regarding 'Fixed for term' products not being available.
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis8:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS8##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_2", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_3", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP09_Employed_4", "withinProbationaryPeriod", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    break;

                case ApplicantTypes.esis9:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "600000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentStrategy_1", "UK Pension" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentPlanCost_1", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "projectedValue_1", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAllocationAmount_1", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Interest Only" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentPlanFrequency_1", "Monthly" });
                    // NOTE: Can't define 'Interest Only Amount' when 'repaymentType' = 'Interest Only'

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS9##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });

                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_2", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_2", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_3", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_3", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_SelfEmployed_4", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndSelfEmployed_4", "ownershipType", "Partnership" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "applicantFoundProperty", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Discount Res 25042019" });
                    break;

                case ApplicantTypes.esis10:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "familyAssistance", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "securedDepositAmount", "20000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "numberOfAccounts", "2" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "50000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS10##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_FTC", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndFTC", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_FTC_2", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndFTC_2", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_FTC_3", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndFTC_3", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_DIP09_FTC_4", "hasContractBeenRenewed", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_DIP09_2ndFTC_4", "hasContractBeenRenewed", Defs.radioButtonNo });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "17" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB215EH" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "5 Yr Fixed Res (fee free) 23012020" });
                    break;

                case ApplicantTypes.esis11:
                    updatedValues.Add(new List<string> { "CBS_DIP02", "applicantType", "Individual" });
                    updatedValues.Add(new List<string> { "CBS_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_DIP03", "typeOfSale", "Execution Only" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "firstTimeLandlord", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedMonthlyRentalIncome", "1500" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "expat", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "250000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "325000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "75000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS11##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Retired" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "2" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB215EH" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "Interest Only 2 Yr Fixed Rate 23012020" });
                    break;

                case ApplicantTypes.esis12:
                    updatedValues.Add(new List<string> { "CBS_DIP02", "applicantType", "Limited Company" });
                    updatedValues.Add(new List<string> { "CBS_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_DIP03", "typeOfSale", "Execution Only" });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "applicationSubmittedViaMortgageClub", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "mortgageClub", "Cambridge Select Legal & General Mortgage Club" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedMonthlyRentalIncome", "2000" });
                    
                    updatedValues.Add(new List<string> { "CBS_DIP05", "limitedCompanyName", "ESIS12##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS12##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    // Note to CBS, no tracker products.
                    //updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Discount BTL 07092017" });
                    break;

                case ApplicantTypes.esis13:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "ARUser1" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password1" });

                    updatedValues.Add(new List<string> { "CBS_DIP02", "loanType", "BTL" });
                    updatedValues.Add(new List<string> { "CBS_DIP02", "ownAnyOtherBTLProperties", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP02", "borrowerEverLivedInProperty", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "firstTimeLandlord", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedMonthlyRentalIncome", "400" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "450000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Interest Only" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "150000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS13##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Student" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CBH1 1AB" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "Credit Assist 2Yr Fixed BTL 19122019" });
                    break;

                case ApplicantTypes.esis14:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "350000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "500000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAllocationAmount_1", "350000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS14##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Not working" });
                    updatedValues.Add(new List<string> { "CBS_DIP08", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP10", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Not working" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP10_2", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "employmentStatus", "Not working" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_3", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP10_3", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "employmentStatus", "Not working" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_4", "otherSourcesOfIncome", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP10_4", "otherSourcesOfIncome", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "applicantFoundProperty", Defs.radioButtonNo });

                    // Note to CBS, no variable home loan products.
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Fixed Res 23012020" });

                    break;

                case ApplicantTypes.esis15:
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "username", "Broker123" });
                    updatedValues.Add(new List<string> { "CBS_LoginPage", "password", "Password2" });

                    updatedValues.Add(new List<string> { "CBS_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_DIP03", "typeOfSale", "Execution Only" });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "applicationSubmittedViaMortgageClub", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP03", "mortgageClub", "Cambridge Select Legal & General Mortgage Club" });

                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "350000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "400000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedMonthlyRentalIncome", "3000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "50000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS15##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP07", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP07", "postcode", "CB250EQ" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_2", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_2", "postcode", "CB250EQ" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_3", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_3", "postcode", "CB250EQ" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_4", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_DIP07_4", "postcode", "CB250EQ" });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Discount Res 25042019" });
                    break;

                // NOTE: Updates may be required when access to portal is given.
                #region Advised Portal Section
                case ApplicantTypes.esis16:

                    // Commented out due to 'Central Store' not existing on dpr env.
                    //updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Central Store" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Central Cambridge" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Karen Andrews" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "375000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "230000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sourceOfDepositAmount_1", "145000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "25" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS16##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP07", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP07", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis17:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Cottenham" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Andrew Fowler" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "firstTimeBuyers", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "familyAssistance", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "securedDepositAmount", "30000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "500000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sourceOfDepositAmount_1", "200000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "interestOnlyAmount", "100000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS17##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_2", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_2", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_3", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_3", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_4", "ownershipType", "Sole Trader" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_4", "ownershipType", "Sole Trader" });
                    break;

                case ApplicantTypes.esis18:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Great Shelford" });
                    // DPR env does not contain 'Cristiana Zigmond' as an adviser.
                    //updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Cristiana Zigmond" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Sylvia Smith" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equitySchemeProvider", "Churchill College" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equityPercentage", "50" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "326000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "100000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sourceOfDepositAmount_1", "226000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS18##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmploymentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Fixed Term Contract" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmploymentStatus", "Fixed Term Contract" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_FTC", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndFTC", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_FTC_2", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndFTC_2", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_FTC_3", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndFTC_3", "hasContractBeenRenewed", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndFTC_4", "hasContractBeenRenewed", Defs.radioButtonYes });
                    break;

                case ApplicantTypes.esis19:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Great Shelford" });
                    // DPR env does not contain 'Cristiana Zigmond' as an adviser.
                    //updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Cristiana Zigmond" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Sylvia Smith" });

                    //updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedOwnership", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "housingAssociation", "Accent Group Ltd" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "purchasingAdditionalShare", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "shareCurrentlyOwned", "25" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "additionalPercentageBeingPurchased", "25" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "rentalServiceCharges", "1" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equityPercentage", "0" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS19##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Retired" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "1" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis20:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Ely" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Sylvia Smith" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equityPercentage", "0" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equitySchemeProvider", "Kings College" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "475000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "600000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sourceOfDepositAmount_1", "125000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "23" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "interestOnlyAmount", "175000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS20##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });
                    break;

                case ApplicantTypes.esis21:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Great Shelford" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Nick Kiln" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "whatKindOfSale", "Execution Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "expat", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "350000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "450000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "1780" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS21##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmploymentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Self Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmploymentStatus", "Self Employed" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_2", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_2", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_3", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_3", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_SelfEmployed_4", "ownershipType", "Partnership" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndSelfEmployed_4", "ownershipType", "Partnership" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "3" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis22:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Cambourne" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Sylvia  Smith" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "firstTimeLandlord", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "225000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "325000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "1250" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS22##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Student" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Student" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "17" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB255EH" });
                    break;

                case ApplicantTypes.esis23:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Sawston" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Nick Kiln" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "whatKindOfSale", "Execution Only" });

                    //updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "firstTimeLandlord", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "475000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "1700" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "letToBuy", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equityPercentage", "0" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "25" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Interest Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS23##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed_2", "fullTime", Defs.radioButtonNo });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed_2", "fullTime", Defs.radioButtonNo });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis24:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Newmarket" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Mortgage Adviser Spare" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "whatKindOfSale", "Execution Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "firstTimeLandlord", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "200000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "390000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "1250" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "letToBuy", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sharedEquity", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "equityPercentage", "0" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "30" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Interest Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "4" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS24##01" });


                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_2", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_3", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "employmentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmployment", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP08_4", "secondaryEmploymentStatus", "Employed" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed_2", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed_2", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed_3", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed_3", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_Employed_4", "withinProbationaryPeriod", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP09_2ndEmployed_4", "withinProbationaryPeriod", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis25:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Central Cambridge" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Nick Kiln" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "200000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "300000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS25##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "15" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis26:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Histon" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Sylvia Smith" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanPurpose", "Remortgage" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "220000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "400000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "interestOnlyAmount", "20000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "30" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAllocationAmount_1", "220000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS26##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis27:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Great Shelford" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Nick Kiln" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "whatKindOfSale", "Execution Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "350000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "475000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "sourceOfDepositAmount_1", "125000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "30" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "2500" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "repaymentType", "Part and Part" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "interestOnlyAmount", "50000" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "HPY PTH" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS27HP##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;

                case ApplicantTypes.esis28:
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP02", "loanType", "BTL" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "branch", "Cottenham" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "adviser", "Nick Kiln" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP03", "whatKindOfSale", "Execution Only" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanPurpose", "Remortgage" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAmount", "150000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedValue", "350000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "loanAllocationAmount_1", "150000" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "termYears", "30" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "2500" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP04", "estimatedMonthlyRentalIncome", "1700" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "firstName", "Test-Script" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP06", "surname", "ESIS28##01" });

                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "nameOrNumber", "12" });
                    updatedValues.Add(new List<string> { "CBS_ADV_DIP14", "postcode", "CB250EQ" });
                    break;
                #endregion

                case ApplicantTypes.esis29:
                    updatedValues.Add(new List<string> { "CBS_DIP04", "estimatedValue", "526000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "loanAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "termRequirements", "RIO" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "termYears", "40" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentType", "Interest Only" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "repaymentPlanFrequency_1", "Monthly" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "interestOnlyAmount", "300000" });
                    updatedValues.Add(new List<string> { "CBS_DIP04", "sourceOfDepositAmount_1", "226000" });

                    updatedValues.Add(new List<string> { "CBS_DIP06", "numberOfApplicants", "2" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "firstName", "RIO" });
                    updatedValues.Add(new List<string> { "CBS_DIP06", "surname", "ESIS29##01" });

                    updatedValues.Add(new List<string> { "CBS_DIP08", "employmentStatus", "Retired" });
                    updatedValues.Add(new List<string> { "CBS_DIP08_2", "employmentStatus", "Retired" });

                    updatedValues.Add(new List<string> { "CBS_DIP10", "doYouHaveAnySourceOfIncomeIntoRetirement", Defs.radioButtonYes });
                    updatedValues.Add(new List<string> { "CBS_DIP10_2", "doYouHaveAnySourceOfIncomeIntoRetirement", Defs.radioButtonYes });

                    updatedValues.Add(new List<string> { "CBS_DIP14", "nameOrNumber", "79" });
                    updatedValues.Add(new List<string> { "CBS_DIP14", "postcode", "CB250EQ" });

                    // Note to CBS, no RIO variable for term products.
                    updatedValues.Add(new List<string> { "CBS_PBD01", "_userInputProductName", "2 Yr Discount Res 25042019" });
                    break;
            }
            return updatedValues;
        }
    }
}
