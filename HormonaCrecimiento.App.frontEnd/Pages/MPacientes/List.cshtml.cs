using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_MPacientes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPacienteMemoria repositorioPacienteMemoria;
        public IEnumerable<Paciente> pacientes{get; set;}
        public IndexModel(IRepositorioPacienteMemoria repositorioPacienteMemoria){
            this.repositorioPacienteMemoria = repositorioPacienteMemoria;
        }
        public void OnGet()
        {
            pacientes = repositorioPacienteMemoria.GetAll();
        }
    }
}
