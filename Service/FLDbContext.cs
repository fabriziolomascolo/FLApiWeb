using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FLApiWeb.Models;

namespace FLApiWeb.Service
{
    public class FLDbContext: DbContext
    {
        public FLDbContext() : base("name=FLDbContext")
        // Entities        
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<FLDbContext, FLApiWeb.Migrations.Configuration>("FLDbContext"));
        }

        public DbSet<Terapie> Terapie { get; set; }
        public DbSet<Patologie> Patologie { get; set; }
        public DbSet<TerapiaPatologie> TerapiaPatologie { get; set; }
        public DbSet<PatologiaTerapie> PatologiaTerapie { get; set; }
    }
}