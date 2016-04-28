using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.EntitiesConfig
{
    public class CustomersProductsConfig : EntityTypeConfiguration<CustomersProducts>
    {
        public CustomersProductsConfig() {
            HasKey(
                key => new {
                    key.CustomerId,
                    key.ProductId
                });
            Property(i => i.Qty).HasColumnType("int");
        }
    }
}
