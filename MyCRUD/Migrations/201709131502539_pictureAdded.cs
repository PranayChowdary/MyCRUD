namespace MyCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pictureAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "picture");
        }
    }
}
