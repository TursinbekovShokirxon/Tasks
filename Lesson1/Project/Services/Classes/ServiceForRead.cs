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
            obj.OrderDate = DateTime.Now.ToShortDateString();
            obj.DeadLine = DateTime.Now.AddDays(5).ToShortDateString();
            Console.Write("Enter Task name :"); obj.NameOfTask = Console.ReadLine();
            Console.Write("Enter Price By Task :"); obj.Price = double.Parse(Console.ReadLine() ?? "");
            return obj;
        }

        public Employee Read(Employee a)
        {
         
        }

        public Customer Read(Customer a)
        {
           
        }
    }
}
