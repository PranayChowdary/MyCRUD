namespace MyCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileDataRplcdPic : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "picture", c => c.Binary());
        }
    }
}
