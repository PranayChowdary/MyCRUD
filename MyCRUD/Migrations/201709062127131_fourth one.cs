namespace MyCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "pictureTmp", c => c.Binary());
            Sql("Update dbo.Users SET pictureTmp = Convert(varbinary, picture )");
            DropColumn("dbo.Users", "picture");
            RenameColumn("dbo.Users", "pictureTmp", "picture");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "picture", c => c.String());
        }
    }
}
