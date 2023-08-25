using ADO.NET_LESSON_1.Lesson1.Project.Services.Classes;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Managers
{

    internal class CrudManagerForEmployee : CrudManagerInterface
    {
        CrudService crudService = new();
        public void Crud()
        {
            bool isA = true;
            while (isA)
            {
                Console.WriteLine("---Welcome to CrudManagerForEmployee--- ");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - GetAll");
                Console.WriteLine("3 - Update");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Truncate");
                byte a = byte.Parse(Console.ReadLine() ?? "");
                switch (a)
                {
                    case 1: { crudService.Create(); } break;
                    case 2: { crudService.Create(); } break;
                    case 3: { crudService.Update(); } break;
                    case 4: { crudService.Delete(); } break;
                    case 5: { crudService.Truncate(); } break;
                    default: { isA = false; } break;
                }
            }
        }
    }
}
