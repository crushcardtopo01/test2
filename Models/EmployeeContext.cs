using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace test2.Models{

    public class EmployeeContext: DbContext{

        public DbSet<Employee> Employees {get;set;}

        public EmployeeContext (DbContextOptions<EmployeeContext> options ): base (options){

        

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){


            base.OnModelCreating(modelBuilder);
            var employee =  new Employee(40,"Carlos","Trevera", "TEEC940306EI2");
            modelBuilder.Entity<Employee>().HasData(
                employee
            );

        }


    }
}