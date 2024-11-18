using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ATSProject.Models;

namespace ATSProject.Controllers;

public class HomeController : Controller
{

    public ViewResult Index()
    {
        return View("MyView");
    }
}
