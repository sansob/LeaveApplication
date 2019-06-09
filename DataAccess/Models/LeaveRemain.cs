using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_LeaveRemains")]
    public class LeaveRemain : BaseModel
    {
        [ForeignKey("LeaveRequest")]
        public int LeaveRequestId { get; set; }
        public string UserID { get; set; }
        public int Duration { get; set; }
        public string Type { get; set; }

        public LeaveRemain() { }

        public LeaveRequest LeaveRequest { get; set; }

    }
}
