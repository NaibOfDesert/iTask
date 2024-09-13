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
        
        List<Project> projects = _unitOfWork.projects.GetAll();

        return View(projects);
    }

  
    public ActionResult Details(int id){
        return View(id);
    } 

    public ActionResult Assignments(){

        List<Assignment> assignments = _unitOfWork.assignments.GetAll();
        return View(assignments);
    }

    public ActionResult Ranks(){
        return View();
    }

}