using System;
using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq; 
using ProyectoGSA.App.Dominio.Entidades; 

/* Interfaz de Docente */


namespace ProyectoGSA.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiante();

        Estudiante addEstudiante(Estudiante Estudiante);
        Estudiante updateEstudiante(Estudiante Estudiante);

        void deleteEstudiante(int IdEstudiante);

        Estudiante GetEstudiante(int IdEstudiante);
    }
}