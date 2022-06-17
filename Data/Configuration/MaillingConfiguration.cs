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
    public class MaillingConfiguration : IEntityTypeConfiguration<Mailling>
    {
        public void Configure(EntityTypeBuilder<Mailling> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.HasIndex(x=>x.Id);
            builder.Property(x => x.PersonnelId).IsRequired(false);
            builder.Property(x=>x.DepartmentId).IsRequired(false);
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate).IsRequired(false);
        }
    }
}
