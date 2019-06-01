namespace GL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToPlayerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Players", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Gender", c => c.String());
            AlterColumn("dbo.Players", "Name", c => c.String());
        }
    }
}
