using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

public class RepositorioMedicoMemoria : IRepositorioMedicoMemoria
{
  List<Medico> Medicos;
  public RepositorioMedicoMemoria()
  {
    Medicos = new List<Medico>(){
                      new Medico
                      {
          Id = 1,
          Documento="666666666",
          Nombres="Andrea",
          Apellidos="Abril",
          NumeroTelefono="3030303",
          Genero= TipoGenero.Femenino,
          Especialidad= TipoEspecialidad.Pediatra,
          Codigo = "cd1",
          RegistroRethus = "fffff"          
                      },
          new Medico {
          Id = 2,
          Documento="666666666",
          Nombres="Andrea",
          Apellidos="Abril",
          NumeroTelefono="3030303",          
          Genero= TipoGenero.Femenino,
          Especialidad= TipoEspecialidad.Endocrino,
          Codigo = "cd2",
          RegistroRethus = "ddddd" 
                      }
          };
  }
  public IEnumerable<Medico> GetAll()
  {
    return Medicos;
  }
  public Medico Add(Medico Medico)
  {
    Medico.Id= Medicos.Max(M=>M.Id)+1;
    Medicos.Add(Medico);
    return Medico;
  }
  public Medico Update(Medico Medico)
  {
    throw new NotImplementedException();
  }
  public void Delete(int idMedico)
  {
    throw new NotImplementedException();
  }
  public Medico Get(int idMedico)
  {
   return Medicos.SingleOrDefault(M=>M.Id == idMedico);
  }
  // Medico AsignarMedico(int idMedico, int idMedico);


}
