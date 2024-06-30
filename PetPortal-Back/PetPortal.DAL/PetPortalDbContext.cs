using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using PetPortal.DAL.Configurations;
using PetPortal.DAL.Entities;

namespace PetPortal.DAL;

public class PetPortalDbContext : DbContext
{
    public PetPortalDbContext(DbContextOptions<PetPortalDbContext> options) 
        : base(options) 
    {
    }
    
    public DbSet<ProjectEntity> Projects { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProjectConfigurations());
    }
}