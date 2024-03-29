﻿namespace DataAccess.ViewModels {
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public EmployeeVM() { }

        public EmployeeVM(string userName, string name, string role, string password)
        {
            this.UserName = userName;
            this.Name = name;
            this.Role = role;
            this.Password = password;            
        }

    }
}
