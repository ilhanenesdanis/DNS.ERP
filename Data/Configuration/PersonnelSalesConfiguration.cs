using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class PersonnelSalesConfiguration : IEntityTypeConfiguration<PersonnelSales>
    {
        public void Configure(EntityTypeBuilder<PersonnelSales> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.OrderId, x.SalesId, x.PersonnelId, x.Id });
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x=>x.OrderId).IsRequired(false);
            builder.Property(x=>x.SalesId).IsRequired(false);
        }
    }
}
