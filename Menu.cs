using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    class Menu
    {
        [Key]
        public string menu { get; set; }
        public int Portions { get; set; }
        public string Dish { get; set; }
        public DateTime Date { get; set; }


    }
}
