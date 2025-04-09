using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
namespace CustMgmt.Models
{
    public class EmployeeDetails
    {
        [Key]
        public  int EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public string UIDNO { get; set; }
        public string PAN { get; set; }
        public string EMailId { get; set; }
        public int Salary { get; set; }
}
}
