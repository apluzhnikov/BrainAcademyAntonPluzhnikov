using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
    public class CustomersProducts
    {
        //[Key, Column(Order = 0)]
        public int ProductId { get; set; }

        //[Key, Column(Order = 1)]
        public int CustomerId { get; set; }

        //[Column(TypeName = "int")]
        public int Qty { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
