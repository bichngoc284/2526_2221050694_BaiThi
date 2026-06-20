using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2526_2221050694_BaiThi.Models;

namespace _2526_2221050694_BaiThi.Controllers;

public class TinhThanhController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}