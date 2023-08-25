using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Models
{
    public class Task
    {
        public int? Id { get; set; }
        public string? NameOfTask { get; set; }
        public string? OrderDate { get; set; }
        public string? DeadLine { get; set; }
        public double  Price { get; set; }
        public Customer Customer { get; set; } = new();
        public Employee Employee { get; set; } = new();
        public override string ToString()
        {

            return $"ID - {Id} \nNameOfTask - {NameOfTask} \nPrice - {Price}\nCustomerId - {Customer.Id}\nEmployeeName - {Employee.Id}\nOrderDate - {OrderDate}\nDeadLine - {DeadLine}";
        }
    }
}
