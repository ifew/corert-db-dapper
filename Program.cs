using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log: Start Connection");

            string configDB = "server=localhost;userid=root;password=1234;database=lab;convert zero datetime=True;";

            using (MySqlConnection _connection = new MySqlConnection(configDB))
            {  
                Console.WriteLine("Log: _connection.ConnectionString: " + _connection.ConnectionString);
                Console.WriteLine("Log: _connection.ToString: " + _connection.ToString());

                if (_connection.State == ConnectionState.Closed)  
                    _connection.Open();  
                
                Console.WriteLine("Log: ServerVersion After Open: " + _connection.ServerVersion);
                Console.WriteLine("Log: State: " + _connection.State.ToString());

                string sqlQuery = "SELECT * FROM member";
                var result = _connection.Query<Member>(sqlQuery);
                
                Console.WriteLine("Log: Result Count: " + result.Count() + "\n");
                Console.WriteLine("Log: Result: " + JsonConvert.SerializeObject(result.ToList()));
            } 
        }
    }

    [Table("member")]
    public class Member
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

    }
}
