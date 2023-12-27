namespace BLL;
using BOL;
using DAL.DisConnected;


public class HRManager{
    public static List<Department> GetAllDepartments(){
    List<Department> Departments = new List<Department>();
    Departments = DBManager.GetAllDepartments();
    return Departments; 
    }
}