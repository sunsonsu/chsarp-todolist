using myTodoList.Models;

namespace myTodoList.Services;

public class TodoService{

    private readonly List<TodoItem> _todos = new();

    public List<TodoItem> GetAll(){
        return _todos;
    }
    //this method is to Add a new item into a Todo List
    public void Add(TodoItem item){
        item.Id = _todos.Count + 1;
        _todos.Add(item);
    }
    //this method is toggle a status of a Todo Item
    public void ToggleComplete(int id){
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null){
            todo.IsCompleted = !todo.IsCompleted;
        }
    }
    //this method is to delete a Todo Item
    public void Delete(int id){
        var todo = _todos.FirstOrDefault(t => t.Id == id);
        if (todo != null){
            _todos.Remove(todo);
        }
    }
}