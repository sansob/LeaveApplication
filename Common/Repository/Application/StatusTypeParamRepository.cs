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
    public class StatusTypeParamRepository : IStatusTypeParamRepository
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

        public List<StatusTypeParam> Get()
        {
            var get = myContext.statusTypeParams.Where(X => X.IsDelete == false).ToList();
            return get;
        }

        public StatusTypeParam Get(int id)
        {
            var get = myContext.statusTypeParams.Find(id);
            return get;
        }

        public List<StatusTypeParam> GetSearch(string values)
        {
            var get = myContext.statusTypeParams.Where
                (X => (X.StatusTypeName.Contains(values) || X.StatusTypeValue.Contains(values) || X.StatusTypeModule.Contains(values)) && X.IsDelete == false).ToList();
            return get;
        }

        public bool Insert(StatusTypeParamVM statusTypeParamVM)
        {
            var pust = new StatusTypeParam(statusTypeParamVM);
            myContext.statusTypeParams.Add(pust);
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

        public bool Update(int id, StatusTypeParamVM statusTypeParamVM)
        {
            var get = Get(id);
            get.Update(id, statusTypeParamVM);
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
