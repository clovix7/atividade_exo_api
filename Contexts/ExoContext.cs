using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {            
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            if(!optionsBuilder.IsConfigured)
            {
                // Essa string de configutação depende de SUA máquina.
                optionsBuilder .UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True;");
                //Exemplo 1 de String de conexão:
                //User ID-sa;Password=admin;Server=localhost;Database=ExoApi;-//Trusted_Connection=False;
                //Exemplo 2 de string de conexão:
                //Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
            }
        }
        public DbSet<Projeto> Projetos{get; set;}
            }
        }

    
