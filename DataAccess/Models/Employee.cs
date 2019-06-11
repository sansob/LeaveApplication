using Core.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models {
    [Table("TB_M_Employees")]
    public class Employee : BaseModel {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public Employee() {
        }
    }
}