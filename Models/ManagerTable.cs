using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COREMVC.Models
{
    public partial class ManagerTable
    {
        
        public string Attrition { get; set; }
        public double? DailyRate { get; set; }
        public string Department { get; set; }
        public double? EmployeeCount { get; set; }
        public double? EmployeeNumber { get; set; }
        public double? HourlyRate { get; set; }
        public double? JobInvolvement { get; set; }
        public string JobRole { get; set; }
        public double? MonthlyIncome { get; set; }
        public double? MonthlyRate { get; set; }
        public string OverTime { get; set; }
        public double? PercentSalaryHike { get; set; }
        public double? PerformanceRating { get; set; }
        public double? StandardHours { get; set; }
    }
}
