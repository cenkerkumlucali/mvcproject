using System.Data.Entity.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriterId", c => c.Int());
            CreateIndex("dbo.Contents", "WriterId");
            AddForeignKey("dbo.Contents", "WriterId", "dbo.Writers", "WriterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriterId", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterId" });
            DropColumn("dbo.Contents", "WriterId");
        }
    }
}
