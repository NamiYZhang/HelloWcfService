using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelloWcfService
{
    [DataContract]
    public class Employee
    {
        [DataMember(Name="EmployeeId")]
        public int Id { get; set; }
        [DataMember(Name = "FName")]
        public string FirstName { get; set; }
        [DataMember(Name = "LName")]
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Ssn { get; set; }
    }
}