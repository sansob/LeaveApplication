using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application
{
    public class LeaveTypeService : ILeaveTypeService
    {
        ILeaveTypeRepository iLeaveTypeRepository = new LeaveTypeRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iLeaveTypeRepository.Delete(id);
        }

        public List<LeaveType> Get()
        {
            return iLeaveTypeRepository.Get();
        }

        public LeaveType Get(int id)
        {
           return iLeaveTypeRepository.Get(id);
        }

        public bool Insert(LeaveTypeVM leaveTypeVM)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, LeaveTypeVM leaveTypeVM)
        {
            return iLeaveTypeRepository.Update(id, leaveTypeVM);
        }
    }
}
