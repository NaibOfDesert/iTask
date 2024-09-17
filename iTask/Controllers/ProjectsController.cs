using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iTask.Models;

namespace iTask.Controllers;

public class ProjectsController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;


    public ProjectsController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult List()
    {
        List<Project> projects = _unitOfWork.projects.GetAll();

        return View(projects);
    }
}

