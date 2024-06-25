using Microsoft.EntityFrameworkCore;

namespace PetPortal.DataAccess;

public class PetPortalDbContext : DbContext
{
    public PetPortalDbContext(DbContextOptions<PetPortalDbContext> options)
        : base(options)
    {
    }

    //dbSets
    
    //CModel configurations 
    protected override void OnModelCreating(ModelBuilder builder)
    {
    }
    
}