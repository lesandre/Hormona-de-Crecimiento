using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);

        
    }
