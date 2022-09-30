using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_BDMedicos
{
  public class CreateModel : PageModel
  {
    private readonly IRepositorioMedico RepositorioMedico;
    [BindProperty]// propiedad para que se vea en el html
    public Medico Medico { get; set; }
    public CreateModel(IRepositorioMedico RepositorioMedico)
    {
      this.RepositorioMedico = RepositorioMedico;
    }
    /*public void OnGet()
    {
    }*/
    public IActionResult OnPostSave()
    {
      //   if(ModelState.IsValid){
      Medico = RepositorioMedico.AddMedico(Medico);
      return RedirectToPage("List");
      //    }
      //    else{
      //        return Page();
      //    }

    }
  }
}
