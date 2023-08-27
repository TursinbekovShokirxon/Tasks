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
        public void Crud()
        {
            bool isA = true;
            while (isA)
            {
                Console.Clear();
                Console.WriteLine("---Welcome to CrudManagerForTask--- ");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Update");
                Console.WriteLine("3 - GetAll");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Truncate");
                byte a = byte.Parse(Console.ReadLine() ?? "");
                switch (a)
                {
                    case 1: { AllBuilders.crudServiceForTask.Create(); } break;
                    case 2: { AllBuilders.crudServiceForTask.Update(); } break;
                    case 3: { ForEach.ForEachForTask(); } break;
                    case 4: { AllBuilders.crudServiceForTask.Delete(); } break;
                    case 5: { AllBuilders.crudServiceForTask.Truncate(); } break;
                    default: { isA = false; } break;
                }
            }
        }
    }
}
