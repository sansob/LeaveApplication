namespace DataAccess.ViewModels {
    public class StatusTypeParamVM
    {
        public int Id { get; set; }
        public string StatusTypeName { get; set; }
        public string StatusTypeValue { get; set; }
        public string StatusTypeModule { get; set; }

        public StatusTypeParamVM() { }

        public StatusTypeParamVM(string statusTypeName, string statusTypeValue, string statusTypeModule)
        {
            this.StatusTypeName = statusTypeName;
            this.StatusTypeValue = statusTypeValue;
            this.StatusTypeModule = statusTypeValue;
        }

        public void Update(int id, string statusTypeName, string statusTypeValue, string statusTypeModule)
        {
            this.Id = id;
            this.StatusTypeName = statusTypeName;
            this.StatusTypeValue = statusTypeValue;
            this.StatusTypeModule = statusTypeValue;
        }

        
    }
}
