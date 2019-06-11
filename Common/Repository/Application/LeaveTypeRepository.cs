using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.View_Models;
using DataAccess.MyContext;

namespace Common.Repository.Application
{
    public class LeaveTypeRepository : ILeaveTypeRepository
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

        public List<LeaveType> Get()
        {
            var get = myContext.leaveTypes.Where(X => X.IsDalete == false).ToList();
            return get;
        }

        public LeaveType Get(int id)
        {
            var get = myContext.leaveTypes.Find(id);
            return get;
        }

        public List<LeaveType> GetSearch(string values)
        {
            var get = myContext.leaveTypes.Where
                (X => (X.LeaveName.Contains(values) || X.LeaveTypeParams.Contains(values)) && X.IsDalete == false).ToList();
            return get;
        }

        public bool Insert(LeaveTypeVM leaveTypeVM)
        {
            var pust = new LeaveType(leaveTypeVM);
            myContext.leaveTypes.Add(pust);
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

        public bool Update(int id, LeaveTypeVM leaveTypeVM)
        {
            var get = Get(id);
            get.Update(id, leaveTypeVM);
            myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
            var result = myContext.SaveChanges();
            if(result > 0)
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
