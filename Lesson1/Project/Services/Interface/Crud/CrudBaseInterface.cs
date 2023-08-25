using ADO.NET_LESSON_1.Lesson1.Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud
{
    public interface CrudBaseInterface<T>
    {
        public void Create();
        public IEnumerable<T> GetAll();
        public void Update();
        public void Delete();
        public void Truncate();

    }
}
