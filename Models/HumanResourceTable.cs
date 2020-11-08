using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COREMVC.Models
{
    public partial class HumanResourceTable
    {
        
        public double? Age { get; set; }
        public string BusinessTravel { get; set; }
        public string Department { get; set; }
        public double? DistanceFromHome { get; set; }
        public string EducationField { get; set; }
        public double? EmployeeNumber { get; set; }
        public string Gender { get; set; }
        public string JobRole { get; set; }
        public string MaritalStatus { get; set; }
        public double? NumCompaniesWorked { get; set; }
        public string OverTime { get; set; }
        public double? TotalWorkingYears { get; set; }
        public double? TrainingTimesLastYear { get; set; }
        public double? YearsAtCompany { get; set; }
        public double? YearsInCurrentRole { get; set; }
        public double? YearsSinceLastPromotion { get; set; }
        public double? YearsWithCurrManager { get; set; }
    }
}
