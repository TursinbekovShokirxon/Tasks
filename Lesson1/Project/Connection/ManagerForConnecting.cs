using ADO.NET_LESSON_1.Lesson1.Project.Models;
using ADO.NET_LESSON_1.Lesson1.Project.Services.Interface.Other;
using Npgsql;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;

namespace ADO.NET_LESSON_1.Lesson1.Project.Connection
{
    internal class ManagerForConnecting: ConnectionInterface<Task,Employee,Customer>
    {
        public readonly static string path = @"../../../Lesson1/Project/Connection/FileForConnect/Connecter.json";
        public readonly static string connect = File.ReadAllText(path);
        public int Connecting(string comm)
        {
            int EffectRows = 0;
            using NpgsqlConnection conn = new NpgsqlConnection(connect);
            conn.Open();
            NpgsqlCommand Command = new NpgsqlCommand(comm, conn);
            EffectRows = Command.ExecuteNonQuery();
            conn.Close();
            return EffectRows;  
        }
        public IEnumerable<Task> Connecting(Task type)
        {
            IList <Task> tasks = new List<Task>();
            string command = "select * from tasks";
            using NpgsqlConnection connection = new(connect);
            connection.Open();
            NpgsqlCommand npgsqlCommand = new(command, connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                tasks.Add(new()
                {
                    customerid = (int)reader["customer_id"],
                    Id = (int)reader["Id"],
                    DeadLine = (string)reader["deadline"],
                    OrderDate = (string)reader["ordertime"],
                    employeeid = (int)reader["employee_id"],
                    NameOfTask = (string)reader["nameoftask"],
                    Price = (float)reader["price"]
                });
            }
            connection.Close();
            return tasks;
        }
        public IEnumerable<Employee> Connecting(Employee type)
        {
            IList<Employee> employees = new List<Employee>();
            string command = "select * from employee;";
            using NpgsqlConnection connection = new(connect);
            connection.Open();
            NpgsqlCommand npgsqlCommand = new(command, connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                employees.Add(new()
                {
                    Id = (int)reader["employee_id"],
                    FirstName = (string)reader["employeefirstname"],
                    LastName = (string)reader["employeelastname"],
                    Age = (int)reader["age"],
                    Email = (string)reader["email"],
                    Experience = (int)reader["experience"]
                });
            }
            connection.Close();
            return employees;
        }
        public IEnumerable<Customer> Connecting(Customer type)
        {
            IList<Customer> Customers = new List<Customer>();
            string command = "select * from customer;";
            using NpgsqlConnection connection = new(connect);
            connection.Open();
            NpgsqlCommand npgsqlCommand = new(command, connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customers.Add(new()
                {
                    Id = (int)reader["customer_id"],
                    FirstName = (string)reader["customerfirstname"],
                    LastName = (string)reader["customerlastname"],
                    Age = (int)reader["age"],
                    Email = (string)reader["email"]
                });
            }
            connection.Close();
            return Customers;
        }
    }
}
