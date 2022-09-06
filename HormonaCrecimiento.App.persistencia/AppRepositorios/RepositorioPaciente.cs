using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;


    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext)
        {
          _appContext = appContext;
        }
        public IEnumerable<Paciente> GetAllPacientes()
        {
          return _appContext.Pacientes;
        }
        public Paciente AddPaciente(Paciente paciente)
        {
          var pacienteAgregado = _appContext.Pacientes.Add(paciente);
          _appContext.SaveChanges();
          return pacienteAgregado.Entity;
        }
        public Paciente UpdatePaciente(Paciente paciente)
        {
          var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id==paciente.Id);
          if(pacienteEncontrado!=null)
          {
            pacienteEncontrado.Documento = paciente.Documento;
            pacienteEncontrado.Nombres = paciente.Nombres;
            pacienteEncontrado.Apellidos = paciente.Apellidos; 
            pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
            pacienteEncontrado.Genero = paciente.Genero;
            pacienteEncontrado.Direccion = paciente.Direccion;
            pacienteEncontrado.Latitud = paciente.Latitud;
            pacienteEncontrado.Longitud = paciente.Longitud;
            pacienteEncontrado.Ciudad = paciente.Ciudad;
            pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
            pacienteEncontrado.FamiliarAsignado = paciente.FamiliarAsignado;
            
            pacienteEncontrado.Medico = paciente.Medico;
            pacienteEncontrado.Historia = paciente.Historia;
            _appContext.SaveChanges();
          }
          return pacienteEncontrado;


        }
        public void DeletePaciente(int idPaciente)
        {
          var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);

          if(pacienteEncontrado==null)
          {
            return;
          }
          _appContext.Pacientes.Remove(pacienteEncontrado);
          _appContext.SaveChanges();

        }
        public Paciente GetPaciente(int idPaciente)
        {
          return _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
        }
        public Medico AsignarMedico(int idPaciente, int idMedico)
        {
          var paciente = _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if(paciente!=null)
            {
              var medico = _appContext.Medicos.FirstOrDefault(m=>m.Id==idMedico);
              if(medico!=null)
              {
                paciente.Medico = medico;
                _appContext.SaveChanges();
              }
              return medico;
            }
            return null;

        }
    }
