using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CoreWebApiCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApiCRUD.Controllers
{
    [Route("/")]
  
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{id}", Name="GetEmployee")]
        
        public ActionResult Get(int id)
        {
            Employee employee = _repository.Get(id);
            if (employee.Equals(default(Employee)))
            {
                return NotFound();
            }

            return new OkObjectResult(employee);
        }

        [HttpPost]
       
        public ActionResult PostEmployee([FromBody] Employee employee)
        {
            Employee emp = _repository.Add(employee);
            return new CreatedAtRouteResult("GetEmployee", new { id = emp.Id }, emp);
        }

        [HttpGet]
        public ActionResult GetAllEmployees()
        {
            return new OkObjectResult(_repository.GetAll());
        }

        [HttpPut("{id}")]
       
        public ActionResult PutUpdate(int id, [FromBody] Employee employee)
        {
            if (_repository.Contains(id))
            {
                Employee emp = _repository.Update(id,employee);
                return Ok(emp);
            }
            else
            {
                return NotFound();
            }
        }



        [HttpDelete("{id}")]
        
        public ActionResult Delete(int id)
        {
           
                _repository.Remove(id);
                return new NoContentResult();
           
           
        }

    }
}
