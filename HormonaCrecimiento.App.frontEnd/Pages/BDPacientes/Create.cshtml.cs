using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_BDPacientes;

    public class CreateModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]// propiedad para que se vea en el html
        public Paciente Paciente{get; set;}
        public CreateModel(IRepositorioPaciente RepositorioPaciente)
        {
                this.RepositorioPaciente = RepositorioPaciente;
        }
        //public void OnGet()
        //{
        //}
        public IActionResult OnPostSave()
        {
        //    if(ModelState.IsValid)
        //       {
                 Paciente= RepositorioPaciente.AddPaciente(Paciente);
                 return RedirectToPage("List");
        //    }
        //    else
        //      {
        //        return Page();
        //    }
        }
    }

