namespace MobyDickensBookstore2._0.Migrations.MobyDickensBookstore2_0Context
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ISBN = c.Long(nullable: false),
                        Title = c.String(nullable: false, maxLength: 60),
                        Author = c.String(),
                        Date = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
