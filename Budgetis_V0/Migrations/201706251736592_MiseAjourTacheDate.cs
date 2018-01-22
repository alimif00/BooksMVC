namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MiseAjourTacheDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taches", "dateEstimation", c => c.DateTime(nullable: false));
            AddColumn("dbo.Taches", "dateExecution", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taches", "dateExecution");
            DropColumn("dbo.Taches", "dateEstimation");
        }
    }
}
