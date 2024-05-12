using acceso.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Negocio.interfaces
{
    public interface IEstudianteRepositorio
    {
        void Agregar(Estudiante estudiante);
        void Actualizar(Estudiante estudiante);
        List<Estudiante> ListaEstudiantes();
        List<Estudiante> ListaEstudiantesxNombre(String nombre);
        Estudiante Buscar(int id);
       
    }
}
