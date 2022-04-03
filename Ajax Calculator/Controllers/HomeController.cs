using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ajax_Calculator.Models;

namespace Ajax_Calculator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<CalculatorController> _logger;

    public HomeController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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
