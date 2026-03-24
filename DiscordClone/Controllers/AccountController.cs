using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiscordClone.Models;
using System.Data.Common;

namespace DiscordClone.Controllers;

public class AccountController : Controller
{
    //database connection
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    //display login form
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    //Log user in
    [HttpPost]
    public IActionResult Login(string userName, string userPassword)
    {
        var user = _context.AppUsers.FirstOrDefault(u => u.UserName == userName && u.UserPassword == userPassword);

        if(user != null)
        {
            HttpContext.Session.SetInt32("UserID", user.UserID);
            HttpContext.Session.SetString("UserName", user.UserName);

            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    //Log User Out
    [HttpGet]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear(); 
        return RedirectToAction("Login");
    }

    //display sign up form
    [HttpGet]
    public IActionResult SignUp()
    {
        
        return  View();
    }
    //handle form submission
    [HttpPost]
     public IActionResult SignUp(AppUser appUser)
    {
        if (ModelState.IsValid)
        {
            _context.AppUsers.Add(appUser);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        return  View(appUser);
    }
}
