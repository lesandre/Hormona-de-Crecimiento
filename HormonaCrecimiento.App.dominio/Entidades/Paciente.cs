using System.Collections.Generic;


namespace HormonaCrecimiento.App.dominio;
public class Paciente:Persona
{
  
  
 // public string?  Endocrino{get; set;}
  //public string?  Pediatra{get; set;}
  public string? Direccion{get; set;}
  public float? Latitud{get; set;}
  public float? Longitud{get; set;}
  public string? Ciudad{get; set;}  
  
  public DateTime? FechaNacimiento{get; set;}
 
  
  public FamiliarAsignado? FamiliarAsignado{get; set;} 
      
  public Medico? Medico{get; set;}
  public HistoriaClinica? Historia {get; set;}
 // public List<TipoGenero> Generos{get; set;}
   public List<HormonaCrecimiento.App.dominio.PatronesCrecimiento> PatronesCrecimiento{get; set;}
  

}