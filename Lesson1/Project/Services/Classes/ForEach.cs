using ADO.NET_LESSON_1.Lesson1.Project.Models;

namespace ADO.NET_LESSON_1.Lesson1.Project.Services.Classes
{
    public class ForEach
    {
        public static void ForEachForTask()
        {
            IEnumerable<Models.Task> tasks = AllBuilders.crudServiceForTask.GetAll();
            string allinformation = "";
            foreach (var task in tasks)
            {
                allinformation = task.ToString();
                Console.WriteLine(allinformation);
            }
            Console.ReadKey();
        }
        public static void ForEachForEmployee()
        {
            IEnumerable<Employee> employees = AllBuilders.crudServiceForEmployee.GetAll();
            string allinformation = "";
            foreach (var employee in employees)
            {
                allinformation = employee.ToString();
                Console.WriteLine(allinformation);
            }
            Console.ReadKey();
        }
        public static void ForEachForCustomer()
        {
            IEnumerable<Customer> customers = AllBuilders.crudServiseForCustomer.GetAll();
            string allinformation = "";
            foreach (var customer in customers)
            {
                allinformation = customer.ToString();
                Console.WriteLine(allinformation);
            }
            Console.ReadKey();
        }

    }
}
