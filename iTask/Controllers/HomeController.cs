using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iTask.Models;

namespace iTask.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;

    }

    public IActionResult Index()
    {
        // List<Task> taskList = _unitOfWork.tasks.GetAll();
        IEnumerable<Assignment> assignmentList = new List<Assignment>{ new Assignment {Id = 1}};
        
        return View(assignmentList);
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

