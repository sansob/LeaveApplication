namespace DataAccess.ViewModels
{
    public class LeaveTypeVM 
    {
        public int Id { get; set; }
        public string LeaveName { get; set; }
        public int StatusTypeParam_Id { get; set; }

        public LeaveTypeVM() { }

        public LeaveTypeVM(string leaveName, int statusTypeParam_Id)
        {
            this.LeaveName = leaveName;
            this.StatusTypeParam_Id = statusTypeParam_Id;
        }

        public void Update(int id, string leaveName, int statusTypeParam_Id)
        {
            this.Id = id;
            this.LeaveName = leaveName;
            this.StatusTypeParam_Id = statusTypeParam_Id;
        }

        
    }
}
