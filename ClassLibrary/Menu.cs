using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Table("Menus")]
    public class Menu : Product
    {
        [Required]
        public virtual Beverage Beverage { get; set; }
        [Required]
        public virtual Side Side { get; set; }

        public virtual Dessert Dessert { get; set; }
        [Required]
        public virtual Burger Burger { get; set; }
    }
}
