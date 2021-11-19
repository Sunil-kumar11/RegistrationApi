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
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        List<Employee> emp = new List<Employee>();

        string[] EmployeeNames = { "ravi", "raju", "Praveen", "vikas" };
        string[] UserName = { "RaviKumar", "RajuKuamr", "PraveenKumar", "vikas123" };
        string[] Password = { "Ravi123", "Raj345", "praveen989", "vikas678" };
        int[] Id = { 1, 2, 3, 4, };

        [HttpGet]
        
        public string GetEmployee()
        {
            string EmployeeDetails = "EmployeeDetails  :";

            string UserNames = "";
            for (int i = 0; i < UserName.Length - 1; i++)
            {
                UserNames += UserName[i] + " ,";
            }


            string Employees = "";
            for (int i = 0; i <= EmployeeNames.Length - 1; i++)
            {
                Employees += EmployeeNames[i] + ",";
            }

            string Passwords = "";
            for (int i = 0; i <= Password.Length - 1; i++)
            {
                Passwords += Password[i] + " ,";

            }
            string Ids = "";
            for (int i = 0; i <= Id.Length - 1; i++)
            {
                Ids += Id[i] + " ,";
            }

            EmployeeDetails = "EmployeesDetails  :" + Employees + " UserNames : " + UserNames + "Passwords :" + Passwords + "Employees Ids : " + Ids;
            return EmployeeDetails;

        }
        // GET api/<EmployeeController>/5
        
        [HttpPost("User")]
        public string User([FromBody] Employee employee )
        {
            string username = employee.UserName;
            string password = employee.Password; 

            string checkedusername = "";
            string checkedpassword = "";

            for (int i=0; i <= UserName.Length -1; i++)
            {
                if (username == UserName[i])
                {
                    checkedusername = username;
                    for (int j = 0; j <= Password.Length - 1; j++)
                    {
                        if(password == Password[j])
                        {
                            checkedpassword = password;
                        }
                    }

                }


            }
            if (checkedusername == username && checkedpassword == password)
            {
                return "Longin Success";
            }
            else
            {
                return "username or password wrong please check";
            }


        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

