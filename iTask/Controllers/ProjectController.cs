using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iTask.Models; 

public class ProjectController : Controller
{
    private readonly ILogger<ProjectController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public ProjectController(ILogger<ProjectController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public ActionResult Index(){
        return View();
    }

    public ActionResult Project(){
        return View();
    }

}