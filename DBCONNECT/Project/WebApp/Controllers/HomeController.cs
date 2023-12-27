using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using person;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   Person pr1 = new Person(1,"Hrishi","Nikam");
        Person pr2 = new Person(2,"Rishit","Ambalia");        
        List<Person> friends = new List<Person>();
        friends.Add(pr1);
        friends.Add(pr2);
        this.ViewData["ifriends"] = friends;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
