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
            var get = myContext.leaveTypes.Include("StatusTypeParam").Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public LeaveType Get(int id)
        {
            var get = myContext.leaveTypes.Find(id);
            return get;
        }

        public bool Insert(LeaveTypeVM leaveTypeVM)
        {
            var pust = new LeaveType(leaveTypeVM);
            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveTypeVM.StatusTypeParam_Id);
            pust.StatusTypeParam = getStatusTypeParam;
            myContext.leaveTypes.Add(pust);
            var result = myContext.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            else
            {
                return false;
            }
            return status;


        }

        public bool Update(int id, LeaveTypeVM leaveTypeVM)
        {
            var get = Get(id);
            get.Update(id, leaveTypeVM);
            var getStatusTypeParam = myContext.statusTypeParams.Find(leaveTypeVM.StatusTypeParam_Id);
            get.StatusTypeParam = getStatusTypeParam;
            myContext.Entry(get).State = System.Data.Entity.EntityState.Modified;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            else
            {
                return false;
            }
            return status;

        }
    }
}
