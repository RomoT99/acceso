using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Entidades
{
    public class Docentes
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public TimeSpan HorarioIngreso { get; set; }
        public int TiempoTolerancia { get; set; }
        public TimeSpan? HoraIngresoReal { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string Estado { get; set; }

        // Constructor vacío
        public Docentes()
        {
        }

        // Constructor con parámetros
        public Docentes(string nombre, TimeSpan horarioIngreso, int tiempoTolerancia)
        {
            Nombre = nombre;
            HorarioIngreso = horarioIngreso;
            TiempoTolerancia = tiempoTolerancia;
        }

        // Método para verificar el estado del docente al llegar
        public void VerificarEstado()
        {
            if (HoraIngresoReal.HasValue && FechaIngreso.HasValue)
            {
                TimeSpan horaInicioTolerancia = HorarioIngreso.Subtract(new TimeSpan(0, TiempoTolerancia, 0));
                TimeSpan horaLimite = HorarioIngreso;

                if (HoraIngresoReal >= horaInicioTolerancia && HoraIngresoReal <= horaLimite)
                {
                    Estado = "A tiempo";
                }
                else if (HoraIngresoReal < horaInicioTolerancia)
                {
                    Estado = "Temprano";
                }
                else
                {
                    Estado = "Tarde";
                }
            }
        }
    }
}
