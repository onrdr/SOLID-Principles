﻿
namespace OCP_Library_3
{
    public class EmployeeModel  
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string EmailAdress { get; set; }
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}