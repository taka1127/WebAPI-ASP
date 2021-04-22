namespace WebApiSample01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteCreateAtAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "CreateAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "CreateAt");
        }
    }
}
