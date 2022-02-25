using AppMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPessoa.Data
{
    public class AppPessoaContext : DbContext
    {
        public AppPessoaContext (DbContextOptions<AppPessoaContext> options) : base(options)
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
