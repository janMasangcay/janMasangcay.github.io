namespace InsuranceApp.CarContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Car");
        }
    }
}
