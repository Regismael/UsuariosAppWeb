﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Entities;

namespace UsuariosApp.Infra.Data.Mappings
{
    public class PermissaoMap : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Permissao> builder)
        {
            builder.ToTable("TB_PERMISSAO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .HasColumnName("ID");

            builder.Property(p => p.Nome)
            .HasColumnName("NOME")
            .HasMaxLength(50)
            .IsRequired();
        }
    }
}
