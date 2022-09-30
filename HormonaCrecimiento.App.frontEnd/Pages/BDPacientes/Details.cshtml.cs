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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        public Paciente Paciente{get; set;}
        public Medico Medico{get; set;}
        public DetailsModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public IActionResult OnGet(int id)
        {
            Paciente = RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./Nofound");
            }
            else{
                if(RepositorioPaciente.ConsultarMedico(id)==null){
                    Medico = new Medico{
                        Nombres="Sin Asignar"
                    };
                    Paciente.Medico=Medico;
                }else{
                    Paciente.Medico=RepositorioPaciente.ConsultarMedico(id);
                }
                return Page();
           }
        }
    }
}
