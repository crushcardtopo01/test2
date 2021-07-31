using System;

namespace test2.Models
{
    public class Employee

    {

                public int ID { get; set;}
                public string Name { get; set;}

                public string LastName { get; set;}
               public string RFC { get; set;}
                public DateTime BornDate { get; set; }    

                public EmployeeStatus Status { get; set; }


    public Employee (string name,string lastname, string rfc ) => (Name,LastName,RFC) = (name,lastname,rfc);

    }
}
