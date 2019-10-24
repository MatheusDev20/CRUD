using CRUD.Data.Mapeamento;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class FuncionarioContexto : DbContext
    {

        public FuncionarioContexto(DbContextOptions<FuncionarioContexto> options)
           : base(options) { }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }
    }
}
