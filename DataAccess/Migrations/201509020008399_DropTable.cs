namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.OkToDelete");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OkToDelete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeColumn = c.String(),
                        Alex = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
