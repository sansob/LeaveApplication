using DataAccess.Models;
using DataAccess.ViewModels;
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
        StatusTypeParam Get(int id);
        bool Insert(StatusTypeParamVM statusTypeParamVM);
        bool Update(int id, StatusTypeParamVM statusTypeParamVM);
        bool Delete(int id);
    }
}
