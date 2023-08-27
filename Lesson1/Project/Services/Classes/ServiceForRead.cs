using ADO.NET_LESSON_1.Lesson1.Project.Models;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{

    internal class ServiceForRead :ReadInterface
    {
        public Models.Task Read(Models.Task obj)
        {
            List<Customer> customers = new List<Customer>();
            List<Employee> employees = new List<Employee>();
            customers = (List<Customer>)AllBuilders.crudServiseForCustomer.GetAll();
            employees = (List<Employee>)AllBuilders.crudServiceForEmployee.GetAll();
            if (customers.Count() == 0) { Console.WriteLine("Unfortunately you haven't any customers you have to create"); Console.ReadKey(); AllBuilders.crudServiseForCustomer.Create(); }
            if (employees.Count() == 0) { Console.WriteLine("Unfortunately you haven't any employees you have to create"); Console.ReadKey(); AllBuilders.crudServiceForEmployee.Create(); }
            obj.OrderDate = DateTime.Now.ToShortDateString();
            obj.DeadLine = DateTime.Now.AddDays(5).ToShortDateString();
            Console.Write("Enter Task name :"); obj.NameOfTask = Console.ReadLine();
            Console.Write("Enter Price By Task :"); obj.Price = double.Parse(Console.ReadLine() ?? "");
            ForEach.ForEachForCustomer();
            Console.Write("Enter Customer id whose this task :");
            int idcus=int.Parse(Console.ReadLine()??"");
            obj.customerid = idcus;
            ForEach.ForEachForEmployee();
            Console.Write("Enter Employee id whose this do task :");
            int idemp = int.Parse(Console.ReadLine() ?? "");
            obj.customerid = idemp;
            return obj;
        }
        public Employee Read(Employee a)
        {
            Console.Write("Enter Firstname :"); a.FirstName = Console.ReadLine();
            Console.Write("Enter Lastname :"); a.LastName = Console.ReadLine();
            Console.Write("Enter Email :"); a.Email = Console.ReadLine();
            Console.Write("Enter Age :"); a.Age = int.Parse(Console.ReadLine()??"");
            Console.Write("Enter Experiance :"); a.Experience = int.Parse(Console.ReadLine()??"");
            return a;
        }

        public Customer Read(Customer a)
        {
            Console.Write("Enter Firstname :"); a.FirstName = Console.ReadLine();
            Console.Write("Enter Lastname :"); a.LastName = Console.ReadLine();
            Console.Write("Enter Email :"); a.Email = Console.ReadLine();
            Console.Write("Enter Age :"); a.Age = int.Parse(Console.ReadLine() ?? "");
            return a;
        }
    }
}
