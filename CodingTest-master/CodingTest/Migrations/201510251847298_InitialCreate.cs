namespace CodingTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Readings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Depth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MagX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MagY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxZ = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Readings");
        }
    }
}
