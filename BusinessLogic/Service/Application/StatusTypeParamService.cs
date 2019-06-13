using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repository.Application;
using Common.Repository;

namespace BusinessLogic.Service.Application
{
    public class StatusTypeParamService : IStatusTypeParamService
    {
        IStatusTypeParamRepository iStatusTypeParamRepository = new StatusTypeParamRepository();
        bool status = false;

        public bool Delete(int id)
        {
            return iStatusTypeParamRepository.Delete(id);
        }

        public List<StatusTypeParam> Get()
        {
            return iStatusTypeParamRepository.Get();
        }

        public List<StatusTypeParam> GetSearch(string values) {
            throw new NotImplementedException();
        }

        public StatusTypeParam Get(int id)
        {
            return iStatusTypeParamRepository.Get(id);
        }

        public bool Insert(StatusTypeParamVM statusTypeParamVM) {
            return string.IsNullOrWhiteSpace(statusTypeParamVM.StatusTypeModule) ? status : iStatusTypeParamRepository.Insert(statusTypeParamVM);
        }

        public bool Update(int id, StatusTypeParamVM statusTypeParamVM)
        {
            return iStatusTypeParamRepository.Update(id, statusTypeParamVM);
        }
    }
}
