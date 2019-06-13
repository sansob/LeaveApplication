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

        public bool ApproveManager(int id, int manager_id) {
            return iLeaveRequestRepository.ApproveManager(id, manager_id); ;
        }


        public bool Delete(int id) {
            return iLeaveRequestRepository.Delete(id);
        }

        public bool ApproveHrd(int id, int approvalHrdId) {
            return iLeaveRequestRepository.ApproveHrd(id, approvalHrdId); ;
        }

        public bool SetStatus(int id, int statusId) {
            return iLeaveRequestRepository.SetStatus(id, statusId);
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
            if (string.IsNullOrWhiteSpace(leaveRequestVM.Requester_Id.ToString())) {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(leaveRequestVM.FromDate.ToString())) {
                return status;
            }
            else if (string.IsNullOrWhiteSpace(leaveRequestVM.EndDate.ToString())) {
                return status;
            }
            else if (string.IsNullOrEmpty(leaveRequestVM.Reason.ToString())) {
                return status;
            }
            else if (string.IsNullOrEmpty(leaveRequestVM.Leave_Id.ToString())) {
                return status;
            }
            else {
                return iLeaveRequestRepository.Insert(leaveRequestVM);
            }
        }

        public bool Update(int id, LeaveRequestVM leaveRequest) {
            return iLeaveRequestRepository.Update(id, leaveRequest);
        }
    }
}