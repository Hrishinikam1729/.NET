namespace DAL.DisConnected;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

public class DBManager{
    public static string conString= "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";

    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments = new List<Department>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        DataSet ds = new DataSet();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
        string query = "select * from department";
        cmd.CommandText = query;
        MySqlDataAdapter da = new MySqlDataAdapter();
        da.SelectCommand = cmd;
        da.Fill(ds);

        DataTable dt = ds.Tables[0];
        DataRowCollection rows = dt.Rows;
        foreach(DataRow row in rows){
            int id = int.Parse(row["id"].ToString());
            string name = row["name"].ToString();
            string location = row["location"].ToString();
            Department dept = new Department{Id = id,Name =  name,Location = location};
            allDepartments.Add(dept);
        }
         

        return allDepartments;
    }









}