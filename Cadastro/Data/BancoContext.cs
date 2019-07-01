using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cadastro.Models;

    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastro.Models.Aluno> Aluno { get; set; }
    }
