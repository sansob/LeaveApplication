using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_StatusTypeParams")]
    public class StatusTypeParam : BaseModel
    {
        public string StatusTypeName { get; set; }
        public string StatusTypeValue { get; set; }
        public string StatusTypeModule { get; set; }

        public StatusTypeParam() { }


    }
}
