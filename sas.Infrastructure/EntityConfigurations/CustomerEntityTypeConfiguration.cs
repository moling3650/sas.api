using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sas.Domain.CustomerAggregate;

namespace sas.Infrastructure.EntityConfigurations
{
    class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("customer");
            builder.Property(p => p.PhoneNo).HasMaxLength(20);
            builder.OwnsOne(o => o.Address, a =>
            {
                a.WithOwner();
                a.Property(p => p.Province).HasMaxLength(20);
                a.Property(p => p.City).HasMaxLength(20);
            });
        }
    }
}
