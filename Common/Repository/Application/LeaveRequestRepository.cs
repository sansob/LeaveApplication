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

        public bool Update(int id, LeaveRequestVM leaveRequestVM)
        {
            var get = Get(id);
            get.Update(id, leaveRequestVM);
            var getLeaveType = myContext.leaveTypes.Find(leaveRequestVM.Leave_Id);
            get.LeaveType = getLeaveType;
            var getRequesterEmployee = myContext.employees.Find(leaveRequestVM.Requester_Id);
            get.RequesterEmployee = getRequesterEmployee;
            var getManagerEmployee = myContext.employees.Find(leaveRequestVM.ApprovalManager_Id);
            get.ManagerEmployee = getManagerEmployee;
            var getHrdEmployee = myContext.employees.Find(leaveRequestVM.ApprovalHrd_Id);
            get.HrdEmployee = getHrdEmployee;
            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveRequestVM.Status_Id);
            get.StatusTypeParam = getStatusTypeParam;

            myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
    }
}
