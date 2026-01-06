using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD_APP_.Models;

namespace CRUD_APP_.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
 // admin dashboard 
    public IActionResult Dashboard()
    {
        return View("~/Views/Admin/Dashboard.cshtml", new Adminhomedashboard()); 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}