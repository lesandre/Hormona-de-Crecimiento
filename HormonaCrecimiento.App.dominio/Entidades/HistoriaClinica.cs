using System.Collections.Generic;

namespace HormonaCrecimiento.App.dominio;
public class HistoriaClinica
{
  public int Id { get; set; }
  public string? Diagnostico { get; set; }
  public List<HormonaCrecimiento.App.dominio.SugerenciaTratamiento> Sugerencias { get; set; }
}