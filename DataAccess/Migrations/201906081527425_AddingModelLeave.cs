namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingModelLeave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Name = c.String(),
                        Role = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDalete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_LeaveRemains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveRequestId = c.Int(nullable: false),
                        UserID = c.String(),
                        Duration = c.Int(nullable: false),
                        Type = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDalete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_LeaveRequests", t => t.LeaveRequestId, cascadeDelete: true)
                .Index(t => t.LeaveRequestId);
            
            CreateTable(
                "dbo.TB_T_LeaveRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveId = c.Int(nullable: false),
                        FromDate = c.DateTimeOffset(nullable: false, precision: 7),
                        EndDate = c.DateTimeOffset(nullable: false, precision: 7),
                        RequestDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Reason = c.String(),
                        RequesterId = c.Int(nullable: false),
                        ApprovalManagerId = c.Int(nullable: false),
                        ApprovalHrdId = c.Int(nullable: false),
                        Attachments = c.String(),
                        Status = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDalete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_LeaveTypes", t => t.LeaveId, cascadeDelete: true)
                .Index(t => t.LeaveId);
            
            CreateTable(
                "dbo.TB_M_LeaveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveName = c.String(),
                        TypeStatus = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDalete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_M_StatusTypeParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusTypeName = c.String(),
                        StatusTypeValue = c.String(),
                        StatusTypeModule = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDalete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_LeaveRemains", "LeaveRequestId", "dbo.TB_T_LeaveRequests");
            DropForeignKey("dbo.TB_T_LeaveRequests", "LeaveId", "dbo.TB_M_LeaveTypes");
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "LeaveId" });
            DropIndex("dbo.TB_T_LeaveRemains", new[] { "LeaveRequestId" });
            DropTable("dbo.TB_M_StatusTypeParams");
            DropTable("dbo.TB_M_LeaveTypes");
            DropTable("dbo.TB_T_LeaveRequests");
            DropTable("dbo.TB_T_LeaveRemains");
            DropTable("dbo.TB_M_Employees");
        }
    }
}
