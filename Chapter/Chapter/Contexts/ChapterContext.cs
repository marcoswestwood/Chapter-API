using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
    public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        //vamos utilizar este metodo para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificacao
                optionsBuilder.UseSqlServer("Data Source = DELLG15\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        //DbSet representa as entidades que serao utilizadas nas operacoes de leitura, criacao, atualizacao e delecao. 
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
