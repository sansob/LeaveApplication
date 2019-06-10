using DataAccess.Models;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public interface IStatusTypeParamService
    {
        List<StatusTypeParam> Get();
        List<StatusTypeParam> GetSearch(string values);
        StatusTypeParam Get(int id);
        bool Insert(StatusTypeParamVM statusTypeParamVM);
        bool Update(int id, StatusTypeParamVM statusTypeParamVM);
        bool Delete(int id);
    }
}
