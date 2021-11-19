using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApi.Models
{
    public class Employee
    {
        public string EmployeeNames { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
