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
    public class AddPatronModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]
        public PatronesCrecimiento PatronesCrecimiento{get; set;}
        [BindProperty]
        public Paciente Paciente{get; set;}
        public AddPatronModel(IRepositorioPaciente repositorioPaciente){
            this.RepositorioPaciente = repositorioPaciente;
        } 
        public IActionResult OnGet(int id)
        {
            Paciente = RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }else{
                return Page();
           }
        }
        public IActionResult OnPostSave(){
            if(Paciente.Id>0){
                var paciente= RepositorioPaciente.GetPaciente(Paciente.Id);
                if(Paciente!=null){
                    if(paciente.PatronesCrecimiento!=null){
                        paciente.PatronesCrecimiento.Add(PatronesCrecimiento);
                    }
                    else{
                        paciente.PatronesCrecimiento= new List<PatronesCrecimiento>{
                                new PatronesCrecimiento{
                                    FechaHora=PatronesCrecimiento.FechaHora,
                                    Patrones = PatronesCrecimiento.Patrones,
                                    Valor = PatronesCrecimiento.Valor
                                }
                        };
                    }
                    RepositorioPaciente.UpdatePaciente(paciente);
                }
                return RedirectToPage("List");
            }
            else{
                return Page();
            }
        }
    }
}
