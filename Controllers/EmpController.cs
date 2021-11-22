using Microsoft.AspNetCore.Mvc;
using RegistrationApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegistrationApi.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        //EmpController Employees = new EmpController();
        
        
        List<Employee> emp = new List<Employee>()
        {
            new Employee
            {
                EmployeeNames="suresh",UserName="suresh@123",Password="suri123",Id=121
            },
            new Employee
            {
                EmployeeNames="mahesh",UserName="mahesh@123",Password="mahi123",Id=122
            },
            new Employee
            {
                EmployeeNames="sreekanth",UserName="Sreekanth@123",Password="sreekanth123",Id=123
            },
            new Employee
            {
                EmployeeNames="Ravi",UserName="Ravi@123",Password="Ravi123",Id=124
            }
        };
        

        //public Employee AddEmployee(Employee employee)
        //{
        //    emp.Add(employee);
        //    return employee;
        //}

        // GET: api/<EmpController>
        [HttpGet]
        public List<Employee>  GetEmp()
            
        {
            return emp;
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            
            return emp.SingleOrDefault(x => x.Id ==id);
        }

        // POST api/<EmpController>
        [HttpPost]
        public string AddEmployees([FromBody] Employee employee)
        {

            emp.Add(employee);
            return "registration Successfull";
        }

        // PUT api/<EmpController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
