using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AgriApp.Models;
using pclass;

namespace AgriApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Product p1 = new Product();
        p1.Pid = 1;
        p1.Name = "Rotavator";
        p1.Quantity = 5;
        p1.Price = 70000.4F;
        p1.Description = "fg";
        p1.Imageurl = "/images/Rotavator.jpg";
        ViewData["Product1"] = p1;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
