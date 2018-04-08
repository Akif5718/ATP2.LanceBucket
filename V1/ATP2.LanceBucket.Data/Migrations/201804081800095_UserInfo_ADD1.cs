namespace ATP2.LanceBucket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInfo_ADD1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfoes", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfoes", "Email", c => c.String());
        }
    }
}
