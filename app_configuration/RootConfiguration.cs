
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace sqlitedb.app_configuration
{
    public class RootConfiguration
    {
       public SQLiteCommand cmd;
       public  SQLiteConnection con;
       public  DataTable dt=new DataTable();
        public SQLiteDataAdapter da;

       public SQLiteConnection  Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            con = new SQLiteConnection(connectionString);
            return con;
        }

        public  void openConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
        }

        public  void closeConnection()
        {
            if(con.State== ConnectionState.Closed)
            {
                con.Open();
                con.Close();
            }
            else
            {
                con.Close();
            }
        }
    }
}
