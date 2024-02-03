using Microsoft.EntityFrameworkCore;
using ProjectService.Models.Entities;

namespace ProjectService.Data;

public class ProjectDbContext : DbContext
{
    public ProjectDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
