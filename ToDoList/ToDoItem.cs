public class ToDoItem
{
    public Guid id {get;set;} = Guid.NewGuid();
    public string Title {get;set;}
    public bool IsDone {get;set;}
}