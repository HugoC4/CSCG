namespace CSCG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnParameter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Methods", "Return_ParemetedId", c => c.Int());
            CreateIndex("dbo.Methods", "Return_ParemetedId");
            AddForeignKey("dbo.Methods", "Return_ParemetedId", "dbo.Parameters", "ParemetedId");
            DropColumn("dbo.Methods", "ReturnTypeNamespace");
            DropColumn("dbo.Methods", "ReturnTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Methods", "ReturnTypeName", c => c.String());
            AddColumn("dbo.Methods", "ReturnTypeNamespace", c => c.String());
            DropForeignKey("dbo.Methods", "Return_ParemetedId", "dbo.Parameters");
            DropIndex("dbo.Methods", new[] { "Return_ParemetedId" });
            DropColumn("dbo.Methods", "Return_ParemetedId");
        }
    }
}
