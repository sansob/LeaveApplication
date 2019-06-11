using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models {
    [Table("TB_M_StatusTypeParams")]
    public class StatusTypeParam : BaseModel {
        public string StatusTypeName { get; set; }
        public string StatusTypeValue { get; set; }
        public string StatusTypeModule { get; set; }

        public StatusTypeParam() {
        }

        public StatusTypeParam(StatusTypeParamVM statusTypeParamVM) {
            this.StatusTypeName = statusTypeParamVM.StatusTypeName;
            this.StatusTypeValue = statusTypeParamVM.StatusTypeValue;
            this.StatusTypeModule = statusTypeParamVM.StatusTypeModule;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Update(int id, StatusTypeParamVM statusTypeParamVM) {
            this.Id = statusTypeParamVM.Id;
            this.StatusTypeName = statusTypeParamVM.StatusTypeName;
            this.StatusTypeValue = statusTypeParamVM.StatusTypeValue;
            this.StatusTypeModule = statusTypeParamVM.StatusTypeModule;
            this.CreateDate = DateTimeOffset.Now.ToLocalTime();
        }

        public void Delete() {
            this.IsDalete = true;
            this.DeleteDate = DateTimeOffset.Now.ToLocalTime();
        }
    }
}