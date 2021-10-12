using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades; 


/* Implementación de la Interfaz Reporsitorio Docente */

namespace ProyectoGSA.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante 
    {

        /// <summary>Referencia contexto de docente
        /// </summary>

        private readonly AppContext _appContext;

        /// <param name="AppContext">Metodo constructor a utilizar </param>

        public RepositorioEstudiante  (AppContext appContext)
        { 
            _appContext=appContext;
        }

        Estudiante IRepositorioEstudiante.addEstudiante (Estudiante  Estudiante )
        {
            var EstudianteAdicionado= _appContext.Estudiante.Add(Estudiante );
            _appContext.SaveChanges();
            return EstudianteAdicionado.Entity;
        }

        void IRepositorioEstudiante.deleteEstudiante(int IdEstudiante){
            var EstudianteEncontrado= _appContext.Estudiante.FirstOrDefault(d => d.id==IdEstudiante);
            if(EstudianteEncontrado==null)
                return;
            _appContext.Estudiante.Remove(EstudianteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiante;
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante)
        {
            return _appContext.Estudiante.FirstOrDefault(d => d.id==IdEstudiante);
        }

        Estudiante IRepositorioEstudiante.updateEstudiante(Estudiante Estudiante)
        {
            var EstudianteEncontrado= _appContext.Estudiante.FirstOrDefault(d => d.id==Estudiante.id);
            if(EstudianteEncontrado!=null)
            {
                EstudianteEncontrado.id=Estudiante.id;
                EstudianteEncontrado.nombres=Estudiante.nombres;
                EstudianteEncontrado.apellidos=Estudiante.apellidos;
                

                _appContext.SaveChanges();
                return EstudianteEncontrado;
            }
            return EstudianteEncontrado;
        }
    }
    
}