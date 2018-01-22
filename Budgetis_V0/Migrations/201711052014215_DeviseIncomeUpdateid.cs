namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeviseIncomeUpdateid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devises",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Description = c.String(),
                        Value = c.Double(nullable: false),
                        IsSelected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Incomes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IncomeValue = c.Double(nullable: false),
                        DeviseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Devises", t => t.DeviseID, cascadeDelete: true)
                .Index(t => t.DeviseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Incomes", "DeviseID", "dbo.Devises");
            DropIndex("dbo.Incomes", new[] { "DeviseID" });
            DropTable("dbo.Incomes");
            DropTable("dbo.Devises");
        }
    }
}
