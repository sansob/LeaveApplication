using DataAccess.Models;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
   public interface IEmployeeService
    {
        List<Employee> Get();
        List<Employee> GetSearch(string values);
        Employee Get(int id);
        bool Insert(EmployeeVM employeeVM);
        bool Update(int id, EmployeeVM employeeVM);
        bool Delete(int id);
    }
}
