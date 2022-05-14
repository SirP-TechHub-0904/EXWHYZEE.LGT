using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBRARY.EXWHYZEE.LGT.Data.Model
{
    public class SpecialProject
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullAddress { get; set; }

        public ICollection<Image> Images { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public long SpecialProjectCategoryId { get; set; }
        public SpecialProjectCategory SpecialProjectCategory { get; set; }

    }
}

//SECURITY

//   VIGILANTE GROUP ONE
//   VIGILANTE GROUP TWO


//TRADITIONAL INSTITUTION
//   EMIR
//   SULTAN
//   IGWE
//   OHANAEZE

//POLICE STATIONS
//   ZONE 9
//   ZONE 8
//   ZONE 5

//PRIMARY SCHOOLS
//   NYANYA NURSERY AND PRIMARY SCHOOL
//   FEDERAL PRIMARY SCHOOL
//   COMMUNITY PRIMARY SCHOOL

//SECONDARY SCHOOLS
//   COMMUNITY SCONDARY SCHOOL
//   COMMUNITY TECHNICAL SCHOOL

//OTHER GOVT INSTITUTES
//   MINISTRY OF HEALTH
//   MINISTRY OF EDUCATION
//   MINISTRY OF YOUTH

//HOSPITAL/CLINICS
//   FMC
//   STATE HOSPITAL

//INDUSTRIES
//   COTTON INDUSTRY
//   MINING INDUSTRY

//NGOS
//   JUNIOR CHAMBER INTERNATIONAL
