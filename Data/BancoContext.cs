using Microsoft.EntityFrameworkCore;
using Projeto_Controle_de_contatos___Minsait_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Projeto_Controle_de_contatos___Minsait_2.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
