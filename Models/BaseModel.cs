namespace TodoApp.Models;

public class BaseModel
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }
    public string? CreatedBy { get; set; } 
    public string? UpdatedBy { get; set; }
}