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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]
        public Paciente Paciente{get; set;}
        
        public EditModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public IActionResult OnGet(int id)
        {
            Paciente = RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./Nofound");
            }else{
                return Page();
            }
        }
        public IActionResult OnPost(){
            Paciente = RepositorioPaciente.UpdatePaciente(Paciente);
            return Page();
        }
    
    }
}