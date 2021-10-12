using System;
using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq; 
using ProyectoGSA.App.Dominio.Entidades; 

/* Interfaz de Docente */


namespace ProyectoGSA.App.Persistencia
{
    public interface IRepositorioDocente
    {
        IEnumerable<Docente> GetAllDocente();

        Docente addDocente(Docente Docente);
        Docente updateDocente(Docente Docente);

        void deleteDocente(int IdDocente);

        Docente GetDocente(int IdDocente);
    }
}