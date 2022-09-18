using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia;

    public interface IRepositorioPacienteMemoria
    {
        IEnumerable<Paciente> GetAll();
        Paciente Add(Paciente paciente);
        Paciente Update(Paciente paciente);
        void Delete(int idPaciente);
        Paciente Get(int idPaciente);
       // Medico AsignarMedico(int idPaciente, int idMedico);

        
    }
