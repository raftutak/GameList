namespace GL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenderToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Gender");
        }
    }
}
