using JwtApp.Back.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtApp.Back.Persistance.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasOne(x=>x.AppRole).WithMany(x=>x.AppUsers).HasForeignKey(x=>x.AppRoleId);
        }
    }
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {   
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(X => X.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
        }
    }
}
