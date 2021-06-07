using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("Desserts")]
    public class Dessert :Product
    {
        public double millimeter { get; set; }

        public bool isFrozen { get; set; }
        
    }
}
