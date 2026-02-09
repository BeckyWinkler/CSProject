using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiscordClone.Models;

namespace DiscordClone.Controllers;

public class ChatController : Controller
{
    string filePath = Path.Combine(Environment.CurrentDirectory, "FakeDB/MessageDB.txt");

    public IActionResult MessageList()
    {
        return View();
    }
}
