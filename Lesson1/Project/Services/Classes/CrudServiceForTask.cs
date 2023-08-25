using ADO.NET_LESSON_1.Lesson1.Project.Connection;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{

    public class CrudServiceForTask : CrudTaskInterface
    {
        EffectedRowsAllOperation effectedRowsAllOperation;
        SelectOperation selectOperation;
        ManagerForConnecting managerForConnecting;
        public CrudServiceForTask()
        {
             effectedRowsAllOperation = new();
             selectOperation = new();
             managerForConnecting = new();
        }
        public void Create()
        {
            Task obj = new Task();
          
            string? Command = $"insert into tasks(nameoftask,ordertime,deadline,price,customername,employeename) values('{obj.NameOfTask}','{obj.OrderDate}','{obj.DeadLine}',{obj.Price},'{obj.CustomerName}','{obj.EmployeeName}')";
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Delete()
        {
            Console.Write("Enter Id "); int Id = int.Parse(Console.ReadLine() ?? "");
            string? Command = $@"delete from tasks where id={Id}";
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            if (effectRofsInsert > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();

        }

        public IEnumerable<Task> GetAll()
        {
           
        }

        public void Truncate()
        {
            string? Command = @"Truncate tasks";
            selectOperation.SelectInTruncate(Command);
            int effectRofsInsert = managerForConnecting.Connecting(Command);
            effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Update()
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
            int effectRofsUpdate = managerForConnecting.Connecting(Command);
            effectedRowsAllOperation.Effect(effectRofsUpdate);
        }
    }
}
