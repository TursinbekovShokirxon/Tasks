using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_LESSON_1.Lesson1.Project.Connection
{
    internal class ManagerForConnecting
    {
        
       private static string path = @"../../../Lesson1/Project/Connection/FileForConnect/Connecter.json";

        public int Connecting(string comm)
        {
             string connect = File.ReadAllText(path);
            int EffectRows = 0;
            using NpgsqlConnection conn = new NpgsqlConnection(connect);
            conn.Open();
            NpgsqlCommand Command = new NpgsqlCommand(comm, conn);
            EffectRows=Command.ExecuteNonQuery();
            conn.Close();
            return EffectRows;  
        }
    }
}
