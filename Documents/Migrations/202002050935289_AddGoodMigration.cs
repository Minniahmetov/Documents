namespace Documents.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGoodMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goods", "balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goods", "balance");
        }
    }
}
