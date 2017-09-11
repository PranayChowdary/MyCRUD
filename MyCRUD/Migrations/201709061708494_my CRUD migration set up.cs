namespace MyCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myCRUDmigrationsetup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "phoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "phoneNumber", c => c.Int(nullable: false));
        }
    }
}
