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
    public class DocenteNegocio : IDocentesRepositorio
    {
        Conexion db = new Conexion();
        public List<Docentes> ListarDocentes()
        {
            var query = from x in db.docente
                        orderby x.id
                        select x;
            return query.ToList();
            //return db.estudiantes.ToList();
        }
        public void Actualizar(Docentes docente)
        {
            db.Entry(docente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Docentes docente)
        {
            db.estudiantes.Add(docente);
            db.SaveChanges();
        }

        public Docentes Buscar(int id)
        {
            var Busqueda = db.docente.Find(id);
            return Busqueda;
        }


        public List<Estudiante> ListarDocentesxNombre(string nombre)
        {
            var query = from x in db.docente
                        where x.nombres.Contains(nombre)
                        select x;
            return query.ToList();
        }
    }
}
