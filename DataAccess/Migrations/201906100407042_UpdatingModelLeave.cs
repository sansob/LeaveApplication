namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModelLeave : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_LeaveTypes", "LeaveTypeParams", c => c.String());
            DropColumn("dbo.TB_M_LeaveTypes", "TypeStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_LeaveTypes", "TypeStatus", c => c.String());
            DropColumn("dbo.TB_M_LeaveTypes", "LeaveTypeParams");
        }
    }
}
