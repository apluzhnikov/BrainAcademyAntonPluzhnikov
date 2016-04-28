using DataService.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.EntitiesConfig
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig() {
            HasKey(i => i.Id).Property(i => i.Id).HasColumnName("CustomerId");
            Property(i => i.FirstName).HasMaxLength(180).IsRequired().IsUnicode();
            Property(i => i.LastName).HasMaxLength(180).IsRequired().IsUnicode();
            Property(i => i.PhoneNumber).HasMaxLength(15).IsRequired();
        }
    }
}
