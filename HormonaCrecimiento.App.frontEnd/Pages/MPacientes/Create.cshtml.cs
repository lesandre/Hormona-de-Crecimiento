using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_MPacientes;

    public class CreateModel : PageModel
    {
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        [BindProperty]// propiedad para que se vea en el html
        public Paciente Paciente{get; set;}
        public CreateModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria)
        {
                this.RepositorioPacienteMemoria = RepositorioPacienteMemoria;
        }
        /*public void OnGet()
        {
        }*/
        public IActionResult OnPostSave(){
        //    if(ModelState.IsValid)
        //       {
                 Paciente= RepositorioPacienteMemoria.Add(Paciente);
                 return RedirectToPage("List");
        //    }
        //    else
        //      {
        //        return Page();
        //    }
        }
    }


