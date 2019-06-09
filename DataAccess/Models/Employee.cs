using Core.Base;
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

    }
}
