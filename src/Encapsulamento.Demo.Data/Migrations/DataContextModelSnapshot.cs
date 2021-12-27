﻿// <auto-generated />
using System;
using Encapsulamento.Demo.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Encapsulamento.Demo.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Encapsulamento.Demo.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataPremium")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoDesativacao")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<bool>("Premium")
                        .HasColumnType("bit");

                    b.HasKey("Codigo");

                    b.ToTable("Cliente", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
