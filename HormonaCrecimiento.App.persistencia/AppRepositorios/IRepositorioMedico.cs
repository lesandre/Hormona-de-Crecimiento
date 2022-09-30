using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;


namespace HormonaCrecimiento.App.persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico GetMedico(int idMedico);
    }
}