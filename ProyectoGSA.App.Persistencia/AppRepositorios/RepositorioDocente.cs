using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades; 


/* Implementación de la Interfaz Reporsitorio Docente */

namespace ProyectoGSA.App.Persistencia
{
    public class RepositorioDocente : IRepositorioDocente 
    {

        /// <summary>Referencia contexto de docente
        /// </summary>

        private readonly AppContext _appContext;

        /// <param name="AppContext">Metodo constructor a utilizar </param>

        public RepositorioDocente (AppContext appContext)
        { 
            _appContext=appContext;
        }

        Docente IRepositorioDocente.addDocente(Docente Docente)
        {
            var DocenteAdicionado= _appContext.Docente.Add(Docente);
            _appContext.SaveChanges();
            return DocenteAdicionado.Entity;
        }

        void IRepositorioDocente.deleteDocente(int IdDocente){
            var DocenteEncontrado= _appContext.Docente.FirstOrDefault(d => d.id==IdDocente);
            if(DocenteEncontrado==null)
                return;
            _appContext.Docente.Remove(DocenteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Docente> IRepositorioDocente.GetAllDocente()
        {
            return _appContext.Docente;
        }

        Docente IRepositorioDocente.GetDocente(int IdDocente)
        {
            return _appContext.Docente.FirstOrDefault(d => d.id==IdDocente);
        }

        Docente IRepositorioDocente.updateDocente(Docente Docente)
        {
            var DocenteEncontrado= _appContext.Docente.FirstOrDefault(d => d.id==Docente.id);
            if(DocenteEncontrado!=null)
            {
                DocenteEncontrado.id=Docente.id;
                DocenteEncontrado.nombres=Docente.nombres;
                DocenteEncontrado.profesion=Docente.profesion;
                

                _appContext.SaveChanges();
                return DocenteEncontrado;
            }
            return DocenteEncontrado;
        }
    }
    
}