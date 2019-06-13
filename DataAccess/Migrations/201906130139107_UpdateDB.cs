namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_T_LeaveRequests", name: "Status", newName: "Status_Id");
            RenameIndex(table: "dbo.TB_T_LeaveRequests", name: "IX_Status", newName: "IX_Status_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.TB_T_LeaveRequests", name: "IX_Status_Id", newName: "IX_Status");
            RenameColumn(table: "dbo.TB_T_LeaveRequests", name: "Status_Id", newName: "Status");
        }
    }
}
