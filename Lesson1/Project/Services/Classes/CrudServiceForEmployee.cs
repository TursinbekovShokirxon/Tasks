using ADO.NET_LESSON_1.Lesson1.Project.Models;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Crud;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
   internal class CrudServiceForEmployee : CrudEmployeeInterface
    {
        IList<Employee> tasks = new List<Employee>();
        public void Create()
        {
            Employee employee = new Employee();
            employee = AllBuilders.ServiceForRead.Read(employee);
            string insert = $"insert into employee(employeefirstname,employeelastname,age,email,experience) values('{employee.FirstName}','{employee.LastName}',{employee.Age},'{employee.Email}',{employee.Experience})";
            int effect = AllBuilders.managerForConnecting.Connecting(insert);
            AllBuilders.effectedRowsAllOperation.Effect(effect);
        }
        public void Delete()
        {
            List<Employee> employees = (List<Employee>)GetAll();
            if (employees.Count() > 0)
            {
                ForEach.ForEachForEmployee();
                Console.Write("Enter employee_id which one you want delete :");
                int id = int.Parse(Console.ReadLine() ?? "");
                string delete = $"delete from employee where employee_id={id}";
                int effect = AllBuilders.managerForConnecting.Connecting(delete);
                AllBuilders.effectedRowsAllOperation.Effect(effect);
            }
            else  Console.WriteLine("Nothing for deleting!!!");
            Console.ReadKey();
        }
        public IEnumerable<Employee> GetAll()
        {
            Employee employee = new Employee();
            tasks = (IList<Employee>)AllBuilders.managerForConnecting.Connecting(employee);
            return tasks;
        }
        public void Truncate()
        {
            string? Command = @"Truncate employee";
            Command = AllBuilders.selectOperation.SelectInTruncate(Command);
            int effectRofsInsert = AllBuilders.managerForConnecting.Connecting(Command);
            AllBuilders.effectedRowsAllOperation.Effect(effectRofsInsert);
        }
        public void Update()
        {
            List<Employee> employees = (List<Employee>)GetAll();
            if (employees.Count() > 0)
            {
                ForEach.ForEachForCustomer();
                Console.Write("Enter employee_id which one you want update :");
                int id = int.Parse(Console.ReadLine() ?? "");
                Employee employee = new();
                employee = AllBuilders.ServiceForRead.Read(employee);
                string update = $"update employee set employeefirstname='{employee.FirstName}',employeelastname='{employee.LastName}',age={employee.Age},email='{employee.Email}',experience={employee.Experience} where employee_id={id}";
                int effect = AllBuilders.managerForConnecting.Connecting(update);
                AllBuilders.effectedRowsAllOperation.Effect(effect);
            }
            else Console.WriteLine("Nothing for updating!!!");
            Console.ReadKey();
        }
    }
}
