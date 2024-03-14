using Microsoft.EntityFrameworkCore;
using ToDoList.Models;


namespace ToDoList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {   
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
