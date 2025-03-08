using Microsoft.AspNetCore.Mvc;
using myTodoList.Models;
using myTodoList.Services;

namespace myTodoList.Controllers;

public class TodoController : Controller
{
    private readonly TodoService _todoService;

    public TodoController(TodoService todoService)
    {
        _todoService = todoService;
    }

    public IActionResult Index()
    {
        var todos = _todoService.GetAll();
        return View(todos); // Pass list to View
    }

    [HttpPost]
    public IActionResult Add(string title,string description)
    {
        if (!string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(title))
        {
            _todoService.Add(new TodoItem { Description = description,
                                            Title = title});
        }
        return RedirectToAction("Index");
    }

    public IActionResult ToggleComplete(int id)
    {
        _todoService.ToggleComplete(id);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        _todoService.Delete(id);
        return RedirectToAction("Index");
    }
}
