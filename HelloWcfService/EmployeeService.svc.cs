using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAllEmployee()
        {
            try
            {
                List<Employee> Employees = new List<Employee>();
                Employees.Add(new Employee { Id = 1, FirstName = "Nami", LastName = "Zhang", Salary = 666666666, Ssn = "123-01-1111" });
                Employees.Add(new Employee { Id = 2, FirstName = "Yijia", LastName = "Zhang", Salary = 213213213, Ssn = "321-01-1111" });
                Employees.Add(new Employee { Id = 3, FirstName = "Ikea", LastName = "Zhang", Salary = 88888888, Ssn = "135-01-1111" });
                return Employees;
            }
            catch (Exception)
            {
                var errorData = new ErrorData();
                errorData.ErrorCode = "50000";
                errorData.ErrorDescription = "No Employee found! Please Try Again!";
                throw new FaultException<ErrorData>(errorData);
            }
           
        }

        public Employee GetEmployeeById(int Id)
        {

                if (Id > 0)
                {
                    return new Employee { Id = 1, FirstName = "Nami", LastName = "Zhang", Salary = 666666666, Ssn = "123-01-1111" };
                }
                else
                {
                    var errorData = new ErrorData();
                    errorData.ErrorCode = "50001";
                    errorData.ErrorDescription = "No Employee found with the Id! Please Enter a valid Id!";
                throw new FaultException<ErrorData>(errorData);
                
                }
            
            
            
        }
    }
}
