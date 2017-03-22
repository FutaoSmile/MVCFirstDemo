namespace MovieEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class demo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Levels",
                c => new
                    {
                        LevelID = c.Int(nullable: false, identity: true),
                        LevelName = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.LevelID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseTime = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 5),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        level_LevelID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Levels", t => t.level_LevelID)
                .Index(t => t.level_LevelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "level_LevelID", "dbo.Levels");
            DropIndex("dbo.Movies", new[] { "level_LevelID" });
            DropTable("dbo.Movies");
            DropTable("dbo.Levels");
        }
    }
}
