using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades; 


/* Implementación de la Interfaz Reporsitorio Docente */

namespace ProyectoGSA.App.Persistencia
{
    public class RepositorioAcudiente : IRepositorioAcudiente
    {

        /// <summary>Referencia contexto de docente
        /// </summary>

        private readonly AppContext _appContext;

        /// <param name="AppContext">Metodo constructor a utilizar </param>

        public RepositorioAcudiente(AppContext appContext)
        { 
            _appContext=appContext;
        }

        Acudiente IRepositorioAcudiente.AddAcudiente(Acudiente Acudiente)
        {
            var AcudienteAdicionado= _appContext.Acudiente.Add(Acudiente);
            _appContext.SaveChanges();
            return AcudienteAdicionado.Entity;
        }

        void IRepositorioAcudiente.deleteAcudiente(int IdAcudiente){
            var AcudienteEncontrado= _appContext.Acudiente.FirstOrDefault(d => d.id==IdAcudiente);
            if(AcudienteEncontrado==null)
                return;
            _appContext.Acudiente.Remove(AcudienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Acudiente> IRepositorioAcudiente.GetAllAcudiente()
        {
            return _appContext.Acudiente;
        }

        Acudiente IRepositorioAcudiente.GetAcudiente(int IdAcudiente)
        {
            return _appContext.Acudiente.FirstOrDefault(d => d.id==IdAcudiente);
        }

        Acudiente IRepositorioAcudiente.updateAcudiente(Acudiente Acudiente)
        {
            var AcudienteEncontrado= _appContext.Acudiente.FirstOrDefault(d => d.id==Acudiente.id);
            if(AcudienteEncontrado!=null)
            {
                AcudienteEncontrado.id=Acudiente.id;
                AcudienteEncontrado.nombres=Acudiente.nombres;
                AcudienteEncontrado.acudido=Acudiente.acudido;
                

                _appContext.SaveChanges();
                return AcudienteEncontrado;
            }
            return AcudienteEncontrado;
        }
    }
    
}