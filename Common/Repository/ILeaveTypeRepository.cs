using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ILeaveTypeRepository
    {
        List<LeaveType> Get();
        LeaveType Get(int id);
        bool Insert(LeaveTypeVM leaveTypeVM);
        bool Update(int id, LeaveTypeVM leaveTypeVM);
        bool Delete(int id);
    }
}
