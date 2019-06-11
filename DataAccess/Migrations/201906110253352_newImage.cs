namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newImage : DbMigration
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
                        Password = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_LeaveRemains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveRequest_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Employees", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_T_LeaveRequests", t => t.LeaveRequest_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_StatusTypeParams", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.LeaveRequest_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.TB_T_LeaveRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Leave_Id = c.Int(nullable: false),
                        Requester_Id = c.Int(nullable: false),
                        ApprovalManager_Id = c.Int(nullable: false),
                        ApprovalHrd_Id = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        FromDate = c.DateTimeOffset(nullable: false, precision: 7),
                        EndDate = c.DateTimeOffset(nullable: false, precision: 7),
                        RequestDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Reason = c.String(),
                        Attachments = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Employees", t => t.ApprovalHrd_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_LeaveTypes", t => t.Leave_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_Employees", t => t.ApprovalManager_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_Employees", t => t.Requester_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_StatusTypeParams", t => t.Status, cascadeDelete: false)
                .Index(t => t.Leave_Id)
                .Index(t => t.Requester_Id)
                .Index(t => t.ApprovalManager_Id)
                .Index(t => t.ApprovalHrd_Id)
                .Index(t => t.Status);
            
            CreateTable(
                "dbo.TB_M_LeaveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeaveName = c.String(),
                        StatusTypeParam_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_StatusTypeParams", t => t.StatusTypeParam_Id, cascadeDelete: true)
                .Index(t => t.StatusTypeParam_Id);
            
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
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_LeaveRemains", "Type_Id", "dbo.TB_M_StatusTypeParams");
            DropForeignKey("dbo.TB_T_LeaveRemains", "LeaveRequest_Id", "dbo.TB_T_LeaveRequests");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Status", "dbo.TB_M_StatusTypeParams");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Requester_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalManager_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRequests", "Leave_Id", "dbo.TB_M_LeaveTypes");
            DropForeignKey("dbo.TB_M_LeaveTypes", "StatusTypeParam_Id", "dbo.TB_M_StatusTypeParams");
            DropForeignKey("dbo.TB_T_LeaveRequests", "ApprovalHrd_Id", "dbo.TB_M_Employees");
            DropForeignKey("dbo.TB_T_LeaveRemains", "User_Id", "dbo.TB_M_Employees");
            DropIndex("dbo.TB_M_LeaveTypes", new[] { "StatusTypeParam_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Status" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalHrd_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "ApprovalManager_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Requester_Id" });
            DropIndex("dbo.TB_T_LeaveRequests", new[] { "Leave_Id" });
            DropIndex("dbo.TB_T_LeaveRemains", new[] { "Type_Id" });
            DropIndex("dbo.TB_T_LeaveRemains", new[] { "User_Id" });
            DropIndex("dbo.TB_T_LeaveRemains", new[] { "LeaveRequest_Id" });
            DropTable("dbo.TB_M_StatusTypeParams");
            DropTable("dbo.TB_M_LeaveTypes");
            DropTable("dbo.TB_T_LeaveRequests");
            DropTable("dbo.TB_T_LeaveRemains");
            DropTable("dbo.TB_M_Employees");
        }
    }
}
