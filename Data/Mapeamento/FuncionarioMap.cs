using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data.Mapeamento
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(40).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(30).IsRequired();
            builder.Property(t => t.Dep).HasMaxLength(30).IsRequired();
            builder.Property(t => t.Date).HasMaxLength(10).IsRequired();
            PropertyBuilder<bool> propertyBuilder = builder.Property(t => t.Acess);
            builder.Property(t => t.Login).HasMaxLength(20).IsRequired();
            builder.Property(t => t.Senha).HasMaxLength(15).IsRequired();
            builder.Property(t => t.ConfirmSenha).HasMaxLength(15).IsRequired();
            builder.Property(t => t.Tel1).HasMaxLength(15).IsRequired();
            builder.Property(t => t.Tel2).HasMaxLength(15).IsRequired(false);

            builder.ToTable("Funcionários");
        }
    }

}
