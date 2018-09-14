namespace RealtorCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_NameMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "DatePurchase", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "DatePurchase");
        }
    }
}
