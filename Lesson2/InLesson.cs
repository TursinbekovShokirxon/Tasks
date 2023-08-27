using ADO.NET_LESSON_1.Lesson1.Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;
namespace ADO.NET_LESSON_1.Lesson2
{
    internal class InLesson
    {
        public static void StartUp()
        {

            foreach (var item in GetAll())
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static IEnumerable<Task> GetAll()
        {
            ICollection<Task> Tasks = new List<Task>();
            using NpgsqlConnection connection = new(@"Server=localhost;Port=5432;Database=new;User id=postgres;password=adminadmin");
            connection.Open();
            string command = @"select * from tasks";
            NpgsqlCommand npgsqlCommand = new(command, connection);
            NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Tasks.Add(new()
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
            return Tasks;
        }
       
    }
}
