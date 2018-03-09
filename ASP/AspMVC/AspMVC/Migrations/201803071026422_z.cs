namespace AspMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Content", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Commentaires", "Content", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Commentaires", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Articles", "Content", c => c.String(nullable: false));
        }
    }
}
