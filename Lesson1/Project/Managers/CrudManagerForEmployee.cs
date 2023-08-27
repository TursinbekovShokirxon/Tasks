using ADO.NET_LESSON_1.Lesson1.Project.Services.Classes;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;
using ADO.NET_LESSON_1.Lesson1.Project.Services;
using ADO.NET_LESSON_1.Lesson1.Project.Models;

namespace ADO.NET_LESSON_1.Lesson1.Project.Managers
{

    internal class CrudManagerForEmployee : CrudManagerInterface
    {
        CrudServiceForEmployee crudService = new();
        public void Crud()
        {
            bool isA = true;
            while (isA)
            {
                Console.Clear();
                Console.WriteLine("---Welcome to CrudManagerForEmployee--- ");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Update");
                Console.WriteLine("3 - GetAll");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Truncate");
                byte a = byte.Parse(Console.ReadLine() ?? "");
                switch (a)
                {
                    case 1: { crudService.Create(); } break;
                    case 2: { crudService.Update(); } break;
                    case 3: { ForEach.ForEachForEmployee(); } break;
                    case 4: { crudService.Delete(); } break;
                    case 5: { crudService.Truncate(); } break;
                    default: { isA = false; } break;
                }
            }
        }
    }
}
