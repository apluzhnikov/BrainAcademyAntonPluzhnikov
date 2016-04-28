using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.EntitiesConfig
{
    class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig() {
            HasKey(i => i.Id).Property(i => i.Id).HasColumnName("ProductId");
            Property(i => i.Name).HasMaxLength(180).IsRequired();//.IsUnicode()
            Property(i => i.Price).HasColumnType("money");
        }
    }
}
