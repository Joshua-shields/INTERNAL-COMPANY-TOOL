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

    public IActionResult Portal()
    {
        // Check if user is authenticated as admin
        var isAuthenticated = HttpContext.Session.GetString("IsAdminAuthenticated");
        
        if (isAuthenticated != "true")
        {
            // Redirect to login (Dashboard) if not authenticated
            return RedirectToAction("Dashboard");
        }
        
        return View("~/Views/Admin/Portal.cshtml", new Adminhomedashboard());
    }

    public IActionResult PortalU()
    {
        return View("~/Views/User/PortalU.cshtml", new User_model());
    }
    
    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult ViewTicket()
    {
        return View("~/Views/User/ViewTicket.cshtml", new User_model());
    }
    
    [HttpPost]
    public IActionResult Contact(string Name, string Email, string Subject, string Message)
    {
        // Here you would typically handle the contact form submission
        // For now, we'll just return to the contact page with a success message
        ViewBag.SuccessMessage = "Thank you for contacting us! We'll get back to you soon.";
        return View();
    }
 // admin dashboard
    public IActionResult Dashboard()
    {
        return View("~/Views/Admin/Dashboard.cshtml", new Adminhomedashboard()); 
    }
    
    // Handle admin login
    [HttpPost]
    public IActionResult Dashboard(string uname, string psw, string seceret)
    {
        if (!string.IsNullOrEmpty(uname) || !string.IsNullOrEmpty(psw) || !string.IsNullOrEmpty(seceret)){
            
            HttpContext.Session.SetString("IsAdminAuthenticated", "True");
        HttpContext.Session.SetString("IsAdminAuthenticated", uname);
        return RedirectToAction("Portal");
    }

    ViewBag.ErrorMessage = "Invalid credentials. Please try again.";
        return View("~/Views/Admin/Dashboard.cshtml", new Adminhomedashboard());    
    }

    
    
    // Logout action
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}