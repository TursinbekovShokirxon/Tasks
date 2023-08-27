using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{

    public class CrudServiceForTask : CrudTaskInterface
    {

        IList<Task> tasks = new List<Task>();
        public void Create()
        {
            Task obj = new Task();
            obj = AllBuilders.ServiceForRead.Read(obj);
            string? Command = $"insert into tasks(nameoftask,ordertime,deadline,price,customer_id,employee_id) values('{obj.NameOfTask}','{obj.OrderDate}','{obj.DeadLine}',{obj.Price},'{obj.customerid}','{obj.employeeid}')";
            int effectRofsInsert = AllBuilders.managerForConnecting.Connecting(Command);
            AllBuilders.effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Delete()
        {
            Console.Write("Enter Id "); int Id = int.Parse(Console.ReadLine() ?? "");
            string? Command = $@"delete from tasks where id={Id}";
            int effectRofsInsert = AllBuilders.managerForConnecting.Connecting(Command);
            if (effectRofsInsert > 0) Console.WriteLine("The command is executed");
            else Console.WriteLine("The command isn't executed");
            Console.ReadKey();
        }

        public IEnumerable<Task> GetAll()
        {
            Task task = new Task();
            tasks = (IList<Task>)AllBuilders.managerForConnecting.Connecting(task);
            return tasks;
        }

        public void Truncate()
        {
            string? Command = @"Truncate tasks";
            AllBuilders.selectOperation.SelectInTruncate(Command);
            int effectRofsInsert = AllBuilders.managerForConnecting.Connecting(Command);
            AllBuilders.effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Update()
        {
            Task task = new();
            List<Task> tasks = (List<Task>)GetAll();
            task = AllBuilders.ServiceForRead.Read(task);
            if (tasks.Count() > 0)
            {
                Console.Write("Enter Id "); int Id = int.Parse(Console.ReadLine() ?? "");
                string? Command = $@"update tasks set nameoftask='{task.NameOfTask}',ordertime='{task.OrderDate}',deadline='{task.DeadLine}',price={task.Price},employee_id={task.employeeid},customer_id={task.customerid} where id={Id}";
                int effectRofsUpdate = AllBuilders.managerForConnecting.Connecting(Command);
                AllBuilders.effectedRowsAllOperation.Effect(effectRofsUpdate);
            }
            else Console.WriteLine("Nothing update");
        }
    }
}
