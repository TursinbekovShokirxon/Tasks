using ADO.NET_LESSON_1.Lesson1.Project.Services.Classes;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Managers
{
    internal class CrudManagerForTask : CrudManagerInterface
    {
         public static  CrudServiceForTask crudServiceForTask = new();

        public void Crud()
        {
            bool isA = true;
            while (isA)
            {
                Console.WriteLine("---Welcome to CrudManagerForTask--- ");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - GetAll");
                Console.WriteLine("3 - Update");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Truncate");
                byte a = byte.Parse(Console.ReadLine() ?? "");
                switch (a)
                {
                    case 1: { crudServiceForTask.Create(); } break;
                    case 2: { crudServiceForTask.Create(); } break;
                    case 3: { crudServiceForTask.Update(); } break;
                    case 4: { crudServiceForTask.Delete(); } break;
                    case 5: { crudServiceForTask.Truncate(); } break;
                    default: { isA = false; } break;
                }
            }
        }
    }
}
