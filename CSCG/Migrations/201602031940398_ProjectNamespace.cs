namespace CSCG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectNamespace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Namespace", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Namespace");
        }
    }
}
