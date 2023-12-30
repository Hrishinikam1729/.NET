using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;

namespace Controller;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly ILogger<EmployeeController> _logger;
    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        List<Employee> emps = EmployeeManager.GetAllEmployees();
        return emps.ToArray();
    }

    [HttpGet("{id}")]
    public Object GetById(int id)
    {
        Object emp = EmployeeManager.GetById(id);
        return emp;

    }
    // [HttpGet("{Name}")]
    // public Object GetByName(string name)
    // {
    //     Object emp = EmployeeManager.GetByNAme(name);
    //     return emp;
    // }
}