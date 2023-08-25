using ADO.NET_LESSON_1.Lesson1.Project.Managers;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.StartUp
{
    internal class StartUpInternal
    {
        public static void StartUp()
        {
            SelectOperation selectOperation = new SelectOperation();
            try {selectOperation.SelectMainInStartUp();}
            catch (Exception ex) { Console.WriteLine(ex.Message);}
        }
    }
}
