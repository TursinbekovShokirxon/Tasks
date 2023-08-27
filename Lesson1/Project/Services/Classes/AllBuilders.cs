using ADO.NET_LESSON_1.Lesson1.Project.Connection;
using ADO.NET_LESSON_1.Lesson1.Project.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
    internal class AllBuilders
    {
        public static EffectedRowsAllOperation effectedRowsAllOperation=new();
        public static SelectOperation selectOperation = new();
        public static ManagerForConnecting managerForConnecting = new();
        public static ServiceForRead ServiceForRead = new();
        public static CrudServiceForTask crudServiceForTask = new();
        public static CrudServiceForEmployee crudServiceForEmployee = new();
        public static CrudServiseForCustomer crudServiseForCustomer = new();
        public static CrudManagerForCustomer crudManagerForCustomer = new();
        public static CrudManagerForEmployee crudManagerForEmployee = new();
        public static CrudManagerForTask crudManagerForTask = new();
    }
}
