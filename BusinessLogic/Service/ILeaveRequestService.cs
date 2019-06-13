﻿using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service {
    public interface ILeaveRequestService {
        List<LeaveRequest> Get();
        List<LeaveRequest> GetSearch(string values);
        LeaveRequest Get(int id);
        bool Insert(LeaveRequestVM leaveRequestVM);
        bool Update(int id, LeaveRequestVM leaveRequest);
        bool ApproveManager(int id, int manager_id);
        bool Delete(int id);
        bool ApproveHrd(int id, int approvalHrdId);
        bool SetStatus(int id, int statusId);
    }
}