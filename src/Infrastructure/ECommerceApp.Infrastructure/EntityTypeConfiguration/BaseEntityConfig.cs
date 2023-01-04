﻿using ECommerceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Infrastructure.EntityTypeConfiguration
{
    public class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.CreateDate).IsRequired(true);
            builder.Property(X => X.DeleteDate).IsRequired(true);
            builder.Property(X => X.UpdateDate).IsRequired(true);
            builder.Property(X => X.Status).IsRequired(true);
        }
    }
}
