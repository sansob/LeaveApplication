using DataAccess.Models;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface ILeaveTypeService
    {
        List<LeaveType> Get();
        List<LeaveType> GetSearch(string values);
        LeaveType Get(int id);
        bool Insert(LeaveTypeVM leaveTypeVM);
        bool Update(int id, LeaveTypeVM leaveTypeVM);
        bool Delete(int id); 
    }
}
