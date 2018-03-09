namespace AspMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Author", c => c.String(nullable: false));
            AlterColumn("dbo.Commentaires", "Author", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Commentaires", "Author", c => c.String());
            AlterColumn("dbo.Articles", "Author", c => c.String());
        }
    }
}
