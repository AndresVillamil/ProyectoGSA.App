using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades; 


/* Implementación de la Interfaz Reporsitorio Docente */

namespace ProyectoGSA.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona 
    {

        /// <summary>Referencia contexto de docente
        /// </summary>

        private readonly AppContext _appContext;

        /// <param name="AppContext">Metodo constructor a utilizar </param>

        public RepositorioPersona (AppContext appContext)
        { 
            _appContext=appContext;
        }

        Persona IRepositorioPersona.addPersona (Persona Persona)
        {
            var PersonaAdicionado= _appContext.Persona.Add(Persona);
            _appContext.SaveChanges();
            return PersonaAdicionado.Entity;
        }

        void IRepositorioPersona.deletePersona(int IdPersona){
            var PersonaEncontrado= _appContext.Persona.FirstOrDefault(d => d.id==IdPersona);
            if(PersonaEncontrado==null)
                return;
            _appContext.Persona.Remove(PersonaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Persona;
        }

        Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            return _appContext.Persona.FirstOrDefault(d => d.id==IdPersona);
        }

        Persona IRepositorioPersona.updatePersona(Persona Persona)
        {
            var PersonaEncontrado= _appContext.Persona.FirstOrDefault(d => d.id==Persona.id);
            if(PersonaEncontrado!=null)
            {
                PersonaEncontrado.id=Persona.id;
                PersonaEncontrado.nombres=Persona.nombres;
                PersonaEncontrado.apellidos=Persona.apellidos;
                PersonaEncontrado.telefono=Persona.telefono;
                PersonaEncontrado.direccion=Persona.direccion;
                

                _appContext.SaveChanges();
                return PersonaEncontrado;
            }
            return PersonaEncontrado;
        }
    }
    
}