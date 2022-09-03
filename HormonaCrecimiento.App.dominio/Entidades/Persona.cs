using System.Collections.Generic;

namespace HormonaCrecimiento.App.dominio;
public class Persona
{
       public int PersonaId {get; set;}
       public string Documento{get; set;}
       public string Nombres {get; set;}
       public string Apellidos {get; set;}
       public string NumeroTelefono {get; set;}
       public TipoGenero Genero{get; set;}
      
      
       
}