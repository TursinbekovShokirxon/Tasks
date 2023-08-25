using ADO.NET_LESSON_1.Lesson1.Project.Managers;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
    internal class SelectOperation : SelectOperationInterface
    {
        CrudManagerForCustomer crudManagerForCustomer = new();
        CrudManagerForEmployee employeeManagerForEmployee = new();
        CrudManagerForTask taskManagerForTask = new();
        public string SelectInTruncate(string Command)
        {
            while (true) { 
            Console.WriteLine("Do you want restart identification ?\n1 - Yes\n2 - No\nEnter your answer:");
            byte select = byte.Parse(Console.ReadLine() ?? "");
                if (select == 1) { Command += "restart identity;"; return Command; }
                else if (select == 2) { return Command; }
                else { Console.WriteLine("You enter wrong"); Console.ReadKey(); }
            }
        }
        public void SelectMainInStartUp()
        {
            Console.WriteLine("1 - Employee\n2 - Customer\n3 - Task\nEnter your answer :");
            byte select =byte.Parse(Console.ReadLine()??"");
            bool isA = true;
            while (isA)
            {
                switch (select)
                {
                    case 1: employeeManagerForEmployee.Crud(); break;
                    case 2: crudManagerForCustomer.Crud();break;
                    case 3: taskManagerForTask.Crud();break;
                    default: { Console.WriteLine("you enter wrong button\n--Enter Again"); }break;
                }
            }
            Console.ReadKey();
        }
    }
}
