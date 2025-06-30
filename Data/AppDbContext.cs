using Microsoft.EntityFrameworkCore;
using TodoApp.Models;


namespace TodoApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TodoModel> Todos { get; set; }
    }
}