namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDatesFacultatives : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Taches", "dateExecution", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Taches", "dateExecution", c => c.DateTime(nullable: false));
        }
    }
}
