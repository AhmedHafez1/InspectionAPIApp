using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }
        public DbSet<Inspection>? Inspections { get; set; }
        public DbSet<InspectionType>? InspectionTypes { get; set; }
        public DbSet<Status>? Statuses { get; set; }
    }
}