using DataAccess.Models;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface ILeaveRemainService
    {
        List<LeaveRemain> Get();
        List<LeaveRemain> GetSearch(string values);
        LeaveRemain get(int id);
        bool Insert(int id);
        bool Update(int id, LeaveRemainVM leaveRemainVM);
        bool Delete(int id);    
    }
}
