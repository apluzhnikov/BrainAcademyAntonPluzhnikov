using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.EntitiesConfig
{
    class CurrencyConfig : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfig() {
            HasKey(i => i.Id).Property(i => i.Id).HasColumnName("CurrencyId");
            Property(i => i.Name).HasMaxLength(3).IsRequired();//.IsUnicode()
            Property(i => i.Rate).HasColumnType("money");
        }
    }
}
