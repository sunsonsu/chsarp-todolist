namespace myTodoList.Models;

public class TodoItem{
    public int Id { get; set; } //unique id
    public string Title { get; set; } = string.Empty; // task name
    public string Description { get; set; } = string.Empty; ///task
    public bool IsCompleted { get; set;} //task status
}