using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iTask.Models;

namespace iTask.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        // _unitOfWork = unitOfWork;

    }

    public IActionResult Index()
    {
        // IEnumerable<Task> taskList = _unitOfWork.tasks.GetAll();
        // return View(taskList);
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

