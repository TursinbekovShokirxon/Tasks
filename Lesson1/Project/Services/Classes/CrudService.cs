using ADO.NET_LESSON_1.Lesson1.Project.Connection;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
    public class CrudService : CrudTaskInterface
    {
        ManagerForConnecting managerForConnecting = new ManagerForConnecting();
        public Task Create()
        {
            Task obj = new Task();
            obj.OrderDate = DateTime.Now.ToShortDateString();
            obj.DeadLine = DateTime.Now.AddDays(5).ToShortDateString();
            Console.Write("Enter Task name :"); obj.NameOfTask = Console.ReadLine();
            Console.Write("Enter Price By Task :"); obj.Price = double.Parse(Console.ReadLine() ?? "");
            string? Command = $"insert into tasks(nameoftask,ordertime,deadline,price,customername,employeename) values('{obj.NameOfTask}','{obj.OrderDate}','{obj.DeadLine}',{obj.Price},'{obj.CustomerName}','{obj.EmployeeName}')";
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            if (effectRofsInsert > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();
            return obj;
        }
        public int Delete()
        {
            Console.Write("Enter Id "); int Id = int.Parse(Console.ReadLine() ?? "");
            string? Command = $@"delete from tasks where id={Id}";
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            if (effectRofsInsert > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();
            return Id;
        }
        public void Truncate()
        {
            string? Command = @"Truncate tasks";
            Console.WriteLine("Do you want restart identification ?\n1 - Yes\n2 - No\nEnter your answer:");
            byte select = byte.Parse(Console.ReadLine() ?? "");
            if (select == 1) Command += "restart identity;";
            else if (select == 2) { }
            else Console.WriteLine("You enter wrong");

            int effectRofsInsert = managerForConnecting.Connecting(Command);
            Console.WriteLine("The command is executed");
            Console.ReadKey();
        }
        public int Update()
        {
            Console.Write("Enter Id "); int Id = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("What you want change :1-NameOfTask");
            byte select = byte.Parse(Console.ReadLine() ?? "");
            string name = "";
            if (select == 1)
            {
                Console.Write("Enter new name :");
                name = (Console.ReadLine() ?? "");
            }
            else { Console.WriteLine("wrong button enter again !!!"); }
            string? Command = $@"update tasks set nameoftask='{name}' where id={Id}";
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            if (effectRofsInsert > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();
            return Id;
        }
    }
}
