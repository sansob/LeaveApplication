namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_Employees", "CreateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_Employees", "UpdateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_Employees", "DeleteDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "CreateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "UpdateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "DeleteDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "CreateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "UpdateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "DeleteDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "CreateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "UpdateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "DeleteDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_StatusTypeParams", "CreateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_StatusTypeParams", "UpdateDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.TB_M_StatusTypeParams", "DeleteDate", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_StatusTypeParams", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_StatusTypeParams", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_StatusTypeParams", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_LeaveTypes", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRequests", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_T_LeaveRemains", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Employees", "DeleteDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Employees", "UpdateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.TB_M_Employees", "CreateDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
