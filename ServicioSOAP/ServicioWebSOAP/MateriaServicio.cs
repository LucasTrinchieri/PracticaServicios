using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWebSOAP
{
    public class MateriaServicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public bool EnElPrograma { get; set; }

        public MateriaServicio()
        {

        }

        public MateriaServicio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            EnElPrograma = true;
        }
    }
}