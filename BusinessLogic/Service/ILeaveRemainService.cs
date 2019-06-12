using DataAccess.Models;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Service {
    public interface ILeaveRemainService {
        List<LeaveRemain> Get();
        LeaveRemain get(int id);
        bool Insert(LeaveRemainVM leaveRemainVM);
        bool Update(int id, LeaveRemainVM leaveRemainVM);
        bool Delete(int id);
    }
}