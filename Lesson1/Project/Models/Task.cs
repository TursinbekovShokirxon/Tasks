namespace ADO.NET_LESSON_1.Lesson1.Project.Models
{
    public class Task
    {
        public int? Id { get; set; }
        public string? NameOfTask { get; set; }
        public string? OrderDate { get; set; }
        public string? DeadLine { get; set; }
        public double  Price { get; set; }
        public int customerid { get; set; } 
        public int employeeid { get; set; } 
        public override string ToString()
        {
            return $"ID - {Id} \nNameOfTask - {NameOfTask} \nPrice - {Price}\nCustomerId - {customerid}\nEmployeeName - {employeeid}\nOrderDate - {OrderDate}\nDeadLine - {DeadLine}";
        }
    }
}
