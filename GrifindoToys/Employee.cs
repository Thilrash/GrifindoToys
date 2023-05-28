namespace GrifindoToys
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public decimal? MonthlySalary { get; set; }

        public decimal? OverTimeRatesHourly { get; set; }

        public decimal? Allowances { get; set; }

        public decimal? TwoMonthsSalary { get; set; }

        public decimal? NoPayValue { get; set; }

        public decimal? BasePayValue { get; set; }

        public decimal? GrossPay { get; set; }

        public int? DateRange { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BeginDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public int? NoOfLeaves { get; set; }
    }
}
