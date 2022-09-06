using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using Microsoft.EntityFrameworkCore;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

    public class AppContext : DbContext
    {
       public DbSet<Persona> Personas{get; set;}
       public DbSet<Paciente> Pacientes{get; set;}
       public DbSet<Medico> Medicos{get; set;}
       public DbSet<FamiliarAsignado> Familiares{get; set;} 
       
       
       
       public DbSet<PatronesCrecimiento> PatronesCrecimiento{get; set;}
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