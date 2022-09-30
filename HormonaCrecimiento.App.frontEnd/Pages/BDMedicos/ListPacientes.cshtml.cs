using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HospiEnCasav2.App.Pages_BDMedicos
{
    public class ListPacientesModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Paciente> pacientes{get; set;}
        [BindProperty(SupportsGet=true)]
        public int GetFilters{get; set;}
        public ListPacientesModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public void OnGet(int GetFilters)
        {
            pacientes=RepositorioPaciente.PacientesMedico(GetFilters);
        }
    }
}
