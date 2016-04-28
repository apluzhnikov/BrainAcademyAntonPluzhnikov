using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
    public class Product
    {
        /*[Key]
        [Column("ProductId")]*/
        public int Id { get; set; }

        /*[Required]
        [MaxLength(180)]*/
        public string Name { get; set; }

        //[Column(TypeName = "money")]
        public decimal? Price { get; set; }

        //public virtual Currency Currency { get; set; } //special for lazy loading     

        //public virtual ICollection<Customer> Customers { get; set; }

        public virtual ICollection<CustomersProducts> CustomersProducts { get; set; }
    }
}
