using DataAccess.Models;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository
{
    public interface IStatusTypeParamRepository
    {
        List<StatusTypeParam> Get();
        List<StatusTypeParam> GetSearch(string values);
        StatusTypeParam Get(int id);
        bool Insert(StatusTypeParamVM statusTypeParamVM);
        bool Update(int id, StatusTypeParamVM statusTypeParamVM);
        bool Delete(int id);
    }
}
