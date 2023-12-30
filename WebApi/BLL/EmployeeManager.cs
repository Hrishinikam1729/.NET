
namespace BLL;

using System;
using System.Collections.Generic;
using BOL;
using DAL;
public class EmployeeManager
{
    public static List<Employee> GetAllEmployees()
    {
        List<Employee> li = Dbmanager.GetAll();
        return li;
    }

    public static Object GetById(int id)
    {
        Object o = Dbmanager.GetBYID(id);
        return o;
    }

    public static object GetByNAme(string name)
    {
        Object o = Dbmanager.GetBYnaMe(name);
        return o;
    }
}