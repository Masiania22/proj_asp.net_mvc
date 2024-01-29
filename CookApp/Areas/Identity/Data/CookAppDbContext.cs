using CookApp.Areas.Identity.Data;
using CookApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookApp.Areas.Identity.Data;

public class CookAppDbContext : IdentityDbContext<CookAppUser>
{
    public CookAppDbContext(DbContextOptions<CookAppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationEntityConfiguration());
    }
    public DbSet<Recipe> Recipes { get; set; }
}

public class ApplicationEntityConfiguration : IEntityTypeConfiguration<CookAppUser>
{
    public void Configure(EntityTypeBuilder<CookAppUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(100);
        builder.Property(x => x.LastName).HasMaxLength(100);
    }
}