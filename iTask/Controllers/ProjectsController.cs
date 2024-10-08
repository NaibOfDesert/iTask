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

    #region Project
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

        ProjectCard projectCard = new ProjectCard(project, _unitOfWork.assignments.GetAll(x => x.IdProject == project.Id)); 
        return View(projectCard); 
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

    public IActionResult Edit(Project project)
    {
        return View(); 
    }
    
    public IActionResult Remove(int? id)
    {
        Project? project = FindProject(id, x => x.Id == id);
        if (project == null){
            return NotFound();
        }
        
        List<Assignment> assignments= _unitOfWork.assignments.GetAll(x => x.IdProject == project.Id);
        if (assignments != null)
        {
            foreach(Assignment a in assignments){
                _unitOfWork.assignments.Remove(a);
                project.Assignments.Remove(a);
            }
        }
        _unitOfWork.projects.Remove(project);
        _unitOfWork.Save(); 

        return View("List"); 
    }
    #endregion

    #region Task
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

        Assignment task = new Assignment{
            IdProject = project.Id,
            Name = "Task"
        };

        _unitOfWork.projects.AddAssignment(project, task);
        _unitOfWork.projects.Update(project);
        _unitOfWork.assignments.Add(task);

        _unitOfWork.Save(); 


        return View("Details", project);
    }

    public IActionResult DetailsAssignment()
    {
        return View(_unitOfWork.assignments.GetAll());
    }

    public IActionResult RemoveAssignment (int? id) 
    {
        Assignment? assignment = FindAssignment(id, x => x.Id == id);
        
        if (assignment == null)
        {
            return NotFound();
        }
        Project? project = FindProject(assignment.IdProject, x => x.Id == assignment.IdProject);
        
        if (assignment == null)
        {
            return NotFound();
        }

        _unitOfWork.assignments.Remove(assignment);
        _unitOfWork.Save(); 

        return View("Details", project);
    }

    public IActionResult WorkInProgress(){
        return View(); 
    }

    public IActionResult AssignmentUpgrade(int? id)
    {
        if(id == null || id == 0)
        {
            return NotFound();
        }

        Assignment? assignment = FindAssignment(id, x => x.Id == id);
        
        if (assignment == null)
        {
            return NotFound();
        }
        Project? project = FindProject(assignment.IdProject, x => x.Id == assignment.IdProject);
        
        if (assignment == null)
        {
            return NotFound();
        }
        // TODO: refresh
        return View();
    }

public IActionResult AssignmentDowngrade(int? id)
    {
       
        return View();
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

    public Assignment? FindAssignment (int? id, Expression<Func<Assignment, bool>> filter)
    {
        if (id == null || id == 0)
        {
            return null;
        }
        Assignment? assignment = _unitOfWork.assignments.Get(filter); 
        return assignment; 

    }
    #endregion Task
}

