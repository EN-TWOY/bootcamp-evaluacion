using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Domain.Admins.Models;
using Prueba.Infrastructure.Cores.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Infrastructure.Admins.Configurations
{
    public class RoleMenuPermissionConfiguration : IEntityTypeConfiguration<RoleMenuPermission>
    {
        public void Configure(EntityTypeBuilder<RoleMenuPermission> builder)
        {
            builder.ToTable("rolemenupermission", "adm");

            builder.HasKey(t => t.RoleId);

            builder.Property(t => t.MenuId).HasColumnName("menuid");
            builder.Property(t => t.PermissionId).HasColumnName("permissionid");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate")
                .HasConversion(new DateTimeToDateTimeOffset());
            builder.Property(t => t.State).HasColumnName("state");

            // Relations
            builder.HasOne(a => a.Permission)
                .WithMany(at => at.RoleMenuPermissions)
                .HasForeignKey(a => a.PermissionId);
        }
    }
}
