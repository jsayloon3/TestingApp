using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TestingApp.Models
{
    public class TestAppRecord
    {
        public int Id { get; set; }
        [Display(Name = "Issue Number")]
        public int Issue_Number { get; set; }
        [Display(Name = "Client Name")]
        public string Client_Name { get; set; }
        [Display(Name = "Issue Type")]
        public int Issue_Type { get; set; }
        [Display(Name = "Assigned Developer")]
        public string Assigned_Developer { get; set; }
        [Display(Name = "Assigned Tester")]
        public string Assigned_Tester { get; set; }
        [Display(Name = "Cycle Count")]
        public int Cycle_Count { get; set; }
        [Display(Name = "Date Per Cycle Count")]
        public DateTime Date_Per_Cycle_Count { get; set; }
        [Display(Name = "Release Date")]
        public DateTime Release_Date { get; set; }
        [Display(Name = "Status")]
        public int Status { get; set; }
    }
}
