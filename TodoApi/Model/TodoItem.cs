namespace TodoApi.Model;

public class TodoItem
{
    public uint TodoItemId { get; set; }

    public string? Task { get; set; }
    public string? Instructions { get; set; }
    public int Priorities { get; set; } = 1;

    public DateTime? Deadline { get; set; }



    public bool IsComplete { get; set; } = false;
}