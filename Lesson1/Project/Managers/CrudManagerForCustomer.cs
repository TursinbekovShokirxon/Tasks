using ADO.NET_LESSON_1.Lesson1.Project.Services.Classes;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;

namespace ADO.NET_LESSON_1.Lesson1.Project.Managers
{
    internal class CrudManagerForCustomer : CrudManagerInterface
    {
        public void Crud()
        {
            bool isA = true;
            while (isA)
            {
                Console.Clear();
                Console.WriteLine("---Welcome to CrudManagerForCustomer--- ");
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Update");
                Console.WriteLine("3 - GetAll");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Truncate");
                Console.WriteLine("6 - Exit");
                byte a = byte.Parse(Console.ReadLine() ?? "");
                switch (a)
                {
                    case 1: { AllBuilders.crudServiseForCustomer.Create();} break;
                    case 2: { AllBuilders.crudServiseForCustomer.Update(); } break;
                    case 3: { ForEach.ForEachForCustomer(); } break;
                    case 4: { AllBuilders.crudServiseForCustomer.Delete(); } break;
                    case 5: { AllBuilders.crudServiseForCustomer.Truncate(); } break;
                    case 6:AllBuilders.selectOperation.SelectMainInStartUp(); break;
                    default: { isA = false; } break;
                }
            }
        }
    }
}
