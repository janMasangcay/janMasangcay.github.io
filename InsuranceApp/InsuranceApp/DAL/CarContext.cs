using InsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InsuranceApp.DAL
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarContext")
        {

        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
//Migration Process:
//enable-migrations -ContextTypeName InsuranceApp.DAL.CarContext -MigrationsDirectory:CarContextMigration
//add-migration -configuration InsuranceApp.CarContextMigration.Configuration Initial
////Fresh from remote? Please update database:
//update-database -configuration InsuranceApp.CarContextMigration.Configuration -Verbose