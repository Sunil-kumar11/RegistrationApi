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
        List<Employee> Emp = new List<Employee>()
        {
            new Employee
            {
                EmployeeNames="suresh",UserName="suresh@123",Password="suri123",Id=123
            },
            new Employee
            {
                EmployeeNames="mahesh",UserName="mahesh@123",Password="mahi123",Id=123
            }
        };

        // GET: api/<EmpController>
        [HttpGet]
        public IActionResult  GetEmp()
            
        {
            return Ok(Emp);
        }

        // GET api/<EmpController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            
            return "value";
        }

        // POST api/<EmpController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
