using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class Profile : IdentityUser<string>
    {

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Middle Name")]
        public string Middlename { get; set; }

        [Display(Name = "Mother Maiden Name")]
        public string MotherMaidenName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Date Registration")]
        public DateTime DateRegistration { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Alternative Phone Number")]
        public string AltPoneNumber { get; set; }

        [Display(Name = "Spouse Name")]
        public string SpouseName { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Total Children")]
        public string TotalChildren { get; set; }

        [Display(Name = "State")]
        public long? StateId { get; set; }

        [Display(Name = "State")]
        public State State { get; set; }

        [Display(Name = "Local Government")]
        public long? LocalGovernmentId { get; set; }

        [Display(Name = "Local Government")]
        public LocalGovernment LocalGovernment { get; set; }

        [Display(Name = "Community")]
        public long? CommunitytId { get; set; }

        [Display(Name = "Community")]
        public Community Communities { get; set; }

        [Display(Name = "Permanent Home Address")]
        public string PermanentHomeAddress { get; set; }

        [Display(Name = "Contact Address")]
        public string ContactAddress { get; set; }

        [Display(Name = "Next of Kin Name")]
        public string NextKinName { get; set; }

        [Display(Name = "Next of Kin Email")]
        public string NextKinEmail { get; set; }

        [Display(Name = "Next of Kin Address")]
        public string NextKinAddress { get; set; }

        [Display(Name = "Next of Kin Phone Number")]
        public string NextKinPhone { get; set; }

        [Display(Name = "Next of Kin Relationship")]
        public string NextKinRelationship { get; set; }

        [Display(Name = "Next of Kin Occupation")]
        public string NextKinOccupation { get; set; }

        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        [Display(Name = "Emergency Contact Phone Number")]
        public string EmergencyContactPhone { get; set; }

        [Display(Name = "Emergency Contact Email Address")]
        public string EmergencyContactEmail { get; set; }

        [Display(Name = "State of Birth")]
        public string StateOfBirth { get; set; }

        [Display(Name = "States Visited")]
        public string StatesVisited { get; set; }

        [Display(Name = "Last Qualification")]
        public string LastQualification { get; set; }

        [Display(Name = "Last Qualification Year")]
        public string LastQualificationYear { get; set; }

        [Display(Name = "ID Card Number")]
        public string IdCardNumber { get; set; }

        [Display(Name = "ID Card Type")]
        public string IdCardType { get; set; }

        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Retirement Date")]
        public DateTime RetirementDate { get; set; }

        [Display(Name = "Position")]
        public string Position { get; set; }

        [Display(Name = "Level")]
        public string Level { get; set; }

        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        [Display(Name = "Last Promotion Date")]
        public string LastPromotionDate { get; set; }

        [Display(Name = "Method of Last Promotion")]
        public string MethodOfLastPromotion { get; set; }

        [Display(Name = "Salary Account Name")]
        public string SalaryAccountName { get; set; }

        [Display(Name = "Salary Account Number")]
        public string SalaryAccountNumber { get; set; }

        [Display(Name = "Salary Bank Name")]
        public string SalaryBankName { get; set; }

        [Display(Name = "BVN")]
        public string BVN { get; set; }

        [Display(Name = "PassPort Photograph")]
        public string PassPort { get; set; }

        [Display(Name = "ID Card Upload")]
        public string IdCardUpload { get; set; }

        [Display(Name = "Letter of Appointment")]
        public string LetterOfAppointment { get; set; }

        [Display(Name = "CV")]
        public string CV { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "FullName")]
        public virtual String FullName
        {
            get
            {
                return Surname + " " + Firstname + " " + Middlename;
            }
        }

        [Display(Name = "Employment Age")]
        public virtual String EmploymentAge
        {
            get
            {
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - AppointmentDate.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (DOB.Date > today.AddYears(-age))
                    age--;
                return age.ToString();
            }
        }

        [Display(Name = "Age")]
        public virtual String Age
        {
            get
            {
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - DOB.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (DOB.Date > today.AddYears(-age))
                    age--;
                return age.ToString();
            }
        }
    }
}
