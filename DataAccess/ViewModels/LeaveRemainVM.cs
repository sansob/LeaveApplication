namespace DataAccess.ViewModels {
    public class LeaveRemainVM
    {
        public int Id { get; set; }
        public int LeaveRequest_Id { get; set; }
        public int User_Id { get; set; }
        public int Duration { get; set; }
        public int Type_Id { get; set; }

        public LeaveRemainVM() { }

        public LeaveRemainVM(int leaveRequest_Id, int User_Id, int duration, int type_Id)
        {
            this.LeaveRequest_Id = leaveRequest_Id;
            this.User_Id = User_Id;
            this.Duration = duration;
            this.Type_Id = type_Id;
        }

        public void Update(int id, int leaveRequest_Id, int userId, int duration, int type_Id)
        {
            this.Id = id;
            this.LeaveRequest_Id = leaveRequest_Id;
            this.User_Id = User_Id;
            this.Duration = duration;
            this.Type_Id = type_Id;
        }



    }
}
