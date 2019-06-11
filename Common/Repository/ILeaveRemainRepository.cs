using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ILeaveRemainRepository
    {
        List<LeaveRemain> Get();
        LeaveRemain Get(int id);
        bool Insert(LeaveRemainVM leaveRemainVM);
        bool Update(int id, LeaveRemainVM leaveRemainVM);
        bool Delete(int id);
    }
}
