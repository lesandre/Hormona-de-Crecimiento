using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HormonaCrecimiento.App.persistencia;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.Pages_MMedicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMedicoMemoria repositorioMedicoMemoria;
        public IEnumerable<Medico> Medicos{get; set;}
        public IndexModel(IRepositorioMedicoMemoria repositorioMedicoMemoria){
            this.repositorioMedicoMemoria = repositorioMedicoMemoria;
        }
        public void OnGet()
        {
            Medicos = repositorioMedicoMemoria.GetAll();
        }
    }
}
