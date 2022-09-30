using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HormonaCrecimiento.App.dominio;

namespace HormonaCrecimiento.App.persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext;
        public RepositorioMedico(AppContext appContext){
          _appContext = appContext;
        }
        public IEnumerable<Medico> GetAllMedicos()
        {
          return _appContext.Medicos;
        }
        public Medico AddMedico(Medico medico)
        {
          var MedicoAgregado = _appContext.Medicos.Add(medico);
          _appContext.SaveChanges();
          return MedicoAgregado.Entity;
        }
        public Medico UpdateMedico(Medico medico)
        {
          var MedicoEncontrado = _appContext.Medicos.FirstOrDefault(m=>m.Id==medico.Id);
          if(MedicoEncontrado!=null){
            MedicoEncontrado.Documento = medico.Documento;
            MedicoEncontrado.Nombres = medico.Nombres;
            MedicoEncontrado.Apellidos = medico.Apellidos; 
            MedicoEncontrado.NumeroTelefono = medico.NumeroTelefono;
            MedicoEncontrado.Genero = medico.Genero;
            MedicoEncontrado.Especialidad = medico.Especialidad;
            MedicoEncontrado.Codigo = medico.Codigo;
            MedicoEncontrado.RegistroRethus = medico.RegistroRethus;
            _appContext.SaveChanges();
          }
          return MedicoEncontrado;


        }
        public void DeleteMedico(int idMedico){
          var MedicoEncontrado = _appContext.Medicos.FirstOrDefault(m=>m.Id==idMedico);

          if(MedicoEncontrado==null){
            return;
          }
          _appContext.Medicos.Remove(MedicoEncontrado);
          _appContext.SaveChanges();

        }
        public Medico GetMedico(int idMedico)
        {
          return _appContext.Medicos.FirstOrDefault(m=>m.Id==idMedico);
        }
    }
}