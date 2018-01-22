namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTache : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taches", "libelle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Taches", "libelle");
        }
    }
}
