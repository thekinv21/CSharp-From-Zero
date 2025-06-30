using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;

public class TodoModel:BaseModel
{
    public int Id { get; set; }

    [Required] [StringLength(100)] public string? Title { get; set; }

    [Required] [StringLength(400)] public string? Description { get; set; }

    public bool IsComplete { get; set; }
}