using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("Beverages")]
    public class Beverage :Product
    {
        public double millimiter { get; set; }
        public bool isCarbonated { get; set; }

        
    }
}
