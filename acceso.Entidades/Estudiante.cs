using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceso.Entidades
{
    public class Estudiante
    {
        public int id { get; set; }
        public string num_doc { get; set; }
        public string nombres { get; set; }
        public string email { get; set;}
        public bool estado { get; set; }
    }
}
