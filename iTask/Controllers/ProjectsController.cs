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
        Project? project = FindProject(id);
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
        Project? project = FindProject(id);
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


        return RedirectToAction("List"); 
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
        Project? project = FindProject(id);

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

    public IActionResult EditAssignment()
    {
        




        return View(_unitOfWork.assignments.GetAll());
    }

    public IActionResult RemoveAssignment (int? id) 
    {
        Assignment? assignment = FindAssignment(id);
        
        if (assignment == null)
        {
            return NotFound();
        }
        Project? project = FindProject(assignment.IdProject);
        
        if (assignment == null)
        {
            return NotFound();
        }
        
        // TOFIX:
        int idProject = assignment.IdProject;

        _unitOfWork.assignments.Remove(assignment);
        _unitOfWork.Save(); 

        return RedirectToAction("Details", new {id = idProject});
    }

    public IActionResult AssignmentUpgrade(int id)
    {
        Assignment assignment = FindAssignment(id); 
        if(assignment.assignmentStatus == AssignmentStatus.ToDo)
            assignment.assignmentStatus = AssignmentStatus.InProgress; 
        else assignment.assignmentStatus = AssignmentStatus.Done; 

        _unitOfWork.assignments.Update(assignment);
        _unitOfWork.Save();

        int? idProject = assignment.IdProject;

        if(idProject.HasValue){
            return RedirectToAction("Details", new {id = idProject});
        } 
        else return RedirectToAction("List");
    }

public IActionResult AssignmentDowngrade(int id)
    {
        Assignment assignment = FindAssignment(id); 
        if(assignment.assignmentStatus == AssignmentStatus.Done)
            assignment.assignmentStatus = AssignmentStatus.InProgress; 
        else assignment.assignmentStatus = AssignmentStatus.ToDo; 

        _unitOfWork.assignments.Update(assignment);
        _unitOfWork.Save(); 

        int? idProject = assignment.IdProject;
        if(idProject.HasValue){
            return RedirectToAction("Details", new {id = idProject});
        } 
        else return RedirectToAction("List");
    }
    public Project? FindProject(int? id)
    {
        if (id == null || id == 0)
        {
            return null;
        }
        Project? project = _unitOfWork.projects.Get(x => x.Id == id); 
        return project; 
    }

    public Assignment? FindAssignment (int? id)
    {
        if (id == null || id == 0)
        {
            return null;
        }
        Assignment? assignment = _unitOfWork.assignments.Get(x => x.Id == id); 
        return assignment; 

    }
    #endregion Task

    public IActionResult WorkInProgress()
    {
        return View(); 
    }
}

