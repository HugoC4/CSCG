namespace CSCG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassModelTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fields", "TypeNamespace", c => c.String());
            AddColumn("dbo.Methods", "ReturnTypeNamespace", c => c.String());
            AddColumn("dbo.Properties", "TypeNamespace", c => c.String());
            AddColumn("dbo.Parameters", "TypeNamespace", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "TypeNamespace");
            DropColumn("dbo.Properties", "TypeNamespace");
            DropColumn("dbo.Methods", "ReturnTypeNamespace");
            DropColumn("dbo.Fields", "TypeNamespace");
        }
    }
}
