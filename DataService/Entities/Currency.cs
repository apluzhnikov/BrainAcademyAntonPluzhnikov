using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
    //[Table("Currency", Shema = "dbo")]
    public class Currency
    {
        public Currency() {
            Products = new HashSet<Product>();
        }

        /*[Key]
        [Column("CurrencyId")]*/
        public int Id { get; set; }

        /*[Required]
        [MaxLength(3)]
        [Index(IsUnique = true)]*/
        public string Name { get; set; }

        //[Column(TypeName = "money")]
        public decimal Rate { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
