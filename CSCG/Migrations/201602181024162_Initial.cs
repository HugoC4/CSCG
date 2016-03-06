namespace CSCG.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsAbstract = c.Boolean(nullable: false),
                        Accessibility = c.Int(nullable: false),
                        Extends_ClassId = c.Int(),
                        Namespace_NamespaceId = c.Int(),
                        Namespace_NamespaceId1 = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Classes", t => t.Extends_ClassId)
                .ForeignKey("dbo.Namespaces", t => t.Namespace_NamespaceId)
                .ForeignKey("dbo.Namespaces", t => t.Namespace_NamespaceId1)
                .Index(t => t.Extends_ClassId)
                .Index(t => t.Namespace_NamespaceId)
                .Index(t => t.Namespace_NamespaceId1);
            
            CreateTable(
                "dbo.Constructors",
                c => new
                    {
                        ConstructorId = c.Int(nullable: false, identity: true),
                        Accessibility = c.Int(nullable: false),
                        Class_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.ConstructorId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.Class_ClassId);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        FieldId = c.Int(nullable: false, identity: true),
                        TypeNamespace = c.String(),
                        TypeName = c.String(),
                        ReadOnly = c.Boolean(nullable: false),
                        Accessibility = c.Int(nullable: false),
                        Class_ClassId = c.Int(),
                        Interface_InterfaceId = c.Int(),
                    })
                .PrimaryKey(t => t.FieldId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .ForeignKey("dbo.Interfaces", t => t.Interface_InterfaceId)
                .Index(t => t.Class_ClassId)
                .Index(t => t.Interface_InterfaceId);
            
            CreateTable(
                "dbo.Interfaces",
                c => new
                    {
                        InterfaceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Accessibility = c.Int(nullable: false),
                        Interface_InterfaceId = c.Int(),
                        Namespace_NamespaceId = c.Int(),
                        Namespace_NamespaceId1 = c.Int(),
                        Class_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.InterfaceId)
                .ForeignKey("dbo.Interfaces", t => t.Interface_InterfaceId)
                .ForeignKey("dbo.Namespaces", t => t.Namespace_NamespaceId)
                .ForeignKey("dbo.Namespaces", t => t.Namespace_NamespaceId1)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.Interface_InterfaceId)
                .Index(t => t.Namespace_NamespaceId)
                .Index(t => t.Namespace_NamespaceId1)
                .Index(t => t.Class_ClassId);
            
            CreateTable(
                "dbo.Methods",
                c => new
                    {
                        MethodId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReturnTypeNamespace = c.String(),
                        ReturnTypeName = c.String(),
                        Accessibility = c.Int(nullable: false),
                        Class_ClassId = c.Int(),
                        Interface_InterfaceId = c.Int(),
                    })
                .PrimaryKey(t => t.MethodId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .ForeignKey("dbo.Interfaces", t => t.Interface_InterfaceId)
                .Index(t => t.Class_ClassId)
                .Index(t => t.Interface_InterfaceId);
            
            CreateTable(
                "dbo.Namespaces",
                c => new
                    {
                        NamespaceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent_NamespaceId = c.Int(),
                        Interface_InterfaceId = c.Int(),
                        Class_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.NamespaceId)
                .ForeignKey("dbo.Namespaces", t => t.Parent_NamespaceId)
                .ForeignKey("dbo.Interfaces", t => t.Interface_InterfaceId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.Parent_NamespaceId)
                .Index(t => t.Interface_InterfaceId)
                .Index(t => t.Class_ClassId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false),
                        Title = c.String(),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        DefaultAccessibility = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Namespaces", t => t.ProjectId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        TypeNamespace = c.String(),
                        TypeName = c.String(),
                        IsAutoProperty = c.Boolean(nullable: false),
                        ReadOnly = c.Boolean(nullable: false),
                        Accessibility = c.Int(nullable: false),
                        Class_ClassId = c.Int(),
                        Interface_InterfaceId = c.Int(),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .ForeignKey("dbo.Interfaces", t => t.Interface_InterfaceId)
                .Index(t => t.Class_ClassId)
                .Index(t => t.Interface_InterfaceId);
            
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        ParemetedId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TypeNamespace = c.String(),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ParemetedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Namespaces", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Namespace_NamespaceId1", "dbo.Namespaces");
            DropForeignKey("dbo.Interfaces", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Namespaces", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Properties", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Properties", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Interfaces", "Namespace_NamespaceId1", "dbo.Namespaces");
            DropForeignKey("dbo.Projects", "ProjectId", "dbo.Namespaces");
            DropForeignKey("dbo.Namespaces", "Parent_NamespaceId", "dbo.Namespaces");
            DropForeignKey("dbo.Interfaces", "Namespace_NamespaceId", "dbo.Namespaces");
            DropForeignKey("dbo.Classes", "Namespace_NamespaceId", "dbo.Namespaces");
            DropForeignKey("dbo.Methods", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Methods", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Interfaces", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Fields", "Interface_InterfaceId", "dbo.Interfaces");
            DropForeignKey("dbo.Fields", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Extends_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Constructors", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Properties", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Properties", new[] { "Class_ClassId" });
            DropIndex("dbo.Projects", new[] { "ProjectId" });
            DropIndex("dbo.Namespaces", new[] { "Class_ClassId" });
            DropIndex("dbo.Namespaces", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Namespaces", new[] { "Parent_NamespaceId" });
            DropIndex("dbo.Methods", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Methods", new[] { "Class_ClassId" });
            DropIndex("dbo.Interfaces", new[] { "Class_ClassId" });
            DropIndex("dbo.Interfaces", new[] { "Namespace_NamespaceId1" });
            DropIndex("dbo.Interfaces", new[] { "Namespace_NamespaceId" });
            DropIndex("dbo.Interfaces", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Fields", new[] { "Interface_InterfaceId" });
            DropIndex("dbo.Fields", new[] { "Class_ClassId" });
            DropIndex("dbo.Constructors", new[] { "Class_ClassId" });
            DropIndex("dbo.Classes", new[] { "Namespace_NamespaceId1" });
            DropIndex("dbo.Classes", new[] { "Namespace_NamespaceId" });
            DropIndex("dbo.Classes", new[] { "Extends_ClassId" });
            DropTable("dbo.Parameters");
            DropTable("dbo.Properties");
            DropTable("dbo.Projects");
            DropTable("dbo.Namespaces");
            DropTable("dbo.Methods");
            DropTable("dbo.Interfaces");
            DropTable("dbo.Fields");
            DropTable("dbo.Constructors");
            DropTable("dbo.Classes");
        }
    }
}
