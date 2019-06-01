namespace GL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGamePropertiesRetry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        Distributor = c.String(),
                        ReleaseYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
