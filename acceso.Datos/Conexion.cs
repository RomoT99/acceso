using acceso.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Datos
{
    public class Conexion : DbContext
    {
        public object estudiante;

        public Conexion() : base("cadenaConexion1") 
        { 
        }
        public virtual DbSet<Estudiante> estudiantes { get; set; }
        public virtual DbSet<Docentes> docente { get; set; }
    }
}
