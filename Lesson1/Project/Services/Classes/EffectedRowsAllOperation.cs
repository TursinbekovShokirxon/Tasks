using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
    public class EffectedRowsAllOperation : EffectedRowsAllOperationInterface
    {
        public void Effect(int effect)
        {
            if (effect > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();
        }
    }   
}
