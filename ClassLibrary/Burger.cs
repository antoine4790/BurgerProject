using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("Burgers")]
    public class Burger : Product
    {
        public int Weight { get; set; }
        public int BeefWeight { get; set; }
        

    }
}
