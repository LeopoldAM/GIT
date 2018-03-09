namespace AspMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class l : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Commentaires", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Commentaires", "Content", c => c.String());
            AlterColumn("dbo.Articles", "Content", c => c.String());
        }
    }
}
