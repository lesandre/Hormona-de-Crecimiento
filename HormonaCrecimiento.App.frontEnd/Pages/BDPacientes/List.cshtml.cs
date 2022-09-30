using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;


namespace HormonaCrecimiento.App.Pages_BDPacientes
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Paciente> pacientes{get; set;}
        public ListModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public void OnGet()
        {
            pacientes = RepositorioPaciente.GetAllPacientes();
        }  
    }
}
