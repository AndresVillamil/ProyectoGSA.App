using System;
using System.Collections.Generic; /*Donde se encuentra definida la interface*/
using System.Linq; 
using ProyectoGSA.App.Dominio.Entidades; 

/* Interfaz de Docente */


namespace ProyectoGSA.App.Persistencia
{
    public interface IRepositorioAcudiente
    {
        IEnumerable<Acudiente> GetAllAcudiente();

        Acudiente AddAcudiente(Acudiente Acudiente);
        Acudiente updateAcudiente(Acudiente Acudiente);

        void deleteAcudiente(int IdAcudiente);

        Acudiente GetAcudiente(int IdAcudiente);
    }
}