using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Kitchen
    {
        [Key]
        public string Menu_ID { get; set}
        public string Group_ID { get; set}
        public string Comment { get; set; }
    }
}
