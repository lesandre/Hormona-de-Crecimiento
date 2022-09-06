// See https://aka.ms/new-console-template for more information

using System;
using HormonaCrecimiento.App.dominio;
using HormonaCrecimiento.App.persistencia;



namespace HormonaCrecimiento.App.consola
{
  class Program
  {
   // private static IRepositorio _RepoPacienteNeonato = new RepositorioPacienteNeonato(new persistencia.AppContext());
    //private static IRepositorioMedico _RepoMedico = new RepositorioMedico(new //////persistencia.AppContext());

    private static void Main(string[] args)
    {
     // AddPaciente();
    // BuscarPaciente(2); 
     // VerPacientes();
     // EliminarPaciente(4);
      Console.WriteLine("Hello, World!");
     //AddMedico();
     // AsignarMedico();
    }
   /* private static void AddPacienteNeonato(){
      var paciente = new Paciente{
          Documento="666666666",
          Nombres="Andrea",
          Apellidos="Abril",
          Telefono="3030303",
          Direccion="transv 4 # 87-14 Sur",
          Latitud=9.2122222F,
          Longitud=-85.25F,
          Ciudad="Bogota",
          Genero= Genero.Femenino,
          FechaNacimiento=new DateTime(1985,04,05),
      };
      _RepoPacienteNeonato.AddPacienteNeonato(paciente);



    }
    private static void BuscarPaciente(int idPacienteNeonato){
        var paciente=_RepoPacienteNeonato.GetPacienteNeonato(idPacienteNeonato);
       // Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellido+" ");
        paciente.Nombre = "pedro";
        ModificarPaciente(paciente);

    }

    private static void VerPacientes(){
        var pacientes = _RepoPacienteNeonato.GetAllPacientes();
        foreach(var paciente in pacientes){
          Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellido+" ");
        }


    }

    private static void ModificarPaciente(Paciente paciente){
      _RepoPacienteNeonato.UpdatePacienteNeonato(paciente);
    }

    private static void EliminarPaciente(int idPaciente){
        _RepoPacienteNeonato.DeletePacienteNeonato(idPaciente);
    }
    
    private static void AddMedico(){
      var medico = new Medico{
          Documento="666666666",
          Nombre="Carla",
          Apellido="Hernandez",
          Telefono="454545",          
          Genero= Genero.Femenino,
          Especialidad = "pediatra",
          Codigo="201",
          RegistroRethus="757576",
          
      };
      _RepoMedico.AddMedico(medico);



    }

    private static void AsignarMedico(){
      var medico = _RepoPacienteNeonato.AsignarMedico(1, 5);
      consola.WriteLine(medico.Nombre);
    }*/

  }

}
