using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace course_work.DBO
{
    class DBController
    {
        public string ConnectionString { get; private set; }
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private DataTable dt;

        public DBController()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(ConnectionString);
        }
        public void InsertResult(string name, string weaponType, int shots, float totalScore, string targetType)
        {
            connection.Open();
            string sql = "INSERT INTO Results(PlayerName, WeaponType, Shots, Score, TargetType) VALUES(" +
                "@name, @weaponType, @shots, @totalScore, @targetType)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@weaponType", weaponType);
            command.Parameters.AddWithValue("@shots", shots);
            command.Parameters.AddWithValue("@totalScore", totalScore);
            command.Parameters.AddWithValue("@targetType", targetType);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void GetResults()
        {
            connection.Open();
            string sql = "SELECT * FROM Results";

            adapter = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            adapter.Fill(ds);
            dt = ds.Tables[0];
            connection.Close();

            foreach (DataColumn column in dt.Columns)
                Console.Write("\t{0}", column.ColumnName);
            Console.WriteLine();
            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }
        }
    }
}
