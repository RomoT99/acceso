using acceso.Datos;
using acceso.Entidades;
using acceso.Negocio.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Negocio
{
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        Conexion db = new Conexion();   
        public List<Estudiante> ListarEstudiantes()
        {
            var query = from x in db.estudiantes
                        orderby x.id
                        select x;
            return query.ToList();
            //return db.estudiantes.ToList();
        }
        public void Actualizar(Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Estudiante estudiante)
        {
            db.estudiantes.Add(estudiante);
            db.SaveChanges();
        }

        public Estudiante Buscar(int id)
        {
            var Busqueda = db.estudiantes.Find(id);
            return Busqueda;
        }

        public List<Estudiante> FiltroID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ListaEstudiantes()
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ListaEstudiantesxNombre(string nombre)
        {
            var query = from x in db.estudiantes
                        where x.nombres.Contains(nombre)
                        select x;
            return query.ToList();
        }

        public Estudiante Buscar()
        {
            throw new NotImplementedException();
        }
    }
}
