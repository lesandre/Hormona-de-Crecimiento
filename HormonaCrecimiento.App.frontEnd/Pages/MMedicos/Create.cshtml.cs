using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_MMedicos;

    public class CreateModel : PageModel
    {
         private readonly IRepositorioMedicoMemoria RepositorioMedicoMemoria;
        [BindProperty]// propiedad para que se vea en el html
        public Medico Medico{get; set;}
        public CreateModel(IRepositorioMedicoMemoria RepositorioMedicoMemoria){
                this.RepositorioMedicoMemoria = RepositorioMedicoMemoria;
        }
        /*public void OnGet()
        {
        }*/
        public IActionResult OnPostSave(){
         //   if(ModelState.IsValid){
                    Medico= RepositorioMedicoMemoria.Add(Medico);
                    return RedirectToPage("./Index");
        //    }
        //    else{
        //        return Page();
        //    }

        }
    }

