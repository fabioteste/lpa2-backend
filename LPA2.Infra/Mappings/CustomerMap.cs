﻿using System.Data.Entity.ModelConfiguration;
using LPA2.Domain.Entities;

namespace LPA2.Infra.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.BirthDate);
            Property(x => x.Document.Number).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.Address).IsRequired().HasMaxLength(160);
            Property(x => x.Name.FirstName).IsRequired().HasMaxLength(60);
            Property(x => x.Name.LastName).IsRequired().HasMaxLength(60);
            Property(x => x.User.Username).IsRequired().HasMaxLength(20);
            Property(x => x.User.Password).IsRequired().HasMaxLength(32).IsFixedLength();
            Property(x => x.User.Password);
            Property(x => x.User.Active);
        }
    }
}
