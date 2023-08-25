using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Models
{
    public class Employee:People
    {
        public int Experience { get; set; }
        public override string ToString()
        {
            return $"ID - {Id} \nFirstname - {base.FirstName}\nLastName - {base.LastName}\nAge - {base.Age}\nEmail - {base.Email}\nExperiance{Experience}";
        }
    }
}
