using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Absences
    {
        [Key]
        public Guid Child_ID { get; set; }
        public string Reason { get; set; }
        public DateTime Work_Start { get; set; }
        public DateTime Work_End { get; set; }
        public string Comment { get; set; }
    }
}
