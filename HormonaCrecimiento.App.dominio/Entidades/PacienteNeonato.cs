using System.Collections.Generic;


namespace HormonaCrecimiento.App.dominio;
public class PacienteNeonato:Persona
{
  
  public DateTime FechaNacimiento{get; set;}
  public string  Endocrino{get; set;}
  public string  Pediatra{get; set;}
  public string Direccion{get; set;}
  public float Latitud{get; set;}
  public float Longitud{get; set;}
  public string Ciudad{get; set;}  
  public HistoriaClinica Historia {get; set;}
  
  public List<SugerenciaTratamiento> SugerenciaTratamientos{get; set;}
  
  public FamiliarAsignado FamiliarAsignado{get; set;} 
      
  public Medico Medicos{get; set;}
  
  
  

}