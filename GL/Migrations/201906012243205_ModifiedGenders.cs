namespace GL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedGenders : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "PlayerGender", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Gender", c => c.String(nullable: false));
            DropColumn("dbo.Players", "PlayerGender");
        }
    }
}
