using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Parent
    {
        [Key]
        public string FirstName { get;set }
        public string LastName { get; set; }
        public string Identification_code { get; set; }
        public string Contact_Adress { get; set; }
        public int Phone_number { get; set; }
        public string Contact_email { get; set; }
        public int age { get; set; }
        public string Gender { get; set; }
        public string Child_ID { get; set; }
        public string Comment { get; set; }
    }
}
