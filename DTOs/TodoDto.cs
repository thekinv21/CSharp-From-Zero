using System.Text.Json.Serialization;
using TodoApp.Enum;

namespace TodoApp.DTOs;

public class TodoDto
{
    [JsonPropertyName(name: "id")] public int Id { get; set; }

    [JsonPropertyName(name: "title")] public string? Title { get; set; }

    [JsonPropertyName(name: "description")]
    public string? Description { get; set; }

    [JsonPropertyName(name: "priorityId")] public Priority PriorityId { get; set; }

    [JsonPropertyName(name: "priorityText")]
    public Priority PriorityText { get; set; }

    [JsonPropertyName(name: "isComplete")] public bool IsComplete { get; set; } = false;

    [JsonPropertyName(name: "order")] public int Order { get; set; }
}