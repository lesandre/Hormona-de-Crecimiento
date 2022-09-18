using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

public class RepositorioPacienteMemoria : IRepositorioPacienteMemoria
{
  List<Paciente> pacientes;
  public RepositorioPacienteMemoria()
  {
    pacientes = new List<Paciente>(){
                      new Paciente
                      {
          Id = 1,
          Documento="666666666",
          Nombres="Andrea",
          Apellidos="Abril",
          NumeroTelefono="3030303",
          Direccion="transv 4 # 87-14 Sur",
          Latitud=9.2122222F,
          Longitud=-85.25F,
          Ciudad="Bogota",
          Genero= TipoGenero.Femenino,
          FechaNacimiento=new DateTime(1985,04,05),
                      },
          new Paciente {
          Id = 2,
          Documento="666666666",
          Nombres="Andrea",
          Apellidos="Abril",
          NumeroTelefono="3030303",
          Direccion="transv 4 # 87-14 Sur",
          Latitud=9.2122222F,
          Longitud=-85.25F,
          Ciudad="Bogota",
          Genero= TipoGenero.Femenino,
          FechaNacimiento=new DateTime(1985,04,05),
                      }
          };
  }
  public IEnumerable<Paciente> GetAll()
  {
    return pacientes;
  }
  public Paciente Add(Paciente paciente)
  {
    paciente.Id= pacientes.Max(p=>p.Id)+1;
    pacientes.Add(paciente);
    return paciente;
  }
  public Paciente Update(Paciente paciente)
  {
    // return pacientes.SingleOrDefault(p=>p.Id == paciente); 
    throw new NotImplementedException();
  }
  public void Delete(int idPaciente)
  {
    throw new NotImplementedException();
  }
  public Paciente Get(int idPaciente)
  {
   return pacientes.SingleOrDefault(p=>p.Id == idPaciente);
  }
  // Medico AsignarMedico(int idPaciente, int idMedico);


}
