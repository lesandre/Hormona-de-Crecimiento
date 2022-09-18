using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

    public interface IRepositorioMedicoMemoria
    {
        IEnumerable<Medico> GetAll();
        Medico Add(Medico Medico);
        Medico Update(Medico Medico);
        void Delete(int idMedico);
        Medico Get(int idMedico);
       // Medico AsignarMedico(int idMedico, int idMedico);

        
    }
