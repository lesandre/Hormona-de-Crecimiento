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
    public class ListModel : PageModel
    {
        private readonly IRepositorioMedico RepositorioMedico;
        public IEnumerable<Medico> Medicos{get; set;}
        public ListModel(IRepositorioMedico RepositorioMedico){
            this.RepositorioMedico = RepositorioMedico;
        }
        public void OnGet()
        {
            Medicos = RepositorioMedico.GetAllMedicos();
        }
    }
}
