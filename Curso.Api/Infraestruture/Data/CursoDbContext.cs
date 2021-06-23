using Curso.Api.Business.Entities;
using Curso.Api.Infraestruture.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Curso.Api.Infraestruture.Data
{
    public class CursoDbContext : DbContext
    {
        private DbContextOptionsBuilder<CursoDbContext> options;

        public CursoDbContext(DbContextOptions<CursoDbContext> options):base(options)
        {

        }

        public CursoDbContext(DbContextOptionsBuilder<CursoDbContext> options)
        {
            this.options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
