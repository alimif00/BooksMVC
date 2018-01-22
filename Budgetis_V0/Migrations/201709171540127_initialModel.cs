namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(nullable: false),
                        Description = c.String(),
                        CategorieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategorieID, cascadeDelete: true)
                .Index(t => t.CategorieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TypeCategories", "CategorieID", "dbo.Categories");
            DropIndex("dbo.TypeCategories", new[] { "CategorieID" });
            DropTable("dbo.TypeCategories");
            DropTable("dbo.Categories");
        }
    }
}
