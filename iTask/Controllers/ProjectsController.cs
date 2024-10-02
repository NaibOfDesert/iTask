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
    public IActionResult Edit(Project project)
    {
        return View(); 
    }

    public IActionResult AddTask(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        Project? project = _unitOfWork.projects.Get(x => x.Id == id); 
        if (project == null){
            return NotFound();
        }

        // TODO: set indivudual id
        Task tast = new Task{
            Id = 77,
            Name = "Task",
            projectAffiliation = project 
        };
        return View("Details", project); 
    }
    

    public IActionResult DetailsTask(){

        return View("Details(1)");
    }
}

