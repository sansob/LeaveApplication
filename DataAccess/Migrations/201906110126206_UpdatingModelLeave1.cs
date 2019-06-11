namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModelLeave1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Employees", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_Employees", "Password");
        }
    }
}
