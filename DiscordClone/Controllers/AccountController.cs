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

    public IActionResult Login()
    {
        return View();
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
