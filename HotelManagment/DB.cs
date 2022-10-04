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
        // Bazaga ulanish ishlari
        string strBaza= "Server=localhost;Port=5432;Database=HotelManagment;User Id=postgres;Password=yashinov173;";
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        private void connection()
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = strBaza;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^

        // Ma'lumot olish uchun maxsus metod
        public DataTable getData(string sql)
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
        public DataTable getUsers()
        {
            DataTable table = new DataTable();
            table = getData("SELECT * FROM users");
            return table;
        }
        public DataRow getUsernsmePassword(string username)
        {
            DataTable table = new DataTable();
            try
            {
                table = getData($"SELECT username, password FROM users where username='{username}'");
                return table.Rows[0];
            }
            catch (Exception)
            {
                DataRow row;
                row = table.NewRow();
                row["username"] = string.Empty;
                row["password"] = string.Empty;
                return row;
            }
        }
        public DataRow getClient(string pasport)
        {
            DataTable table = new DataTable();
            try
            {
                table = getData($"SELECT * FROM client WHERE cl_pasport='{pasport}'");
                return table.Rows[0];
            }
            catch (Exception)
            {
                DataRow row;
                row = table.NewRow();
                row["cl_id"] = 0;
                row["cl_firstname"] = string.Empty;
                row["cl_lastname"] = string.Empty;
                row["cl_pasport"] = string.Empty;
                row["cl_phone"] = string.Empty;
                row["cl_adress"] = string.Empty;
                return row;
            }
        }
        public DataRow getRoom(string roomnumber)
        {
            DataTable table = new DataTable();
            try
            {
                table = getData($"SELECT * FROM room WHERE rm_number='{roomnumber}'");
                return table.Rows[0];
            }
            catch (Exception)
            {
                DataRow row;
                row = table.NewRow();
                row["rm_number"] = 0;
                row["rm_phone"] = string.Empty;
                row["rm_type"] = string.Empty;
                row["rm_free"] = string.Empty;
                return row;
            }
        }
        public DataTable getClients()
        {
            DataTable table = new DataTable();
            table = getData($"SELECT * FROM client");
            return table;
        }
        //^^^^^^^^^^^^^^^^^^^^^

        // Qo'shish uchun maxsus metodlar
        public bool addUser(string username, string email, string phone, string date, string password)
        {
            try
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
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool addClient(string firstname, string lastname, string pasport, string phone, string adress)
        {
            try
            {
                connection();
                string command = $"INSERT INTO client (cl_firstname, cl_lastname, cl_pasport, cl_phone, cl_adress) " +
                    $"VALUES('{firstname}', '{lastname}', '{pasport}', '{phone}', '{adress}')";
                using (var cmd = new NpgsqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool addRoom(string number, string phone, string type, string free)
        {
            try
            {
                connection();
                string command = $"INSERT INTO room (rm_number, rm_phone, rm_type, rm_free) " +
                    $"VALUES('{number}', '{phone}', '{type}', '{free}')";
                using (var cmd = new NpgsqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^

        // Update metodlar
        public bool updateUser(string username, string setusername, string setpassword)
        {
            try
            {
                connection();
                if (getUsernsmePassword(setusername)[0] == string.Empty)
                {
                    string command = $"UPDATE users SET username=@setusername, password=@setpassword WHERE username=@username";
                    using (var cmd = new NpgsqlCommand(command, conn))
                    {
                        cmd.Parameters.AddWithValue("setusername", setusername);
                        cmd.Parameters.AddWithValue("setpassword", setpassword);
                        cmd.Parameters.AddWithValue("username", username);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                else
                    return false;
                
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool updateClient(string pasport, string setfirstname, string setlastname, string setpasport, string setphone, string setadress)
        {
            try
            {
                connection();
                string command = $"UPDATE client SET cl_firstname='{setfirstname}', cl_lastname='{setlastname}', cl_pasport='{setpasport}'," +
                    $"cl_phone='{setphone}', cl_adress='{setadress}' WHERE cl_pasport='{pasport}'";
                using (var cmd = new NpgsqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^

        // Delete metodlar
        public bool deleteUser(string username)
        {
            try
            {
                if (getUsernsmePassword(username)[0] != string.Empty)
                {
                    string command = $"DELETE FROM users WHERE username='{username}'";
                    using (var cmd = new NpgsqlCommand(command, conn))
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteClient(string pasport)
        {
            try
            {
                connection();
                string command = $"DELETE FROM client WHERE cl_pasport='{pasport}'";
                using (var cmd = new NpgsqlCommand(command, conn))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^

        // Qo'shimcha ma'lumotlar
        // Update 
        // UPDATE users SET password = '??????' WHERE id = ?;
    }
}
