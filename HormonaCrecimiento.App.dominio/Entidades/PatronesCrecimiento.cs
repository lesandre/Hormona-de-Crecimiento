namespace HormonaCrecimiento.App.dominio;
public class PatronesCrecimiento
{
  public int Id {get; set;}
  public DateTime? FechaHora {get; set;}       
  public TipoPatrones? Patrones {get; set;}
  public float? Valor{get; set;} 
}