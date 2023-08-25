using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Interface
{
    public interface CrudBaseInterface <T>
    {
        public T Create();
        public int Update();
        public int Delete();
        public void Truncate();

    }
}
