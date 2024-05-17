using Microsoft.EntityFrameworkCore;

namespace TarefeiroAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Tarefa> Tarefas { get; set; }

        public DbSet<TarefaTipo> TarefasTipo { get; set; }

        public DbSet<Status> Statuses { get; set; }

    }
}
