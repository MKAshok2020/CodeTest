// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Plano.Models
{
    // ExchangeRates
    public class ExchangeRateConfiguration : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.ToTable("ExchangeRates", "dbo");
            builder.HasKey(x => x.Erid).HasName("PK_ExchangeRates").IsClustered();

            builder.Property(x => x.Erid).HasColumnName(@"ERID").HasColumnType("bigint").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.CurrencyCode).HasColumnName(@"CurrencyCode").HasColumnType("nvarchar(50)").IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.ExchangeRates).HasColumnName(@"ExchangeRates").HasColumnType("decimal(12,6)")
                //.HasPrecision(12,6)
                .IsRequired(false);
            builder.Property(x => x.IsDefault).HasColumnName(@"IsDefault").HasColumnType("bit").IsRequired(false);
        }
    }

}
// </auto-generated>
