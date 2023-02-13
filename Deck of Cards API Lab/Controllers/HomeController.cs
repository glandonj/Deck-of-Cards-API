using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deck_of_Cards_API_Lab.Models;
using System.Reflection;

namespace Deck_of_Cards_API_Lab.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
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

    public IActionResult Card()
    {
        return View(CardDAL.GetCards("new"));
    }

    [HttpPost]

    public IActionResult Card(string id)
    {
        return View(CardDAL.GetCards(id));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

