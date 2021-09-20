using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Movement_History
    {
        [Key]
        public Guid Child_ID { get; set; }
        public string Movement_history { get; set; }
        public string Age_Group { get; set; }
        public string Comment { get; set; }
    }
}
