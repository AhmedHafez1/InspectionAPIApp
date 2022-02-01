﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        public DbSet<Inspection>? Inspections { get; set; }
        public DbSet<InspectionType>? InspectionTypes { get; set; }
        public DbSet<Status>? Statuses { get; set; }
    }
}