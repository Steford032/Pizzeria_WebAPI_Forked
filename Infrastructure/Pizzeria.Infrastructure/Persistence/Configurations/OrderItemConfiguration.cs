﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Infrastructure.Persistence.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(orderItem => orderItem.Id);
        builder.Property(orderItem => orderItem.TotalPrice);
        builder.Property(orderItem => orderItem.Price);
        builder.Property(orderItem => orderItem.Quantity);
        builder.HasOne(orderItem => orderItem.Product);
        builder.HasOne(orderItem => orderItem.Order);
    }
}