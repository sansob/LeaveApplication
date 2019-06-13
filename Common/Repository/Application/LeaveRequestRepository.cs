using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        LeaveRequestVM requestVm = new LeaveRequestVM();
        bool status = false;
        private bool _status;

        public bool Update(int id, LeaveRequestVM leaveRequestVM) {
            throw new NotImplementedException();
        }


        public bool ApproveManager(int id, int manager_id) {
            var pull = Get(id);
            var getData = myContext.leaveRequests.Find(id);
            pull.ApprovalManager_Id = manager_id;
            myContext.Entry(pull).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0) {
                _status = true;
            } else {
                return _status;
            }

            return _status;
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            if(get != null)
            {
                get.Delete();
                myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
                myContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ApproveHrd(int id, int approvalHrdId) {
            var pull = Get(id);
            var getData = myContext.leaveRequests.Find(id);
            pull.ApprovalHrd_Id = approvalHrdId;
            myContext.Entry(pull).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0) {
                _status = true;
            } else {
                return _status;
            }

            return _status;
        }

        public bool SetStatus(int id, int statusId) {
            var pull = Get(id);
            var getData = myContext.leaveRequests.Find(id);
            pull.Status_Id = statusId;
            myContext.Entry(pull).State = EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0) {
                _status = true;
            } else {
                return _status;
            }

            return _status;
        }

        public List<LeaveRequest> GetbyUser(int userId) {
            var get = myContext.leaveRequests.Include("LeaveType").Include("RequesterEmployee").Include("ManagerEmployee").Include("HrdEmployee").Include("StatusTypeParam")
                .Where(X => X.IsDelete == false && X.Requester_Id == userId).ToList();
            return get;
        }

        public List<LeaveRequest> GetByManager() {
            var get = myContext.leaveRequests.Include("LeaveType").Include("RequesterEmployee").Include("ManagerEmployee").Include("HrdEmployee").Include("StatusTypeParam")
                .Where(X => X.IsDelete == false && X.ApprovalManager_Id==null).ToList();
            return get;
        }

        public List<LeaveRequest> Get()
        {
            var get = myContext.leaveRequests.Include("LeaveType").Include("RequesterEmployee").Include("ManagerEmployee").Include("HrdEmployee").Include("StatusTypeParam")
                 .Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public LeaveRequest Get(int id)
        {
            var get = myContext.leaveRequests.Find(id);
            return get;
        }

        public List<LeaveRequest> GetSearch(string values)
        {
            throw new NotImplementedException();
        }

        public bool Insert(LeaveRequestVM leaveRequestVM)
        {
            var push = new LeaveRequest(leaveRequestVM);
            myContext.leaveRequests.Add(push);
            var result = myContext.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            else
            {
                return status;
            }
            return status;

        }

//        public bool Update(int id, LeaveRequestVM leaveRequestVM)
//        {
//            var get = Get(id);
//            get.Update(id, leaveRequestVM);
//            var getLeaveType = myContext.leaveTypes.Find(leaveRequestVM.Leave_Id);
//            get.LeaveType = getLeaveType;
//            var getRequesterEmployee = myContext.employees.Find(leaveRequestVM.Requester_Id);
//            get.RequesterEmployee = getRequesterEmployee;
//            var getManagerEmployee = myContext.employees.Find(leaveRequestVM.ApprovalManager_Id);
//            get.ManagerEmployee = getManagerEmployee;
//            var getHrdEmployee = myContext.employees.Find(leaveRequestVM.ApprovalHrd_Id);
//            get.HrdEmployee = getHrdEmployee;
//            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveRequestVM.Status_Id);
//            get.StatusTypeParam = getStatusTypeParam;
//
//            myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
//            var result = myContext.SaveChanges();
//            if (result > 0)
//            {
//                status = true;
//            }
//            else
//            {
//                status = false;
//            }
//            return status;
//        }
    }
}
