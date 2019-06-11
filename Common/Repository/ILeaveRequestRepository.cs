﻿using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface ILeaveRequestRepository
    {
        List<LeaveRequest> Get();
        List<LeaveRequest> GetSearch(string values);
        LeaveRequest Get(int id);
        bool Insert(LeaveRequestVM leaveRequestVM);
        bool Update(int id, LeaveRequestVM leaveRequest);
        bool Delete(int id);
    }
}
