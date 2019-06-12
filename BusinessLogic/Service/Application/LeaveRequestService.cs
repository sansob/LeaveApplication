using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository;
using Common.Repository.Application;

namespace BusinessLogic.Service.Application {
    public class LeaveRequestService : ILeaveRequestService {
        ILeaveRequestRepository iLeaveRequestRepository = new LeaveRequestRepository();
        bool status = false;

        public bool Delete(int id) {
            return iLeaveRequestRepository.Delete(id);
        }

        public List<LeaveRequest> Get() {
            return iLeaveRequestRepository.Get();
        }

        public LeaveRequest Get(int id) {

            return iLeaveRequestRepository.Get(id);
        }

        public List<LeaveRequest> GetSearch(string values) {
            return iLeaveRequestRepository.GetSearch(values);
        }

        public bool Insert(LeaveRequestVM leaveRequestVM) {
            throw new NotImplementedException();
        }

        public bool Update(int id, LeaveRequestVM leaveRequest) {
            return iLeaveRequestRepository.Update(id, leaveRequest);
        }
    }
}