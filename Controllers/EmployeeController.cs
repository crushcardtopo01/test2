using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using test2.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace test2.Controllers{

    public class EmployeeController : Controller {

        private EmployeeContext _context;

        public IActionResult Create() {
        
        return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
            bool flag= false;

            var listempleados= _context.Employees;

                foreach (var item in listempleados)
                {
                    if (item.RFC == employee.RFC){
                        flag=true;
                    }
                }
            if(ModelState.IsValid && !flag){
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return View("index",listempleados);
            }else{
                
                return View();
            }

          
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



    public class RFCExists :ValidationAttribute {

        private bool isCorrect(string part1, string part2 ){

            bool result = false;
            bool flag1 = false;
            bool flag2 = false;
            string letters = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            string numbers = "0123456789";

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < part1.Length; j++)
                {
                    if(letters[i]==part1[j]){
                        flag1 = true;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < part1.Length; j++)
                {
                    if(numbers[i]==part2[j]){
                        flag2 = true;
                    }
                }
            {
                
            }

            if(flag1 && flag2 == true){
                result = true;
            }

            return result;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){

            string rfc= (string) value;

            try
            {
                var part1 = rfc.Substring(0,4);
            var part2 = rfc.Substring(4,6);


            if(rfc.Length!= 13 && isCorrect(part1,part2)){
                return new ValidationResult("Incorrect formart of RFC");
            }else{

                return ValidationResult.Success;
            }
            }
            catch (System.Exception e)
            {
                
                return new ValidationResult("Incorrect formart of RFC");
            }

            

            
        }
    }
}

