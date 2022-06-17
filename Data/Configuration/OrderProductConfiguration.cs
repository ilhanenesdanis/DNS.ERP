﻿using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProducts>
    {
        public void Configure(EntityTypeBuilder<OrderProducts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.ProductId, x.OrderId, x.Id });
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate).IsRequired(false);
        }
    }
}
