using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.View_Models;

namespace BusinessLogic.Service.Application
{
    public class LeaveTypeService : ILeaveTypeService
    {
        bool status = false;

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<LeaveType> Get()
        {
            throw new NotImplementedException();
        }

        public LeaveType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<LeaveType> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LeaveTypeVM leaveTypeVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, LeaveTypeVM leaveTypeVM)
        {
            throw new NotImplementedException();
        }
    }
}
