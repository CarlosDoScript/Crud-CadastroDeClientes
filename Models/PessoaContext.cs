using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeCliente.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) 
        {
        }

        public DbSet<PessoaFisica> pessoaFisica  { get; set; }


    }
}
