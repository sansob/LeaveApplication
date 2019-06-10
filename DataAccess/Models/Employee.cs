﻿using Core.Base;
using DataAccess.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employees")]
    public class Employee : BaseModel
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Employee() { }

        public Employee(EmployeeVM employeeVM)
        {
            this.UserName = employeeVM.UserName;
            this.Name = employeeVM.Name;
            this.Role = employeeVM.Role;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, EmployeeVM employeeVM)
        {
            this.Id = employeeVM.Id;
            this.UserName = employeeVM.UserName;
            this.Name = employeeVM.Name;
            this.Role = employeeVM.Role;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDalete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}
