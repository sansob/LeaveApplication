namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setNull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Leave_Id", "dbo.TB_M_LeaveTypes");
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Status_Id", "dbo.TB_M_StatusTypeParams");
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Leave_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalManager_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalHrd_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Status_Id" });
            AlterColumn("dbo.TB_T_LeaveRequests", "Leave_Id", c => c.Int());
            AlterColumn("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", c => c.Int());
            AlterColumn("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", c => c.Int());
            AlterColumn("dbo.TB_T_LeaveRequests", "Status_Id", c => c.Int());
            CreateIndex("dbo.TB_T_LeaveRequests", "Leave_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "ApprovalManager_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "Status_Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", "dbo.TB_M_Employees", "Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "Leave_Id", "dbo.TB_M_LeaveTypes", "Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", "dbo.TB_M_Employees", "Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "Status_Id", "dbo.TB_M_StatusTypeParams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_LeaveRequests", "Status_Id", "dbo.TB_M_StatusTypeParams");
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Leave_Id", "dbo.TB_M_LeaveTypes");
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", "dbo.TB_M_Employees");
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Status_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalHrd_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalManager_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Leave_Id" });
            AlterColumn("dbo.TB_T_LeaveRequests", "Status_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.TB_T_LeaveRequests", "Leave_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_T_LeaveRequests", "Status_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "ApprovalManager_Id");
            CreateIndex("dbo.TB_T_LeaveRequests", "Leave_Id");
            AddForeignKey("dbo.TB_T_LeaveRequests", "Status_Id", "dbo.TB_M_StatusTypeParams", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", "dbo.TB_M_Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_LeaveRequests", "Leave_Id", "dbo.TB_M_LeaveTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", "dbo.TB_M_Employees", "Id", cascadeDelete: true);
        }
    }
}
