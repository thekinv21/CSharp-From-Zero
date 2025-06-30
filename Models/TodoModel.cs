using System.ComponentModel.DataAnnotations;
using TodoApp.Enum;

namespace TodoApp.Models;

public class TodoModel : BaseModel
{
    public int Id { get; set; }

    [StringLength(100)] public string? Title { get; set; }

    [StringLength(400)] public string? Description { get; set; }

    public Priority Priority { get; set; }

    public bool IsComplete { get; set; } = false;

    public int Order { get; set; }
}