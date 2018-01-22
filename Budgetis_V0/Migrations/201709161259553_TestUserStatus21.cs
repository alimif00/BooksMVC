namespace Budgetis_V0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestUserStatus21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialStatusTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        libelle = c.String(nullable: false),
                        description = c.String(),
                        tax = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 10),
                        DateNaissance = c.DateTime(nullable: false),
                        IsMember = c.Boolean(nullable: false),
                        SocialStatusTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SocialStatusTypes", t => t.SocialStatusTypeId, cascadeDelete: true)
                .Index(t => t.SocialStatusTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTests", "SocialStatusTypeId", "dbo.SocialStatusTypes");
            DropIndex("dbo.UserTests", new[] { "SocialStatusTypeId" });
            DropTable("dbo.UserTests");
            DropTable("dbo.SocialStatusTypes");
        }
    }
}
