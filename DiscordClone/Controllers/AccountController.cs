using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiscordClone.Models;

namespace DiscordClone.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
     public IActionResult SignUp()
    {
        return  View();
    }
}
