using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_LeaveTypes")]
    public class LeaveType : BaseModel
    {

        public string LeaveName { get; set; }
        public string TypeStatus { get; set; }

        public LeaveType() { }


    }
}
