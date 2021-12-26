using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Encapsulamento.Demo.Domain.Entities;

namespace Encapsulamento.Demo.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}