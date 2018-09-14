namespace RealtorCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_NameMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apartments", "Address", c => c.String());
            AddColumn("dbo.Pictures", "Image", c => c.Binary());
            DropColumn("dbo.Pictures", "Path");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "Path", c => c.String());
            DropColumn("dbo.Pictures", "Image");
            DropColumn("dbo.Apartments", "Address");
        }
    }
}
