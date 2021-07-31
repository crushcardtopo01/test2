using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using test2.Models;
namespace test2.Controllers{

    public class EmployeeController : Controller {

        public IActionResult index() {

            

            var listempleados= new List<Employee>(){
                new Employee("Carlos","Trevera","TEDC9403"),
                new Employee("Lupita","Trevera","TEDC940ee3"),
                new Employee("Carlos","Trevera","TEDC94eer03")
            };

            return View(listempleados);
        }


    }
}

