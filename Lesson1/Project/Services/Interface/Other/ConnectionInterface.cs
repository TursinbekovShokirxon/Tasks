using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other
{
    public interface ConnectionInterface<T,T1,T2>
    {
        public int Connecting(string connect);
        public IEnumerable<T> Connecting(T type);
        public IEnumerable<T1> Connecting(T1 type);
        public IEnumerable<T2> Connecting(T2 type);
    }
}
