using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Domain.Admins.Models;
using Prueba.Infrastructure.Cores.Converters;

namespace Prueba.Infrastructure.Admins.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("permission", "adm");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.Slug).HasColumnName("slug");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate")
                .HasConversion(new DateTimeToDateTimeOffset());
            builder.Property(t => t.State).HasColumnName("state");
        }
    }
}

