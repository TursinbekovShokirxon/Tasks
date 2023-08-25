using ADO.NET_LESSON_1.Lesson1.Project.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = ADO.NET_LESSON_1.Lesson1.Project.Models.Task;

namespace ADO.NET_LESSON_1.Lesson1.Project.Connection
{
    internal class ManagerForConnecting
    {
        
       private readonly static string path = @"../../../Lesson1/Project/Connection/FileForConnect/Connecter.json";
       private readonly static string connect = File.ReadAllText(path);

        public int Connecting(string comm,int selection=0)
        {
            int EffectRows = 0;
            using NpgsqlConnection conn = new NpgsqlConnection(connect);
            conn.Open();
            NpgsqlCommand Command = new NpgsqlCommand(comm, conn);
            if (selection != 0)
            {
                NpgsqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    reade
                }
            }
            EffectRows = Command.ExecuteNonQuery();
            conn.Close();
            return EffectRows;  
        }
        public  Task ForTask()
        {
            Tasks.Add(new()
            {
                CustomerName = (string)reader["customername"],
                Id = (int)reader["Id"],
                DeadLine = (string)reader["deadline"],
                OrderDate = (string)reader["ordertime"],
                EmployeeName = (string)reader["employeename"],
                NameOfTask = (string)reader["nameoftask"],
                Price = (float)reader["price"]
            });
        } public  Employee ForEmployee()
        {

        } public  Customer ForCustomer()
        {

        }
    }
}
