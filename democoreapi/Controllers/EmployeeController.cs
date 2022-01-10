using democoreapi.Data.Context;
using democoreapi.Data.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace democoreapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private CompanyContext _companyContext;
        public EmployeeController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _companyContext.Employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _companyContext.Employees.Add(value);
            _companyContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            var employee = _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee != null)
            {
                _companyContext.Entry<Employee>(employee).CurrentValues.SetValues(value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee != null)
            {
                _companyContext.Employees.Remove(employee);
                _companyContext.SaveChanges();
            }
        }
    }
}
