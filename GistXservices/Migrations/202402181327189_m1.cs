namespace GistXservices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Gists", "Description");
            DropColumn("dbo.Gists", "fileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gists", "fileName", c => c.String());
            AddColumn("dbo.Gists", "Description", c => c.String());
        }
    }
}
