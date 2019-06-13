using DataAccess.MyContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repository.Application
{
    public class LoginRepository
    {
        MyContext myContext = new MyContext();
        public bool cekLogin(string userName, string password)
        {
            bool cek = false;
            var temp = myContext.employees.Where(x => x.UserName == userName && x.Password == password).SingleOrDefault();

            try
            {
                if(temp.UserName == userName && temp.Password == password)
                {
                    cek = true;
                }
                else
                {
                    cek = false;
                }
            }
            catch (Exception ex)
            {
                cek = false;
                ex.GetBaseException();
            }
            return cek;
        }
    }
}
