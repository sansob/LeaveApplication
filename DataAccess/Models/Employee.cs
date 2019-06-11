using Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("TB_M_Employees")]
    public class Employee : BaseModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public Employee() { }

        //public Employee(EmployeeVM employeeVM)
        //{
        //    this.UserName = employeeVM.UserName;
        //    this.Name = employeeVM.Name;
        //    this.Role = employeeVM.Role;
        //    this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        //}

        //public void Update(int id, EmployeeVM employeeVM)
        //{
        //    this.Id = employeeVM.Id;
        //    this.UserName = employeeVM.UserName;
        //    this.Name = employeeVM.Name;
        //    this.Role = employeeVM.Role;
        //    this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        //}

        //public void Delete()
        //{
        //    this.IsDalete = true;
        //    this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        //}
    }
}
