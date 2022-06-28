﻿
namespace OCP_Library_3
{
    internal class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel emp = new()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAdress = $"{person.FirstName.Substring(0, 1)}.{person.LastName}".ToLower() + "@company.com",
                IsManager = true
            };
            return emp;
        }
    }
}
