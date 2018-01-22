namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTache5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taches", "TypeCategorieID", c => c.Int(nullable: false));
            CreateIndex("dbo.Taches", "TypeCategorieID");
            AddForeignKey("dbo.Taches", "TypeCategorieID", "dbo.TypeCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taches", "TypeCategorieID", "dbo.TypeCategories");
            DropIndex("dbo.Taches", new[] { "TypeCategorieID" });
            DropColumn("dbo.Taches", "TypeCategorieID");
        }
    }
}
