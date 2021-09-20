using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Job
    {
        [Key]
        public string Job_title { get; set; }
        public string Comment { get; set; }
    }
}
