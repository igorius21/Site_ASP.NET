using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.Configuration;

namespace siteNew.Models
{
    static public class Database
    {
        static private MySqlConnection conn;
        static public string error { get; private set; }
        static public string query { get; private set; }

        static Database()
        {
            try
            {
                error = "";
                query = "OPEN CONNETION TO MYSQL";
                conn = new MySqlConnection(WebConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                conn = null;
            }
            
        }

        static public DataTable Select(string myquery)
        {
            if (IsError()) return null;
            try
            {
                query = myquery;
                DataTable table = new DataTable();
                MySqlCommand cmd = new MySqlCommand(myquery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            
        }

        static public bool IsError()
        {
            return error != "";
        }

        static public string Addslashes (string text)
        {
            return text.Replace("\'", "\\\'");
        }
    }
}