using DataAccess.MyContext;
using System;
using System.Linq;
using DataAccess.Models;

namespace Common.Repository.Application {
    public class LoginRepository {
        readonly MyContext myContext = new MyContext();
        public Employee CekLogin(string userName, string password) {
            var temp = myContext.employees
                .SingleOrDefault(x => x.UserName == userName && x.Password == password);
//                var get = myContext.employees.Where(x => x.Id == temp.Id);
            return temp;
            //            if (temp.UserName == userName && temp.Password == password) {
            //                var get = myContext.employees.Where(x => x.Id == temp.Id).ToList();
            //                return get;
            //            }
            //            else {
            //                return null;
            //            }
        }
    }
}