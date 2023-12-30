using MySql.Data.MySqlClient;
using System.ComponentModel.Design;
using BOL;

namespace DAL;
public class Dbmanager
{
    public static string conString = "server=192.168.10.150;;port=3306;user=dac2; password=welcome;database=dac2";

    public static List<Employee> GetAll()
    {
        List<Employee> list1 = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from Employee";

        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int empid = int.Parse(reader["EmpID"].ToString());
                string name = reader["Name"].ToString();
                string dept = reader["Department"].ToString();
                double salary = double.Parse(reader["Salary"].ToString());
                string emptype = reader["EmpType"].ToString();
                Employee emp = new Employee
                {
                    EmpID = empid,
                    Name = name,
                    Department = dept,
                    Salary = salary,
                    EmpType = emptype,
                };
                list1.Add(emp);
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            con.Close();
        }
        return list1;
    }

    public static Object GetBYID(int id)
    {
        List<Employee> list2 = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from Employee";

        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int empid = int.Parse(reader["EmpID"].ToString());
                string name = reader["Name"].ToString();
                string dept = reader["Department"].ToString();
                double salary = double.Parse(reader["Salary"].ToString());
                string emptype = reader["EmpType"].ToString();
                Employee emp = new Employee
                {
                    EmpID = empid,
                    Name = name,
                    Department = dept,
                    Salary = salary,
                    EmpType = emptype,
                };
                list2.Add(emp);
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            con.Close();
        }

        var result = from emp in list2
                     where emp.EmpID.Equals(id)
                     select new { emp.EmpID, emp.Name, emp.Salary, emp.Department, emp.EmpType };
        return result;
    }

    public static object GetBYnaMe(string NaMe)
    {
        List<Employee> list3 = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        string query = "select * from Employee";

        try
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int empid = int.Parse(reader["EmpID"].ToString());
                string name = reader["Name"].ToString();
                string dept = reader["Department"].ToString();
                double salary = double.Parse(reader["Salary"].ToString());
                string emptype = reader["EmpType"].ToString();
                Employee emp = new Employee
                {
                    EmpID = empid,
                    Name = name,
                    Department = dept,
                    Salary = salary,
                    EmpType = emptype,
                };
                list3.Add(emp);
            }
        }
        catch (Exception ee)
        {
            Console.WriteLine(ee.Message);
        }
        finally
        {
            con.Close();
        }

        var result1 = from emps1 in list3
                     where emps1.EmpID.Equals(NaMe)
                     select new { emps1.EmpID, emps1.Name, emps1.Salary, emps1.Department, emps1.EmpType };
        return result1;

    }
}
