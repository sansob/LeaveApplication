using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.View_Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public EmployeeVM( string userName, string name, string role)
        {
            this.UserName = userName;
            this.Name = name;
            this.Role = role;
        }
    }
}
