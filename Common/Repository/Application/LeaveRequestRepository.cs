using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.MyContext;

namespace Common.Repository.Application
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<LeaveRequest> Get()
        {
            throw new NotImplementedException();
        }

        public LeaveRequest Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<LeaveRequest> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LeaveRequestVM leaveRequestVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, LeaveRequestVM leaveRequest)
        {
            throw new NotImplementedException();
        }
    }
}
