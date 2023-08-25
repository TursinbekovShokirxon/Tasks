using ADO.NET_LESSON_1.Lesson1.Project.Managers;
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
            CrudManagerForTask crudManager = new CrudManagerForTask();
            try { crudManager.Crud(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
