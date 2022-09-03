using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

    internal class AppContext : DbContext
    {
       public DbSet<Persona> Personas{get; set;}
       public DbSet<Medico> Medicos{get; set;}
       public DbSet<FamiliarAsignado> Familiares{get; set;} 
       public DbSet<PacienteNeonato> Pacientes{get; set;}
       
       
       public DbSet<PatronesCrecimiento> PatroCrecimiento{get; set;}
       public DbSet<HistoriaClinica> Historias{get; set;} 
       public DbSet<SugerenciaTratamiento> Sugerencias{get; set;}
       
       
      






       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HormonaCrecimiento");
            }
       }
    }