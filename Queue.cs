using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Queue
    {
        [Key]
        public string Child_ID { get; set}
        public int Number { get; set}
        public string Comment { get; set}
    }
}
