using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("Sides")]
    public class Side : Product
    {
        public int Weight { get; set; }
        public int SaltWeight { get; set; }
        
    }
}
