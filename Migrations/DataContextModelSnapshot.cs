﻿// <auto-generated />
using CNPJApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CNPJApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CNPJApi.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_EMPRESAS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "26.375.761/0001-11",
                            Email = "ana.silva@saintgobain.com",
                            Nome = "SaintGoabin",
                            Telefone = "11 93718-2661"
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "42.575.821/0002-15",
                            Email = "ana.silva@marabraz2.com",
                            Nome = "Marabraz2",
                            Telefone = "11 93128-5567"
                        },
                        new
                        {
                            Id = 3,
                            CNPJ = "64.634.859/0046-83",
                            Email = "ana.silva@telhanorte.com",
                            Nome = "Telha Norte",
                            Telefone = "11 97402-9123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
