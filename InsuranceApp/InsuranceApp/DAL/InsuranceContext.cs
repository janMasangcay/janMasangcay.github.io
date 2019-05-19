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

        public DbSet<Car> Cars { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}