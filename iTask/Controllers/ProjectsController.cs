using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iTask.Models;
using System.Linq.Expressions;

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

    [HttpPost]
    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Details(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Project? project = _unitOfWork.projects.Get(x => x.Id == id); 
        if (project == null){
            return NotFound();
        }
        return View(project); 
    }

    [HttpPost]
    public IActionResult Details(Project project)
    {
        return View(); 
    }

    public IActionResult Edit(int? id)
    {
        Project? project = FindProject(id, x => x.Id == id);
        if (project == null){
            return NotFound();
        }
        return View(project); 
    }

    [HttpPost]
    public IActionResult Edit(Project project)
    {
        return View(); 
    }
    public IActionResult ListAssignment()
    {
        List<Assignment> assignments = _unitOfWork.assignments.GetAll();

        return View(assignments);
    }
    public IActionResult AddAssignment(int? id)
    {
        Project? project = FindProject(id, x => x.Id == id);
        if (project == null){
            return NotFound();
        }

        Assignment tast = new Assignment{
            Id = 77,
            IdProject = project.Id,
            Name = "Task"
        };

        _unitOfWork.assignments.Add(tast);
        _unitOfWork.Save(); 
        return View("Details", project);
    }
    

    public IActionResult DetailsAssignment(){

        return View("Details(1)");
    }

    public Project? FindProject(int? id, Expression<Func<Project, bool>> filter)
    {
        if (id == null || id == 0)
        {
            return null;
        }
        Project? project = _unitOfWork.projects.Get(filter); 
        return project; 

    }
}

