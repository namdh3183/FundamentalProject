namespace FundamentalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sjhrfd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PACKAGE", "PROLONG", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PACKAGE", "PROLONG");
        }
    }
}
