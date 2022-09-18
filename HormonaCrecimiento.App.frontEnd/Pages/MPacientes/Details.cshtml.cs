using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_MPacientes;

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        public Paciente Paciente{get; set;}
        public DetailsModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria){
            this.RepositorioPacienteMemoria = RepositorioPacienteMemoria;
        }
        public IActionResult OnGet(int id)
        {
            Paciente = RepositorioPacienteMemoria.Get(id);
            if(Paciente==null){
                return RedirectToPage("./Nofound");
            }
            else{
                return Page();
           }
        }
    }

