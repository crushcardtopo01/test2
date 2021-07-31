using System;
using System.ComponentModel.DataAnnotations;
using test2.Controllers;

namespace test2.Models
{
    public class Employee

    {

                public int Id { get; set;}
[Required]
                public string Name { get; set;}

                public string LastName { get; set;}
[Required(ErrorMessage = "must write RFC")]
[RFCExists]            
public string RFC { get; set;}
                public DateTime BornDate { get; set; }    

                public EmployeeStatus Status { get; set; }


    public Employee (int id ,string nombre,string apellido, string rfc ) => (Id,Name,LastName,RFC) = (id,nombre,apellido,rfc);
    public Employee (int id ,string nombre,string apellido, string rfc, DateTime borndate, EmployeeStatus status ) => (Id,Name,LastName,RFC,BornDate,Status) = (id,nombre,apellido,rfc,borndate,status);
    public Employee()
    {
        
    }
    }

   
}
