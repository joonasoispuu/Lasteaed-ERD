using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Personal_identification_code { get; set; }
        public string Employee_address { get; set; }
        public string Employee_Phone { get; set; }
        public string Employee_email { get; set; }
        public DateTime Work_start { get; set; }
        public DateTime Work_end { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Comment { get; set; }
        public Guid Job_ID { get; set; }
    }
}