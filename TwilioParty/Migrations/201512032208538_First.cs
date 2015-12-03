namespace TwilioParty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prize",
                c => new
                    {
                        PrizeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PrizeId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Message = c.String(),
                        PrizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Prize", t => t.PrizeId, cascadeDelete: true)
                .Index(t => t.PrizeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "PrizeId", "dbo.Prize");
            DropIndex("dbo.User", new[] { "PrizeId" });
            DropTable("dbo.User");
            DropTable("dbo.Prize");
        }
    }
}
