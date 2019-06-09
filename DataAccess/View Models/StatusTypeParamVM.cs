using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.View_Models
{
    public class StatusTypeParamVM
    {
        public int Id { get; set; }
        public string StatusTypeName { get; set; }
        public string StatusTypeValue { get; set; }
        public string StatusTypeModule { get; set; }

        public StatusTypeParamVM(string statusTypeName, string statusTypeValue, string statusTypeModule)
        {
            this.StatusTypeName = statusTypeName;
            this.StatusTypeValue = statusTypeValue;
            this.StatusTypeModule = statusTypeValue;
        }

        public StatusTypeParamVM() { }
    }
}
