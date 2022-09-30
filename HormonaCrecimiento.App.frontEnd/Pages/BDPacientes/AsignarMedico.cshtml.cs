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
    public class AsignarMedicoModel : PageModel
    {
        private readonly IRepositorioMedico RepositorioMedico;
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Medico> Medicos{get; set;}
        [BindProperty]
        public int medicoId{get; set;}
        [BindProperty]
        public Medico Medico{get; set;}
        [BindProperty]
        public Paciente Paciente{get; set;}
        public AsignarMedicoModel(IRepositorioMedico RepositorioMedico,IRepositorioPaciente RepositorioPaciente){
            this.RepositorioMedico= RepositorioMedico;
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public IActionResult OnGet(int id){
            Medicos= RepositorioMedico.GetAllMedicos();
            Paciente=RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
           }
        }
        public IActionResult OnPostToAssign(int medicoId){
                Medico= RepositorioPaciente.AsignarMedico(Paciente.Id,medicoId);
                return RedirectToPage("List");
        }
    }
}
