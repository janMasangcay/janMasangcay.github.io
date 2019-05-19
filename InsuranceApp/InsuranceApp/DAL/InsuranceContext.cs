using InsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InsuranceApp.DAL
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext() : base("InsuranceContext") { }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Quotes> Quotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}