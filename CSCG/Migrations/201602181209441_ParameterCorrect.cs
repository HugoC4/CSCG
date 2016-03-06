namespace CSCG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParameterCorrect : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "NamespaceGen", c => c.String());
            AddColumn("dbo.Parameters", "ClassCustom", c => c.String());
            AddColumn("dbo.Parameters", "Class_ClassId", c => c.Int());
            AddColumn("dbo.Parameters", "Interface_InterfaceId", c => c.Int());
            AddColumn("dbo.Parameters", "Namespace_NamespaceId", c => c.Int());
            CreateIndex("dbo.Parameters", "Class_ClassId");
            CreateIndex("dbo.Parameters", "Interface_InterfaceId");
            CreateIndex("dbo.Parameters", "Namespace_NamespaceId");
            AddForeignKey("dbo.Parameters", "Class_ClassId", "dbo.Classes", "ClassId");
            AddForeignKey("dbo.Parameters", "Interface_InterfaceId", "dbo.Interfaces", "InterfaceId");
            AddForeignKey("dbo.Parameters", "Namespace_NamespaceId", "dbo.Namespaces", "NamespaceId");
            DropColumn("dbo.Parameters", "TypeNamespace");
            DropColumn("dbo.Parameters", "TypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Parameters", "TypeName", c => c.String());
            AddColumn("dbo.Parameters", "TypeNamespace", c => c.String());
            DropForeignKey("dbo.Parameters", "Namespace_NamespaceId", "dbo.Namespaces");
            DropForeignKey("dbo.Parameters", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Parameters", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Parameters", new[] { "Namespace_NamespaceId" });
            DropIndex("dbo.Parameters", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Parameters", new[] { "Class_ClassId" });
            DropColumn("dbo.Parameters", "Namespace_NamespaceId");
            DropColumn("dbo.Parameters", "Interface_InterfaceId");
            DropColumn("dbo.Parameters", "Class_ClassId");
            DropColumn("dbo.Parameters", "ClassCustom");
            DropColumn("dbo.Parameters", "NamespaceGen");
        }
    }
}
