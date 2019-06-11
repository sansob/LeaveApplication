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
    public class LeaveRemainRepository : ILeaveRemainRepository
    {
        MyContext myContext = new MyContext();
        bool status = false;

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
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


        public bool Insert(LeaveRemainVM leaveRemainVM)
        {
            var push = new LeaveRemain(leaveRemainVM);
            var getLeaveRequest = myContext.leaveRequests.Find(leaveRemainVM.LeaveRequest_Id);
            var getEmployee = myContext.employees.Find(leaveRemainVM.User_Id);
            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveRemainVM.Type_Id);
            push.LeaveRequest = getLeaveRequest;
            push.Employee = getEmployee;
            push.StatusTypeParam = getStatusTypeParam;
            myContext.leaveRemains.Add(push);
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                return status;
            }
            return status;
        }

        public bool Update(int id, LeaveRemainVM leaveRemainVM)
        {
            var get = Get(id);
            get.Update(id, leaveRemainVM);
            var getLeaveRequest = myContext.leaveRequests.Find(leaveRemainVM.LeaveRequest_Id);
            var getEmployee = myContext.employees.Find(leaveRemainVM.User_Id);
            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveRemainVM.Type_Id);
            get.LeaveRequest = getLeaveRequest;
            get.Employee = getEmployee;
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

        public List<LeaveRemain> Get()
        {
            var get = myContext.leaveRemains.Include("LeaveRequest").Include("Employee").Include("StatusTypeParam").Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public LeaveRemain Get(int id)
        {
            var get = myContext.leaveRemains.Find(id);
            return get;
        }
    }
}

