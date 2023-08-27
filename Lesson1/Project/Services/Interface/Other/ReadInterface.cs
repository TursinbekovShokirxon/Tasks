using ADO.NET_LESSON_1.Lesson1.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other
{
    public interface ReadInterface
    {
        public Models.Task Read(Models.Task obj);
        public Employee Read(Employee a);
        public Customer Read(Customer a);
    }
}
