using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MyContext
{
    class MyContext : DbContext
    {
        public MyContext() : base("MyContext") { }

        public DbSet<Employee> employees { get; set; }
        public DbSet<StatusTypeParam> statusTypeParams { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }
        public DbSet<LeaveRequest> leaveRequests { get; set; }
        public DbSet<LeaveRemain> leaveRemains { get; set; }
    }
}
