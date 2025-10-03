using Microsoft.EntityFrameworkCore;
using Tryy01.DatabaseContexts;
using Tryy01.Models;

namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();
            //var employees = context.EmployeeTable.FirstOrDefault();
            //Console.WriteLine(employees?.EmpName);

            // context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var EmployeeSatae = context.Entry<Employee>(employee).State;
            //Console.WriteLine(EmployeeSatae);//Detached
            //Console.WriteLine("===================================");
            //EmployeeSatae = context.Entry<Employee>(employee).State;
            //Console.WriteLine(EmployeeSatae);//Detached
            //Detashed : Not being tracked by the context
            //Unchanged : Being tracked by the context but not modified
            //Added : Marked for insertion into the database
            //Modified : Marked for update in the database
            //Deleted : Marked for deletion from the database

            //Entitiy Mapping with Fluent API
            //Mapping way used to configure entity properties , relationships ,and mappings when working with Code-First development
            //Gives you more Control over the database schema and relationshils compared to Data Annotaions
            //Defined inside the OnModelCreating method in DBContext
            //Or in separate configuration classes implementing IEntityTypeConfiguration<T>
            //L2E(LINQ to Entity FrameWork) : Query Object Model
            Employee employee = new Employee()
            {
                EmpName = "John Doe",
                Salary = 50000.00M,
                Age = 30,
                Email = "JohnDoe@gmail.com",
                PhoneNumber = "9876543210",

            };
            //Console.WriteLine(context.Entry(employee).State);//Detashed
            //Console.WriteLine(employee.EmpId);
            #region Add New Row In Table Employee In
            // context.EmployeeTable.Add(employee);//01
            //context.Set<Employee>().Add(employee);//02
            //context.Add(employee);//03
            ////context.Entry(employee).State = EntityState.Added;//04

            //Console.WriteLine(context.Entry(employee).State);//Added
            //Console.WriteLine($"Eployee Id : {employee.EmpId}");//0
            ////EF Core Will Not Send Insert Command To Database Until You Call SaveChanges or SaveChanges
            //int rows = context.SaveChanges();
            //Console.WriteLine("After Save Changes");

            //Console.WriteLine(context.Entry(employee).State);//unchanged
            //Console.WriteLine($"Eployee Id : {employee.EmpId}");
            #endregion

            #region Retrieve Data From Database
            //  context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var emp01 = context.Set<Employee>().AsNoTracking().FirstOrDefault(e => e.EmpName=="john");
            //if (emp01 != null)
            //{
            //    Console.WriteLine($"Id : {emp01.EmpId}");
            //    Console.WriteLine($"Name : {emp01.EmpName}");
            //    Console.WriteLine($"Salary : {emp01.Salary}");
            //    Console.WriteLine($"Age : {emp01.Age}");
            //    Console.WriteLine($"Email : {emp01.Email}");
            //    Console.WriteLine($"PhoneNumber : {emp01.PhoneNumber}");
            //    Console.WriteLine($"UserName : {emp01.UserName}");
            //    Console.WriteLine(context.Entry(emp01).State);
            //}
            //else
            //{
            //    Console.WriteLine("No Record Found");
            //}
            #endregion

            #region Modify Data In Database
            //var emp01 = context.EmployeeTable.FirstOrDefault(e => e.EmpId == 10);
            //if (emp01 != null)
            //{
            //    Console.WriteLine(context.Entry(emp01).State);
            //    Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");

            //    emp01.Salary += 5000;//Modify Property

            //    Console.WriteLine("After changing");
            //    Console.WriteLine(context.Entry(emp01).State);
            //    Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");
            //    context.SaveChanges();
            //    Console.WriteLine("After Save Changes");
            //    Console.WriteLine(context.Entry(emp01).State);
            //    Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");


            //}
            #endregion

            #region Remove Data From Database
            var emp01 = context.EmployeeTable.FirstOrDefault(e => e.EmpId == 20);
            if (emp01 != null)
            {
                Console.WriteLine(context.Entry(emp01).State);//Unchanged
                Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");
                //context.EmployeeTable.Remove(emp01);//01
                //context.Set<Employee>().Remove(emp01);//02
                context.Remove(emp01);//03
                //context.Entry(emp01).State = EntityState.Deleted;//04
                Console.WriteLine("After Changing");
                Console.WriteLine(context.Entry(emp01).State);
                Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");
                context.SaveChanges();
                Console.WriteLine("After Save Changes");
                Console.WriteLine(context.Entry(emp01).State);
                Console.WriteLine($"Id:{emp01.EmpId}Name:{emp01.EmpName},Phone:{emp01.PhoneNumber},Email{emp01.Email}");


            }
            #endregion
        }
        }
    }
