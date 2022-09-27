using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace HotelManagment
{
    internal class DB
    {
        string strBaza= "Server=localhost;Port=5432;Database=HotelManagment;User Id=postgres;Password=yashinov173;";
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        private DataTable getData(string sql)
        {
            DataTable table = new DataTable();
            connection();
            cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }

        private void connection()
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = strBaza;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void setData(string sql)
        {
            connection();
            cmd = new NpgsqlCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void addUser(string username, string email, string phone, string date, string password)
        {
            connection();
            string commandText = $"INSERT INTO users (username, email, phone, date, password, admin)" +
                $" VALUES (@username, @email, @phone, '{date}', @password, @admin)";
            using (var cmd = new NpgsqlCommand(commandText, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("admin", "0");

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getUsers()
        {
            DataTable table = new DataTable();
            table = getData("SELECT * FROM users");
            return table;
        }

        public DataRow getUsernsmePassword(string username)
        {
            DataTable table = new DataTable();
            table = getData($"SELECT username, password FROM users where username='{username}'");

            try
            {
                return table.Rows[0];
            }
            catch (Exception)
            {

                DataRow row;
                row = table.NewRow();
                row["username"] = "";
                row["password"] = "";
                return row;

            }
        }

        // Update 
        // UPDATE users SET password = '??????' WHERE id = ?;
    }
}
