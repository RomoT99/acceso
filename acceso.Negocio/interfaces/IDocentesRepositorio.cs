using acceso.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Negocio.interfaces
{
    public class IDocentesRepositorio
    {
        void Agregar(Docentes docente);
        void Actualizar(Docentes docente);
        List<Docentes> ListaEstudiantes();
        List<Docentes> ListaEstudiantesxNombre(String nombre);
        Docentes Buscar(int id);
    }
}
