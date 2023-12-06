using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using CNPJApi.Models;


namespace CNPJApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Empresa> TB_EMPRESAS { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>().HasData
            (
                new Empresa() {Id = 1, Nome = "SaintGoabin", CNPJ = "26.375.761/0001-11", Telefone = "11 93718-2661", Email = "ana.silva@saintgobain.com"},
                new Empresa() {Id = 2, Nome = "Marabraz2", CNPJ = "42.575.821/0002-15", Telefone = "11 93128-5567", Email = "ana.silva@marabraz2.com"},
                new Empresa() {Id = 3, Nome = "Telha Norte", CNPJ = "64.634.859/0046-83", Telefone = "11 97402-9123", Email = "ana.silva@telhanorte.com"} 
            );
        }
    } 
}