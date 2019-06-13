namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_T_LeaveRequests", "Requester_Id", "dbo.TB_M_Employees");
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Requester_Id" });
            AlterColumn("dbo.TB_T_LeaveRequests", "Requester_Id", c => c.Int());
            CreateIndex("dbo.TB_T_LeaveRequests", "Requester_Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "Requester_Id", "dbo.TB_M_Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_LeaveRequests", "Requester_Id", "dbo.TB_M_Employees");
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Requester_Id" });
            AlterColumn("dbo.TB_T_LeaveRequests", "Requester_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_T_LeaveRequests", "Requester_Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "Requester_Id", "dbo.TB_M_Employees", "Id", cascadeDelete: true);
        }
    }
}
