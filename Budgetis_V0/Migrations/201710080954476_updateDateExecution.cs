namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDateExecution : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Taches", "dateEstimation", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Taches", "dateEstimation", c => c.DateTime(nullable: false));
        }
    }
}
