using System;
using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq; 
using ProyectoGSA.App.Dominio.Entidades; 

/* Interfaz de Docente */


namespace ProyectoGSA.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();

        Persona addPersona(Persona Persona);
        Persona updatePersona(Persona Persona);

        void deletePersona(int IdPersona);

        Persona GetPersona(int IdPersona);
    }
}