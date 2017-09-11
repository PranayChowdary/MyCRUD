namespace MyCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "picture", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "picture", c => c.Binary());
        }
    }
}
