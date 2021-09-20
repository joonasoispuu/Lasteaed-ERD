using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Child
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group_ID { get; set; }
        public int Identification_Code { get; set; }
        public int Phone_Number { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Comment { get; set; }
        public string Parent_ID { get; set; }

    }
}
