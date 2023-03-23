using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository {
    public class Context : DbContext {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=prova");
    }
}