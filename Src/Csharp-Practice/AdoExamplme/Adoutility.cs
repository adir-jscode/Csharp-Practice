using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoExamplme
{
    public class Adoutility
    {
        private readonly string _connection;

        public Adoutility(string connecation)
        {
            _connection = connecation;
        }

        public void ExecuteQuery(string query,Dictionary<string, object> parameters)
        {
            
           using SqlCommand command = CreateCommand(query, parameters);

            
            int effection = command.ExecuteNonQuery();

            //connection.Close();
            //command.Dispose();
            //connection.Dispose();
        }

        public IList<Dictionary<string, object>> GetData(string query,Dictionary<string,object> parameters) 
        {
            using SqlCommand command = CreateCommand(query, parameters);
            using SqlDataReader reader = command.ExecuteReader();

            
            List<Dictionary<string,object>> item = new List<Dictionary<string,object>>();
            while (reader.Read())
            {
                Dictionary<string, object> data = new Dictionary<string, object>();

                for (int i=0; i<reader.FieldCount; i++)
                {
                    data.Add(reader.GetName(i), reader.GetValue(i));
                }
                //int id = (int)reader["Id"];
                //string address =(string) reader["Address"];

                item.Add(data);
                
            }
            return item;
        }

        

        private SqlCommand CreateCommand(string query, Dictionary<string, object> parameters)
        {
             SqlConnection connection = new SqlConnection(_connection);

             SqlCommand command = new SqlCommand(query, connection);

            foreach (var parameter in parameters)
            {
                command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            
            return command;

        }

    }
}
