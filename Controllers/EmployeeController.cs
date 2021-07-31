using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using test2.Models;
using System.Linq;
namespace test2.Controllers{

    public class EmployeeController : Controller {

        private EmployeeContext _context;

          public IActionResult Create() {
          
          return View();
          }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            
            _context.Employees.Add(employee);
            _context.SaveChanges();

          return View();
          }

        public IActionResult index() {

            var employee = _context.Employees.FirstOrDefault();
/*
            var listempleados= new List<Employee>(){
                new Employee(1,"Carlos","Trevera","TEDC9403"),
                new Employee(2,"Lupita","Trevera","TEDC940ee3"),
                new Employee(3,"Carlos","Trevera","TEDC94eer03")
            };
            listempleados.Add(employee);*/

            var listempleados= _context.Employees;


          
             

            return View(listempleados);
        }

        public EmployeeController(EmployeeContext context)
        {
            _context= context;
        }


    }
}

