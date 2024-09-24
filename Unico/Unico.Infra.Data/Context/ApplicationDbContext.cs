using Microsoft.EntityFrameworkCore;
using Unico.Domain.Entities;
using Unico.Infra.Data.Mapping;

namespace Unico.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Tarefa> Tarefa { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tarefa>(new TarefaMap().Configure);
        }
    }
}
